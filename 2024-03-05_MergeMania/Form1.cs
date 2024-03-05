using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_03_05_MergeMania
{
    public partial class Form1 : Form
    {
        int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i += 1;
            label1.Text = i.ToString();
            label1.ForeColor = Color.FromArgb((int)(i*.255), (int)(i *.055), (int)(i *.255));
            if (i >= 1000)
                timer1.Enabled = false;
        }
    }
}
