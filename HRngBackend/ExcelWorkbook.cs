/*
 * ExcelWorkbook.cs - Functions for reading from Excel workbooks using ExcelDataReader
 *                    (supports both BIFF-based XLS and XML/ZIP-based XLSX).
 * Created on: 10:25 25-01-2022
 * Author    : itsmevjnk
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Data;

using ExcelDataReader;

namespace HRngBackend
{
    public static class ExcelWorkbook
    {
        /*
         * public static List<KeyValuePair<string, Spreadsheet>> FromStream(Stream input, [string password],
         *                                                                  [Encoding encoding], [bool open])
         *   Parse a stream of XLS (BIFF2-8) or XLSX/XLSB (OpenXml) data.
         *   Input : input   : The XLS/XLSX data stream to be parsed.
         *           password: The workbook's password (optional).
         *           encoding: The fallback encoding to be used if it can't
         *                     be determined (optional). Defaults to CP1252.
         *           open    : Whether to leave the stream open after parsing.
         *                     Set to true by default (so the stream can be
         *                     manually closed by caller).
         *   Output: A list of key-value pairs with the sheet's name as the
         *           key and its corresponding Spreadsheet object as the
         *           value.
         */
        public static List<KeyValuePair<string, Spreadsheet>> FromStream(Stream input, string? password = null, Encoding? encoding = null, bool open = true)
        {
            Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance); // For CP1252 on .NET Core

            /* Set reader configuration */
            var config = new ExcelReaderConfiguration();
            if (encoding != null) config.FallbackEncoding = encoding;
            if (password != null) config.Password = password;
            config.LeaveOpen = open;

            var sheets = new List<KeyValuePair<string, Spreadsheet>>(); // List of sheets to return
            using (var reader = ExcelReaderFactory.CreateReader(input, config))
            {
                using (var dataset = reader.AsDataSet(new ExcelDataSetConfiguration()
                {
                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                    {
                        UseHeaderRow = false
                    }
                }))
                {
                    foreach (DataTable dt in dataset.Tables)
                    {
                        var sheet = new Spreadsheet();
                        for (int row = 0; row < dt.Rows.Count; row++)
                        {
                            for (int col = 0; col < dt.Columns.Count; col++)
                            {
                                sheet.Update((row, col), dt.Rows[row][col].ToString().Replace("\n", Environment.NewLine)); // TODO: Verify that the new line conversion is correct in all cases
                            }
                        }
                        sheets.Add(new KeyValuePair<string, Spreadsheet>(dt.TableName, sheet));
                    }
                }
            }
            return sheets;
        }

        /*
         * public static List<KeyValuePair<string, Spreadsheet>> FromFile(string fname, [string password],
         *                                                               [Encoding encoding])
         *   Parse an Excel workbook.
         *   Input : fname: The path to the Excel workbook to be parsed.
         *           The other two arguments are the same as in FromStream().
         *   Output: same as FromStream().
         */
        public static List<KeyValuePair<string, Spreadsheet>> FromFile(string fname, string? password = null, Encoding? encoding = null)
        {
            using (var file = File.Open(fname, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                return FromStream(file, password, encoding);
            }
        }
    }
}
