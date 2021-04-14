using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                Width = 640;
                Height = 480;
            }
            else if (radioButton2.Checked == true)
            {
                Width = 800;
                Height = 600;
            }
            else if (radioButton3.Checked == true)
            {
                Width = 1024;
                Height = 768;
            }
        }
    }
}
