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

public partial class private_Show : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataView dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
        int cnt = dv.Table.Rows.Count;
        
        if (cnt == 0)
        {
            TextBox1.Text = "No comments";
        }
        else
        {
            DataRow row = dv.Table.Rows[0];
            string s = (string)row["comments"];
            TextBox1.Text = s;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataView dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
        int cnt = dv.Table.Rows.Count;
        
        if (cnt==0)
        {
            TextBox1.Text = "No comments";
        }
        else
        {
            int i = Int32.Parse(HiddenField1.Value);
            if (i >= cnt)
            {
                TextBox1.Text = "No more comments";
            }
            else
            {
                DataRow row = dv.Table.Rows[i];
                string s = (string)row["comments"];
                TextBox1.Text = s;
                i++;
                HiddenField1.Value = i.ToString();
            }
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlDataSource1.Delete();
        TextBox1.Text = "No comments";
        int i = 1;
        HiddenField1.Value = i.ToString();
    }

    protected void HiddenField1_ValueChanged(object sender, EventArgs e)
    {

    }
}