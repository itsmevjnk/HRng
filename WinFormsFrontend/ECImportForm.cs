using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsFrontend
{
    public partial class ECImportForm : Form
    {
        public ECImportForm()
        {
            InitializeComponent();
        }

        private void rbtECUIDColName_CheckedChanged(object sender, EventArgs e)
        {
            tbxECUIDCol.Enabled = rbtECUIDColName.Checked;
        }

        private void rbtECUIDColNum_CheckedChanged(object sender, EventArgs e)
        {
            numECUIDCol.Enabled = rbtECUIDColNum.Checked;
        }

        private void rbtECUIDDelimCustom_CheckedChanged(object sender, EventArgs e)
        {
            tbxECUIDDelim.Enabled = rbtECUIDDelimCustom.Checked;
            if (!rbtECUIDDelimCustom.Checked) btnECOK.Enabled = true;
            else btnECOK.Enabled = (tbxECUIDDelim.Text.Length != 0);
        }

        private void tbxECUIDDelim_TextChanged(object sender, EventArgs e)
        {
            btnECOK.Enabled = (tbxECUIDDelim.Text.Length != 0);
        }
    }
}
