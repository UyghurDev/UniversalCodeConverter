using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodeConverter
{
    public partial class frmChar : Form
    {
        public frmChar()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            txtChar.Text = Convert.ToChar(Convert.ToInt32(txtCode.Text,16)).ToString();
            Clipboard.SetText(txtChar.Text.Trim());
        }
    }
}
