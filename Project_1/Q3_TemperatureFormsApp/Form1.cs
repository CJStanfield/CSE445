using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string inputTemp1;
        string inputTemp2;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCToF_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Int32.Parse(this.inputTemp1);
                TempService.Service1Client temperature = new TempService.Service1Client();
                string newTemp = temperature.c2f(x).ToString();
                outputTempF.Text = newTemp;

            }catch (Exception ex) { Console.WriteLine(ex); }
        }
        private void buttonFToC_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Int32.Parse(this.inputTemp2);
                TempService.Service1Client temperature = new TempService.Service1Client();
                string newTemp = temperature.f2c(x).ToString();
                outputTempC.Text = newTemp;

            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void CelsiusInput_TextChanged(object sender, EventArgs e)
        {
            this.inputTemp1 = CelsiusInput.Text;
        }

        private void FahrenheitInput_TextChanged(object sender, EventArgs e)
        {
            this.inputTemp2 = FahrenheitInput.Text;
        }

        
    }
}
