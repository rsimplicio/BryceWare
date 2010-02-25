using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BryceWareEMR
{
    public partial class BryceWareEMRMain : Form
    {
        public BryceWareEMRMain(string[] args)
        {
            InitializeComponent();
            try
            {
                PatAcctBox.Text = args[0];
                Generator.Text = "Generating EMR Data...";
            }
            catch (IndexOutOfRangeException)
            {
                PatAcctBox.Text = "Unknown Patient";
                Generator.Text = "Unable to load EMR Data...";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
