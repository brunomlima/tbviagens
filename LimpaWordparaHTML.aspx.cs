using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LimpaWordparaHTML : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String[] s = TextBox1.Text.Split('\n');
        for (int i = 0; i < s.Length; i++)
        {
          TextBox2.Text += Troca(s[i],500);             
        }//for
        TextBox1.Text = "";
    }

    public static string Troca(string strOriginal, int iVezes)
    {
        string strResultado = "";
        for (int i = 0; i < iVezes; i++)
        {
            string strLimpa = getBetween(strOriginal, "<", ">");
            if (strLimpa.ToString() != "")
            {
               strOriginal = strOriginal.Replace(strLimpa, "");
            }
            strResultado = strOriginal;          
        }
        return strResultado;
    }

    public static string getBetween(string strSource, string strStart, string strEnd)
    {
        int Start, End;
        if (strSource.Contains(strStart) && strSource.Contains(strEnd))
        {
            Start = strSource.IndexOf(strStart, 0) + strStart.Length;
            End = strSource.IndexOf(strEnd, Start);
            return strSource.Substring(Start -1 , End - Start +2);
        }
        else
        {
            return "";
        }
    }
   
}