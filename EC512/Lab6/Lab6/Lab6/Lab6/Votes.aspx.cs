using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Votes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataView dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);

        TableRow heading = new TableRow();
        TableCell Cand = new TableCell();
        TableCell V = new TableCell();
        TableCell Perc = new TableCell();
        heading.Cells.Add(Cand);
        heading.Cells.Add(V);
        heading.Cells.Add(Perc);
        Cand.BorderWidth = 1;
        Cand.BorderColor = Color.Black;
        Cand.Width = 100;
        Cand.Text = "Candidate";
        V.BorderWidth = 1;
        V.BorderColor = Color.Black;
        V.Width = 100;
        V.Text = "Votes";
        Perc.BorderWidth = 1;
        Perc.BorderColor = Color.Black;
        Perc.Width = 100;
        Perc.Text = "Percentage (%)";
        Table1.Rows.Add(heading);

        long tmp = 0;
        double per = 0.0;
        double cnt = 0.0;
        
        foreach (DataRow dr in dv.Table.Rows)
        {
            tmp = (int)dr["Votes"];
            cnt += tmp;
        }

        foreach (DataRow dr in dv.Table.Rows)
        {
            TableRow r = new TableRow();
       
            TableCell c1 = new TableCell();
            TableCell c2 = new TableCell();
            TableCell c3 = new TableCell();


            r.Cells.Add(c1);
            r.Cells.Add(c2);
            r.Cells.Add(c3);
            c1.BorderWidth = 1;
            c1.BorderColor = Color.Black;
            c1.Width = 100;
            c2.BorderWidth = 1;
            c2.BorderColor = Color.Black;
            c2.Width = 100;
            c3.BorderWidth = 1;
            c3.BorderColor = Color.Black;
            c3.Width = 100;

            c1.Text = dr["Names"].ToString();
            c2.Text = dr["Votes"].ToString();
            tmp = (int)dr["Votes"];
            per = (tmp / cnt) * 100;
            per = Math.Round(per, 2);
            c3.Text = per.ToString();

            Table1.Rows.Add(r);
        }
    }
}