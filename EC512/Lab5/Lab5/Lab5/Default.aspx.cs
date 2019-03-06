using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public bool isDecimal(string value)
    {
        try
        {
            Decimal.Parse(value);
            return true;
        }
        catch
        {
            return false;
        }
    }


    protected void tousd_Click(object sender, EventArgs e)
    {
        if (inputString.Text == string.Empty || !isDecimal(inputString.Text))
        {
            output.Text = string.Empty;
            error.Text = "Please enter correct values!!!";
            inputString.Text = string.Empty;
            currencyList.ClearSelection();
        }
        else if (currencyList.SelectedItem == null)
        {
            output.Text = string.Empty;
            error.Text = "Please select a currency!!!";
        }
        else
        {
            String inVal = inputString.Text;
            var decVal = Convert.ToDecimal(inVal);
            error.Text = string.Empty;
            if (currencyList.SelectedItem != null)
            {
                var decCur = Convert.ToDecimal(currencyList.SelectedValue);
                Decimal num = decVal / decCur;
                num = Math.Round(num, 2);
                String outVal = Convert.ToString(num);
                output.Text = "$ " + outVal;
                currencyList.ClearSelection();
            }

        }
    }

    protected void fromusd_Click(object sender, EventArgs e)
    {
        if (inputString.Text == string.Empty || !isDecimal(inputString.Text))
        {
            output.Text = string.Empty;
            error.Text = "Please enter correct values!!!";
            inputString.Text = string.Empty;
            currencyList.ClearSelection();
        }
        else if (currencyList.SelectedItem == null)
        {
            output.Text = string.Empty;
            error.Text = "Please select a currency!!!";
        }
        else
        {
            String inVal = inputString.Text;
            var decVal = Convert.ToDecimal(inVal);
            error.Text = string.Empty;
            if (currencyList.SelectedItem != null)
            {
                var decCur = Convert.ToDecimal(currencyList.SelectedValue);
                Decimal num = decVal * decCur;
                num = Math.Round(num, 2);
                String outVal = Convert.ToString(num);
                
                if (currencyList.SelectedValue == "0.8799")
                {
                    output.Text = outVal + " Euro";
                } else if (currencyList.SelectedValue == "72.5304")
                {
                    output.Text = outVal + " Indian Rupee";
                } else if (currencyList.SelectedValue == "0.7655")
                {
                    output.Text = outVal + " British Pound";
                } else if (currencyList.SelectedValue == "1.0061")
                {
                    output.Text = outVal + " Swiss Franc";
                } else if (currencyList.SelectedValue == "114.0150")
                {
                    output.Text = outVal + " Japanese Yen";
                }
                currencyList.ClearSelection();
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        inputString.Text = string.Empty;
    }
}