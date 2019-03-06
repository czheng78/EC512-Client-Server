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

    public Boolean IsNumber(String value)
    {
        Double j = 0;
        if (Double.TryParse(value, out j))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    protected void Enter_Click(object sender, EventArgs e)
    {
        if (input.Text == string.Empty || IsNumber(input.Text)!=true)
        {
            error.Text = "Invalid or missing value!";
        }
        else
        {
            double val = Convert.ToDouble(input.Text);
            input.Text = string.Empty;

            try
            {
                result.Text = val.ToString();
                error.Text = string.Empty;
            }
            catch
            {
                error.Text = "Invalid or missing value!";
            }
        }
    }
    
    protected void Add_Click(object sender, EventArgs e)
    {
        if (input.Text == string.Empty || IsNumber(input.Text)!=true || result.Text == string.Empty)
        {
            error.Text = "Invalid or missing values!";
        }
        else
        {
            double val = Convert.ToDouble(input.Text);
            double res = Convert.ToDouble(result.Text);
            input.Text = string.Empty;

            try
            {
                result.Text = (res + val).ToString();
                error.Text = string.Empty;
            }
            catch
            {
                error.Text = "Invalid or missing values!";
            }
        }
    }

    protected void Sub_Click(object sender, EventArgs e)
    {
        if (input.Text == string.Empty || IsNumber(input.Text) != true || result.Text == string.Empty)
        {
            error.Text = "Invalid or missing values!";
        }
        else
        {
            double val = Convert.ToDouble(input.Text);
            double res = Convert.ToDouble(result.Text);
            input.Text = string.Empty;

            try
            {
                result.Text = (res - val).ToString();
                error.Text = string.Empty;
            }
            catch
            {
                error.Text = "Invalid or missing values!";
            }
        }
    }

    protected void Mul_Click(object sender, EventArgs e)
    {
        if (input.Text == string.Empty || IsNumber(input.Text) != true || result.Text == string.Empty)
        {
            error.Text = "Invalid or missing values!";
        }
        else
        {
            double val = Convert.ToDouble(input.Text);
            double res = Convert.ToDouble(result.Text);
            input.Text = string.Empty;

            try
            {
                result.Text = (res * val).ToString();
                error.Text = string.Empty;
            }
            catch
            {
                error.Text = "Invalid or missing values!";
            }
        }
    }

    protected void Div_Click(object sender, EventArgs e)
    {
        if (input.Text == string.Empty || IsNumber(input.Text) != true || result.Text == string.Empty)
        {
            error.Text = "Invalid or missing values!";
        }
        else
        {
            double val = Convert.ToDouble(input.Text);
            double res = Convert.ToDouble(result.Text);
            input.Text = string.Empty;

            try
            {
                result.Text = (res / val).ToString();
                error.Text = string.Empty;
            }
            catch
            {
                error.Text = "Invalid or missing values!";
            }
        }
    }

}