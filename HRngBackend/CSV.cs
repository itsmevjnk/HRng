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

namespace HRngBackend
{
    public static class CSV
    {
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
            Spreadsheet output = new Spreadsheet();

            /* Normalize new line character(s) to \n for easy parsing */
            if (newline.Length > 0) input = input.Replace(newline, "\n");
            else input = Regex.Replace(input, "(\r\n)|(\n\r)|(\n)|(\r)", "\n"); // TODO: Check if this really works

            int row = 0, col = 0; // Processing cell's row and column index
            int n = 0; // Index of character in the input string
            string val = ""; // Cell value
            bool escaped = false; // Set when the current cell is escaped
            while (n < input.Length)
            {
                char c = input[n];
                if (c == escape)
                {
                    escaped = !escaped; // Escape character, toggle escaped flag
                    if (!escaped && input[n + 1] == escape)
                    {
                        /* Double escape character is used for putting escape character in cell value */
                        escaped = true; // Still escaping
                        val += $"{c}";
                        n++; // Skip character since we've parsed it in advance
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
                        /* Row end */
                        output.Update((row, col), val.Replace("\n", Environment.NewLine));
                        val = ""; row++; col = 0;
                    }
                    else val += $"{c}";
                }
                else val += $"{c}";
                n++;
            }

            return output;
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
            using (var reader = new StreamReader(File.OpenRead(fname), encoding, bom))
            {
                return FromString(reader.ReadToEnd(), delimiter, escape, newline);
            }
        }

        /*
         * public static async Task<Spreadsheet> FromFileAsync(string fname,
         *                                                     [char delimiter],
         *                                                     [char escape],
         *                                                     [string newline])
         *   Parse a CSV file asynchronously.
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
        public static async Task<Spreadsheet> FromFileAsync(string fname, Encoding encoding = null, bool bom = true, char delimiter = ',', char escape = '"', string newline = "")
        {
            encoding = encoding ?? Encoding.UTF8;
            using (var reader = new StreamReader(File.OpenRead(fname), encoding, bom))
            {
                return FromString(await reader.ReadToEndAsync(), delimiter, escape, newline);
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
            sheet_nl = sheet_nl ?? Environment.NewLine;
            bool nl_replace = (sheet_nl != newline); // Set if new line character replacement is needed
            string output = "";
            for(int row = 0; row < sheet.Rows; row++)
            {
                for(int col = 0; col < sheet.Columns; col++)
                {
                    string cell = "";
                    if (sheet.Data.ContainsKey((row, col)))
                    {
                        cell = sheet.Data[(row, col)];
                        if (nl_replace) cell = cell.Replace(sheet_nl, newline);
                        if (cell.Contains(escape) || cell.Contains(delimiter) || cell.Contains(newline))
                        {
                            cell = $"{escape}{cell.Replace($"{escape}", $"{escape}{escape}")}{escape}"; // Escape cell value
                        }
                    }
                    output += cell;
                    if (col != sheet.Columns - 1) output += $"{delimiter}";
                }
                output += newline;
            }
            return output;
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
            encoding = encoding ?? Encoding.UTF8;
            using (var writer = new StreamWriter(fname, false, encoding))
            {
                writer.Write(ToString(sheet, delimiter, escape, sheet_nl, newline));
            }
        }

        /*
         * public static async Task ToFileAsync(Spreadsheet sheet, string fname,
         *                                      [Encoding encoding], [char delimiter],
         *                                      [char escape], [string sheet_nl],
         *                                      [string newline])
         *   Writes the spreadsheet to a CSV file asynchronously.
         *   Input : same as ToFile().
         *   Output: none.
         */
        public static async Task ToFileAsync(Spreadsheet sheet, string fname, Encoding encoding = null, char delimiter = ',', char escape = '"', string sheet_nl = null, string newline = "\r\n")
        {
            encoding = encoding ?? Encoding.UTF8;
            using (var writer = new StreamWriter(fname, false, encoding))
            {
                await writer.WriteAsync(ToString(sheet, delimiter, escape, sheet_nl, newline));
            }
        }
    }
}
