using System;
using System.Data;
using System.Configuration;
    using System.Linq;
    using System.Web;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.UI.HtmlControls;
    using System.Web.UI.WebControls;
    using System.Web.UI.WebControls.WebParts;
    using System.Xml.Linq;

    public class MostraCodigo
    {
	    public MostraCodigo()
	    {
	    }
      
        public static string ConverteString(string str)
        {
            Byte[] myBytes13 = { 13 };
            string myStr13 = System.Text.Encoding.ASCII.GetString(myBytes13);

            Byte[] myBytesSpace = { 32 };
            string myStrSpace = System.Text.Encoding.ASCII.GetString(myBytesSpace);

            string linha = str.ToString().Replace(myStr13, "#");
            string[] xx = linha.Split('#');
                    
            for (int i = 0; i < xx.Length; i++)
            {
                xx[i] = xx[i].ToString().Replace(myStrSpace, "&nbsp;");
                
            }
            string linhaNova = String.Join("<br />", xx);
            return linhaNova;
        }
    }
