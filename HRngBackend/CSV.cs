/*
 * CSV.cs - Functions for reading (parsing) and writing (generating)
 *          comma-separated values (CSV) files.
 * Created on: 18:32 01-01-2022
 * Author    : itsmevjnk
 */

using System;
using System.IO;
using System.Threading.Tasks;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;

namespace HRngBackend
{
    public static class CSV
    {
        /*
         * public static Spreadsheet FromStream(Stream input, [char delimiter],
         *                                      [char escape], [string newline])
         *   Parse a stream of CSV-formatted data.
         *   Input : input    : The CSV-formatted data stream.
         *           encoding : The stream's encoding (optional).
         *                      Defaults to UTF-8.
         *           bom      : Whether to detect encoding from byte
         *                      order mark (BOM) (optional).
         *                      Disabled by default.
         *           delimiter: The delimiter between cells in a row
         *                      (optional). Defaults to comma (,).
         *           escape   : The enclosing character used in cases
         *                      such as multi-line cells. Defaults to
         *                      double quote (").
         *           newline  : The new line character(s) used in the
         *                      CSV string. If not specified, any
         *                      combination of \r and \n will be used.
         *           The default values of delimiter and escape are
         *           compliant with IETF RFC 4180.
         *   Output: A Spreadsheet instance generated from the input.
         */
        public static Spreadsheet FromStream(Stream input, Encoding encoding = null, bool bom = false, char delimiter = ',', char escape = '"', string newline = "")
        {
            encoding = encoding ?? Encoding.UTF8;
            
            Spreadsheet output = new Spreadsheet();

            int row = 0, col = 0; // Processing cell's row and column index
            string val = ""; // Cell value
            bool escaped = false; // Set when the current cell is escaped
            Queue c_queue = new Queue(); // Character queue, used for seeking multiple bytes in advance
            using (StreamReader reader = new StreamReader(input, encoding, bom))
            {
                while (!reader.EndOfStream || c_queue.Count > 0)
                {
                    char c;
                    if (c_queue.Count > 0) c = (char)c_queue.Dequeue();
                    else c = (char)reader.Read();
                    if (c == -1) break; // End of stream
                    if ((newline.Length > 0 && c == newline[0]) ||
                        (newline.Length == 0 && (c == '\r' || c == '\n')))
                    {
                        /* Possible row end */
                        bool end = false; // Set if this is really row end
                        if (newline.Length == 0)
                        {
                            /* Any \r and \n combinations */
                            char c_next = (char)reader.Peek();
                            if ((c == '\r' && c_next == '\n') || (c == '\n' && c_next == '\r'))
                            {
                                /* \r\n or \n\r */
                                reader.Read();
                                end = true;
                            }
                            else end = true; // Single new line character, leave next character for next iteration
                        }
                        else
                        {
                            string seq = ""; // For temporarily storing the sequence if we need to return it to cache
                            end = true; // We'll use this to signal byte mismatch
                            for (int i = 1; i < newline.Length && end; i++)
                            {
                                char c_next = (char)reader.Read();
                                end = (c_next == newline[i]);
                                seq += $"{c_next}";
                            }
                            if (!end)
                            {
                                /* Byte mismatch, push all those characters we just read to queue */
                                foreach (char cs in seq) c_queue.Enqueue(cs);
                            }
                        }
                        if (end) c = '\n'; // Normalize new line to \n
                    }
                    if (c == escape)
                    {
                        escaped = !escaped; // Escape character, toggle escaped flag
                        if (!escaped && (char)reader.Peek() == escape)
                        {
                            /* Double escape character is used for putting escape character in cell value */
                            escaped = true; // Still escaping
                            val += $"{c}";
                            reader.Read(); // Advance to next character
                        }
                    }
                    else if (!escaped)
                    {
                        if (c == delimiter)
                        {
                            /* Cell end */
                            output.Update((row, col), val.Replace("\n", Environment.NewLine));
                            val = ""; col++;
                        }
                        else if (c == '\n')
                        {
                            output.Update((row, col), val.Replace("\n", Environment.NewLine));
                            val = ""; row++; col = 0;
                        }
                        else val += $"{c}";
                    }
                    else val += $"{c}";
                }
            }

            return output;
        }

        /*
         * public static Spreadsheet FromString(string input, [char delimiter],
         *                                      [char escape], [string newline])
         *   Parse a string containing CSV-formatted data.
         *   Input : input    : The CSV-formatted data.
         *           delimiter: The delimiter between cells in a row
         *                      (optional). Defaults to comma (,).
         *           escape   : The enclosing character used in cases
         *                      such as multi-line cells. Defaults to
         *                      double quote (").
         *           newline  : The new line character(s) used in the
         *                      CSV string. If not specified, any
         *                      combination of \r and \n will be used.
         *           The default values of delimiter and escape are
         *           compliant with IETF RFC 4180.
         *   Output: A Spreadsheet instance generated from the input.
         */
        public static Spreadsheet FromString(string input, char delimiter = ',', char escape = '"', string newline = "")
        {
            using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(input)))
            {
                return FromStream(stream, delimiter: delimiter, escape: escape, newline: newline);
            }
        }

        /*
         * public static Spreadsheet FromFile(string fname, [char delimiter],
         *                                    [char escape], [string newline])
         *   Parse a CSV file.
         *   Input : fname   : The path (absolute or relative to the
         *                     backend) to the CSV file.
         *           encoding: The file's encoding (optional).
         *                     Defaults to UTF-8.
         *           bom     : Whether the encoding is detected using
         *                     the file's byte order mark (BOM)
         *                     (optional). Defaults to enabled.
         *           The other three arguments are the same as in
         *           FromString().
         *   Output: A Spreadsheet instance generated from the input.
         */
        public static Spreadsheet FromFile(string fname, Encoding encoding = null, bool bom = true, char delimiter = ',', char escape = '"', string newline = "")
        {
            encoding = encoding ?? Encoding.UTF8;
            using (FileStream stream = File.Open(fname, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                return FromStream(stream, encoding, bom, delimiter, escape, newline);
            }
        }

        /*
         * public static void ToStream(Spreadsheet sheet, Stream stream,
         *                             [Encoding encoding],
         *                             [char delimiter], [char escape],
         *                             [string sheet_nl], [string newline])
         *   Writes the spreadsheet to a CSV-formatted stream.
         *   Input : sheet    : The Spreadsheet object to be written.
         *           stream   : The destination stream.
         *           encoding : The stream's encoding. Set to UTF-8
         *                      by default.
         *           delimiter: The delimiter between cells in a row
         *                      (optional). Defaults to comma (,).
         *           escape   : The enclosing character used in cases
         *                      such as multi-line cells. Defaults to
         *                      double quote (").
         *           sheet_nl : The new line character(s) used in the
         *                      spreadsheet (optional). Defaults to
         *                      Environment.NewLine.
         *           newline  : The new line character(s) used in the
         *                      CSV string (optional). Defaults to
         *                      \r\n.
         *           The default values are compliant with IETF RFC 4180.
         *   Output: A string of CSV-formatted data.
         */
        public static void ToStream(Spreadsheet sheet, Stream stream, Encoding encoding = null, char delimiter = ',', char escape = '"', string sheet_nl = null, string newline = "\r\n")
        {
            using(StreamWriter writer = new StreamWriter(stream, encoding ?? Encoding.UTF8))
            {
                sheet_nl = sheet_nl ?? Environment.NewLine;
                bool nl_replace = (sheet_nl != newline); // Set if new line character replacement is needed
                string cell = ""; // Cell value

                /* Preprocessed for optimized memory usage (i.e. less GC) */
                string escape_str = $"{escape}";
                string escape_escape_str = $"{escape}{escape}";

                for (int row = 0; row < sheet.Rows; row++)
                {
                    for (int col = 0; col < sheet.Columns; col++)
                    {
                        if (sheet.Data.ContainsKey((row, col)))
                        {
                            cell = sheet.Data[(row, col)];
                            if (nl_replace) cell = cell.Replace(sheet_nl, newline);
                            if (cell.Contains(escape) || cell.Contains(delimiter) || cell.Contains(newline))
                            {
                                cell = escape_str + cell.Replace(escape_str, escape_escape_str) + escape_str; // Escape cell value
                            }
                        }
                        else cell = "";
                        writer.Write(cell);
                        if (col != sheet.Columns - 1) writer.Write(delimiter);
                    }
                    writer.Write(newline);
                }
            }
        }

        /*
         * public static string ToString(Spreadsheet sheet, [char delimiter],
         *                               [char escape], [string sheet_nl],
         *                               [string newline])
         *   Writes the spreadsheet to a CSV-formatted string.
         *   Input : sheet    : The Spreadsheet object to be written.
         *           delimiter: The delimiter between cells in a row
         *                      (optional). Defaults to comma (,).
         *           escape   : The enclosing character used in cases
         *                      such as multi-line cells. Defaults to
         *                      double quote (").
         *           sheet_nl : The new line character(s) used in the
         *                      spreadsheet (optional). Defaults to
         *                      Environment.NewLine.
         *           newline  : The new line character(s) used in the
         *                      CSV string (optional). Defaults to
         *                      \r\n.
         *           The default values are compliant with IETF RFC 4180.
         *   Output: A string of CSV-formatted data.
         */
        public static string ToString(Spreadsheet sheet, char delimiter = ',', char escape = '"', string sheet_nl = null, string newline = "\r\n")
        {
            using(MemoryStream stream = new MemoryStream())
            {
                ToStream(sheet, stream, delimiter: delimiter, escape: escape, sheet_nl: sheet_nl, newline: newline);
                return Encoding.UTF8.GetString(stream.GetBuffer(), 0, (int)stream.Length);
            }
        }

        /*
         * public static void ToFile(Spreadsheet sheet, string fname,
         *                           [Encoding encoding], [char delimiter],
         *                           [char escape], [string sheet_nl],
         *                           [string newline])
         *   Writes the spreadsheet to a CSV file.
         *   Input : fname   : The path (absolute or relative to the
         *                     backend) to the CSV file.
         *           encoding: The encoding to be used in the file.
         *                     Defaults to UTF-8.
         *           Other arguments are the same as in ToString().
         *   Output: none.
         */
        public static void ToFile(Spreadsheet sheet, string fname, Encoding encoding = null, char delimiter = ',', char escape = '"', string sheet_nl = null, string newline = "\r\n")
        {
            using(FileStream stream = File.Create(fname))
            {
                ToStream(sheet, stream, encoding, delimiter, escape, sheet_nl, newline);
            }
        }
    }
}
