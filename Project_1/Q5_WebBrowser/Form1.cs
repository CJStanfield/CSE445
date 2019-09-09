using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtUrl.Text);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                LabelOperator.Text = "+";
            }
            catch (Exception ex) { LabelOperator.Text = ex.Message.ToString(); }
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            try
            {
                LabelOperator.Text = "-";
            }
            catch (Exception ex) { LabelOperator.Text = ex.Message.ToString(); }
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            try
            {
                LabelOperator.Text = "*";
            }
            catch (Exception ex) { LabelOperator.Text = ex.Message.ToString(); }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            try
            {
                LabelOperator.Text = "/";
            }
            catch (Exception ex) { LabelOperator.Text = ex.Message.ToString(); }

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(InputCalc1.Text);
                double y = Convert.ToDouble(InputCalc2.Text);
                string result;
                switch (LabelOperator.Text)
                {
                    case "+": result = (x + y).ToString(); break;
                    case "-": result = (x - y).ToString(); break;
                    case "*": result = (x * y).ToString(); break;
                    case "/": result = (x / y).ToString(); break;
                    default: result = "No Operator Selected"; break;
                }
                LabelResult.Text = result;

            }
            catch (Exception ex) { LabelOperator.Text = ex.Message.ToString(); }
        }

        private void buttonGetPrice_Click(object sender, EventArgs e)
        {
            try
            {
                SearchTickerSymbol.ServiceClient search = new SearchTickerSymbol.ServiceClient();
                string ticker = InputTickerSymbol.Text;
                LabelStockPrice.Text = search.getStockquote(ticker);

            }
            catch (Exception ex) { LabelStockPrice.Text = ex.Message.ToString(); }
        }
    }
}
