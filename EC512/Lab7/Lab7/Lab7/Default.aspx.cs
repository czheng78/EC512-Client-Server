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

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text != "")
        {
            SqlDataSource1.Insert();
            TextBox1.Text = "Thank you for your comment.";
        }
        else
        {
            TextBox1.Text = "Please enter a comment.";
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (HttpContext.Current.User.Identity.IsAuthenticated)
        {
            Response.Redirect("./private/Show.aspx");
        }
        else
        {
            Response.Redirect("login.aspx");
        }
            
    }
}