using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

public partial class NomeEmail : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string n = "";
        string em = "";
        string res = "";
        String[] s = TextBox1.Text.Split('\n');
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == "Nome\r") { n = s[i+1]; }
            if (s[i] == "Email\r") {em = s[i+1]; }

            if (em != "")
            {
                em = em.Replace("\r", "");
            }
            if (n != "")
            {
                n = n.Replace("\r", "");
            }
            if (isValidEmail(em)) 
            { 
                res = n + ";" + em; 

            }


            if (n != "" && em != "" && isValidEmail(em))
            {
                TextBox2.Text += res + "\n" ; 
                res = "";
                em = "";
                n = "";
            };

        }//for
        TextBox1.Text = "";
            
    }

    public static bool isValidEmail(string inputEmail)
    {
        string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
              @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
              @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        Regex re = new Regex(strRegex);
        if (re.IsMatch(inputEmail))
            return (true);
        else
            return (false);
    }

}