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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            XMLOptionSet popup = new XMLOptionSet();
            if (popup.amount.SelectedText == "1")
            {
                this.optid1.Visible = true;
                this.choid1.Visible = true;
                this.patid1.Visible = true;
                this.sectid1.Visible = true;
            }
            else if (popup.amount.SelectedText == "")
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
