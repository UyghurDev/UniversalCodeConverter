using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CodeConverter
{
    public partial class Form1 : Form
    {
        private struct CodeTables
        {
            public string Path;
            public string Name;
            public string Author;
            public string Descraption;
        }
        string strFilesPath = Application.StartupPath + "\\CodeTables\\";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryInfo dir = new System.IO.DirectoryInfo(strFilesPath);
            FileInfo[] fis = dir.GetFiles("*.xml");
            List<CodeTables> li = new List<CodeTables>();
            foreach (FileInfo fi in fis)
            {
                net.uyghurdev.text.CodeConvert cc = new net.uyghurdev.text.CodeConvert(strFilesPath + "\\"+fi.Name);
                //CodeTables ct = new CodeTables();
                //ct.Name = cc.Name;
                //ct.Author = cc.Author;
                //ct.Descraption = cc.Descraption;
                //ct.Path = fi.Name;
                //li.Add(ct);
                //cmbTalbles.Items.Add(cc.Name);
                cmbTables.Items.Add(fi.Name);
            }
            //cmbTalbles.DataSource = li;
            //cmbTalbles.DisplayMember = "Name";
            //cmbTalbles.ValueMember = "Path";
            if (cmbTables.Items.Contains("UEY2UYY.xml")) { /*cmbTables.SelectedText = "UEY2UYY.xml";*/ cmbTables.SelectedIndex = 12; }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (cmbTables.SelectedItem == null)
            {
                MessageBox.Show("Select a code table!");
                return;
            }
            net.uyghurdev.text.CodeConvert cc = new net.uyghurdev.text.CodeConvert(strFilesPath+cmbTables.SelectedItem);
            txtNew.Text = cc.ToConvert(txtSource.Text);

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            frmChar frm = new frmChar();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSource.Text = "";
            txtNew.Text = "";
        }

        private void txtSource_MouseEnter(object sender, EventArgs e)
        {
            txtSource.SelectAll();
        }

        private void txtNew_MouseEnter(object sender, EventArgs e)
        {
            txtNew.SelectAll();
        }

        private void txtNew_MouseMove(object sender, MouseEventArgs e)
        {
            txtNew.SelectAll();
        }

        private void txtSource_MouseMove(object sender, MouseEventArgs e)
        {
            txtSource.SelectAll();
        }
    }
}
