using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class private_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FormsAuthentication.Authenticate(user.Text, pass.Text))
        {
            FormsAuthentication.RedirectFromLoginPage(user.Text,true);
            Response.Redirect("./private/Show.aspx");
            msg.Text = "";
        }
        else
        {
            msg.Text = "Login failed. Please check your user name and password and try again.";
            user.Text = "";
        }
    }
}