using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TAR4_FORMS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddForm frm = new AddForm();
            frm.ShowDialog();
        }

               
            private void viewSystemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewForm frm = new ViewForm();
            frm.MdiParent = this;
            frm.Show();
        }
    }
    
}
