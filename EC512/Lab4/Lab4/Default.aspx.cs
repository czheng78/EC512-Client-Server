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

    protected String swapc(String s, int start, int end)
    {
        char tmp;
        char[] str_array = s.ToCharArray();
        tmp = str_array[start];
        str_array[start] = str_array[end];
        str_array[end] = tmp;
        string a = new string(str_array);
        return a;
    }

    protected void anagrams(String s, int start, int end, int myInt)
    {
        if (start == end)
        {
            
            outputList.Items.Add(s);
            string myres = outputList.Items.Count.ToString();
            comment.Text = myres + " anagrams found.";
        }
        else
        {
            for (int i=start; i <= end; ++i)
            {
                s = swapc(s, start, i);
                myInt = myInt + 1;
                anagrams(s, start+1, end, myInt);
                s = swapc(s, start, i);
            }
        }
    }

    protected bool swap2(String s, int start, int c)
    {
        for (int i = start; i < c; i++)
            if (s[i] == s[c])
                return false;
        return true;
    }

    protected void anagrams_rd(String s, int start, int end, int myInt)
    {
        if (start >= s.Length)
        {
            outputList.Items.Add(s);
            string res = outputList.Items.Count.ToString();
            comment.Text = res + " anagrams found.";
        }
        for (int i=start; i < end; ++i)
        {
            bool che = swap2(s, start, i);
            if (che)
            {
                s = swapc(s, start, i);
                myInt = myInt + 1;
                anagrams_rd(s, start + 1, end, myInt);
                s = swapc(s, start, i);
            }
        }
    }


    protected void find_ana(object sender, EventArgs e)
    {
        int len = inputString.Text.Length;
        if (inputString.Text == string.Empty || len > 8)
        {
            outputList.Items.Clear();
            comment.Text = "Please enter a string from 1 to 8 characters";
            inputString.Text = string.Empty;
        }
        else
        {
            outputList.Items.Clear();
            int res = 0;
            if (!dupd.Checked)
            {
                anagrams(inputString.Text, 0, len - 1, res);
                inputString.Text = string.Empty;
            }
            else if (dupd.Checked)
            {
                anagrams_rd(inputString.Text, 0, len, res);
                inputString.Text = string.Empty;
            }
            
        }
    }

}