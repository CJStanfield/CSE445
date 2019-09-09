using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TempService.Service1Client temperature = new TempService.Service1Client();
            double piValue = temperature.PiValue();
            int temp = temperature.c2f(5);
            PiValueTextBox.Text = temp.ToString();
        }

        private void PiValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
