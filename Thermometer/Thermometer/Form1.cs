using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thermometer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeTemp(object sender, ScrollEventArgs e)
        {
            vScrollBar1.Value = vScrollBar1.Maximum - vScrollBar1.Value;
            label4.Text = vScrollBar1.Value.ToString();
            double ftemp = Convert.ToDouble(label4.Text);
            double Ctemp = (ftemp - 32.0) * (5.0 / 9.0);
            label3.Text = Convert.ToString(Convert.ToInt32(Ctemp));          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
