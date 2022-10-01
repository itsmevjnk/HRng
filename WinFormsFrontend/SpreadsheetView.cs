using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HRngBackend;

namespace WinFormsFrontend
{
    public partial class SpreadsheetView : Form
    {
        public SpreadsheetView(Spreadsheet sheet)
        {
            InitializeComponent();
            dgvSheet.ColumnCount = sheet.Columns;
            for (int i = 0; i < sheet.Columns; i++) dgvSheet.Columns[i].Name = (sheet.Data.ContainsKey((0, i))) ? sheet.Data[(0, i)] : "";
            for (int i = 1; i < sheet.Rows; i++)
            {
                var row = new List<string>();
                for (int j = 0; j < sheet.Columns; j++) row.Add((sheet.Data.ContainsKey((i, j))) ? sheet.Data[(i, j)] : "");
                dgvSheet.Rows.Add(row.ToArray());
            }
        }
    }
}
