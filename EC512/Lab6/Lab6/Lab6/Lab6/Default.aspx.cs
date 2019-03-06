using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ERRORmsg.Text = "";
     
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedItem == null)
        {
            ERRORmsg.Text = "Please Select a Candidate!";
        }
        else
        {
            ERRORmsg.Text = "";
            int cnt = 0;
            DataView dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
            if (dv == null)
            {
                //handle error
            }
            DataRow row = dv.Table.Rows[RadioButtonList1.SelectedIndex];
            cnt = (int)row["Votes"];
            cnt++;
            HiddenField1.Value = cnt.ToString();
            SqlDataSource1.Update();

            string url = "Votes.aspx";
            Response.Redirect(url);
            RadioButtonList1.ClearSelection();
        }
    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }

}