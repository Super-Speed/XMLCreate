using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLCreate
{
    public partial class XMLOptionSet : Form
    {
        public XMLOptionSet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want use to these settings?", "Settings", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("OK!", "OK");
                Form1 frm = new Form1();
                frm.ShowDialog();
            }
        }
    }
}
