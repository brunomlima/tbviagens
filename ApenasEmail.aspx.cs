using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ApenasEmail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String[] s = TextBox1.Text.Split('\n');
        
        for (int i = 0; i < s.Length; i++)
        {
            TextBox2.Text += Troca(s[i]);
        }//for
        TextBox1.Text = "";
    }
    public static string Troca(string strOriginal)
    {
        string strResultado = "";

        if (strOriginal.Contains("@")) 
        { 
            //strResultado = strOriginal + " --> " + conta_char(strOriginal, '@').ToString() + '\n';
            //Loop para extrair a quantidade de e-mails por linha.
            for (int i = 0; i < conta_char(strOriginal, '@'); i++)
            {
                strResultado = GetEMailAddresses(strOriginal) + '\n';
            }
        };

        return strResultado;
    }

    public static int conta_char(string str, char c)
    {

        int i = 0, contador = 0;

        for ( i = 0; i < str.Length; i++)
        {
            if (str[i] == c)
            {
                contador++;
            }
        }
        
       return contador;
    }

    public static String GetEMailAddresses(string Input)
    {
        System.Text.RegularExpressions.MatchCollection MC = System.Text.RegularExpressions.Regex.Matches(Input, "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");

        if (MC.Count > 0)
            return MC[0].Value;

        return "";
    }
}