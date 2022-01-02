/*
 * Spreadsheet.cs - Class for storing spreadsheets.
 * Created on: 20:35 01-01-2022
 * Author    : itsmevjnk
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace HRngBackend
{
    public class Spreadsheet
    {
        /*
         * public IDictionary<(int row, int col), string> Data
         *   A dictionary of cells stored as strings. The key
         *   is a row-column index tuple starting from 0.
         */
        public IDictionary<(int row, int col), string> Data = new Dictionary<(int row, int col), string>();

        /*
         * public int Rows
         *   The number of rows in this spreadsheet.
         *   The spreadsheet is growing only; this means that
         *   the number of rows and columns will always be
         *   increasing and will never decrease.
         */
        public int Rows = 0;

        /*
         * public int Columns
         *   The number of columns in this spreadsheet.
         */
        public int Columns = 0;

        /*
         * public (int row, int col) Index(string addr)
         *   Convert an Excel-type cell address (e.g. B3)
         *   to a row-column index tuple (e.g. (2, 1)).
         *   If the row or column is not specified in the
         *   address, the respective value in the tuple
         *   will be set to -1.
         *   Input : addr: The Excel-type cell address
         *                 string to be converted.
         *   Output: A tuple of row-column indexes.
         */
        public (int row, int col) Index(string addr)
        {
            addr = addr.ToUpper(); // Normalize address to uppercase
            int row = 0, col = -1; // Return values
            bool p_row = false; // Set when parsing row number
            foreach(char c in addr)
            {
                if (c >= '0' && c <= '9')
                {
                    /* Row */
                    if (!p_row) p_row = true;
                    row = row * 10 + c - '0';
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    /* Column */
                    if (p_row) throw new Exception($"Column letter {c} appears in row number");
                    if (col == -1) col = 0;
                    col = col * 26 + c - 'A';
                }
                else throw new Exception($"Invalid character {c}");
            }
            return (row - 1, col);
        }

        /*
         * public string Address((int row, int col) tup)
         *   Convert a row-column index tuple (e.g. (2, 1)) to
         *   an Excel-type cell address (e.g. B3). If the row
         *   or column field is set to -1, the respective
         *   coordinate won't appear in the returning address.
         *   Input : tup: The row-column index tuple to be
         *                converted.
         *   Output: An Excel-type cell address.
         */
        public string Address((int row, int col) tup)
        {
            string addr = "";
            if (tup.col != -1)
            {
                while (tup.col > 0)
                {
                    addr += $"{(char)((tup.col % 26) + 'A')}";
                    tup.col /= 26;
                }
            }
            if (tup.row != -1) addr += Convert.ToString(tup.row + 1);
            return addr;
        }

        /*
         * public void Update((int row, int col) idx, string val)
         *   Add or update a cell's value. If the given cell
         *   value is empty, the cell will be removed (if it
         *   exists) or not be added.
         *   Input : idx: The row-column index tuple pointing
         *                to the cell.
         *           val: The cell's value.
         *   Output: none.
         */
        public void Update((int row, int col) idx, string val)
        {
            bool add = true; // Set only when a new cell is being added
            if (Data.ContainsKey(idx))
            {
                add = false;
                Data.Remove(idx);
            }
            if (val != "") Data.Add(idx, val);
            if (add)
            {
                /* Cell added, check if we have to update rows/columns count */
                if (Rows < idx.row + 1) Rows = idx.row + 1;
                if (Columns < idx.col + 1) Columns = idx.col + 1;
            }
        }
    }
}
