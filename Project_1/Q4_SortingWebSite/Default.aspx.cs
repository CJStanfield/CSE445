using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Method handles button click to sort the numbers. Uses the service from question 2
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        SortService.Service1Client myClient = new SortService.Service1Client();
        try
        {
            lblSorted.Text = myClient.sort(txtInput.Text);
        }catch(Exception ex) { lblSorted.Text = ex.Message.ToString(); }

    }

    //This method is used  to update the operator on the screen. Changes the label text to the appropriate operator
    protected void updateOperator_Add(object sender, EventArgs e)
    {
        try
        {
            LabelOperator.Text = "+";
        }
        catch (Exception ex) { LabelOperator.Text = ex.Message.ToString(); }

    }

    //This method is used  to update the operator on the screen. Changes the label text to the appropriate operator
    protected void updateOperator_Subtract(object sender, EventArgs e)
    {
        try
        {
            LabelOperator.Text = "-";
        }
        catch (Exception ex) { LabelOperator.Text = ex.Message.ToString(); }

    }

    //This method is used  to update the operator on the screen. Changes the label text to the appropriate operator
    protected void updateOperator_Multiply(object sender, EventArgs e)
    {
        try
        {
            LabelOperator.Text = "*";
        }
        catch (Exception ex) { LabelOperator.Text = ex.Message.ToString(); }

    }

    //This method is used  to update the operator on the screen. Changes the label text to the appropriate operator
    protected void updateOperator_Divide(object sender, EventArgs e)
    {
        try
        {
            LabelOperator.Text = "/";
        }
        catch (Exception ex) { LabelOperator.Text = ex.Message.ToString(); }

    }

    //Completes the calculations and updates the labels with the result accordingly. 
    //NOTE: this was not required for question 4 but wanted to learn more about xml and ASP.net
    protected void Calculator_Result(object sender, EventArgs e)
    {
        try
        {
            double x = Convert.ToDouble(InputNum1.Text);
            double y = Convert.ToDouble(InputNum2.Text);
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
    //Implemented the search ticker function to get the price of stocks using an ASU service
    //NOTE: this was not required for question 4 but wanted to learn more about xml and ASP.net
    protected void Search_Ticker(object sender, EventArgs e)
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