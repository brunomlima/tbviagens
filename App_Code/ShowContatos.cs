using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;

public class ShowContatos
{
	public ShowContatos()
	{
    
	}
    public static void ShowContato()
    {
        string strCss = "";
        
        DataTable dt = Usuario.ListarContatos();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            strCss = strCss + "<br><b>" + dt.Rows[i]["nome"].ToString() + "</b> ";
            strCss = strCss + "<br>" + dt.Rows[i]["cargo"].ToString();
            strCss = strCss + "<br><a href='mailto: " + dt.Rows[i]["email"].ToString() + "'>" + dt.Rows[i]["email"].ToString() + "</a>";

            strCss = strCss + "<div id='SkypeButton_Chat_"+ dt.Rows[i]["skype"].ToString() + "'> ";
            strCss = strCss + "    <script type='text/javascript'> ";
            strCss = strCss + "      Skype.ui({ ";
            strCss = strCss + "        'name': 'chat', ";
            strCss = strCss + "        'element': 'SkypeButton_Chat_" + dt.Rows[i]["skype"].ToString() + "', ";
            strCss = strCss + "        'participants': ['" + dt.Rows[i]["skype"].ToString() + "'], ";
            strCss = strCss + "        'imageSize': 16 ";
            strCss = strCss + "         }); ";
            strCss = strCss + "  </script> ";
            strCss = strCss + "</div> ";



        }

        HttpContext.Current.Response.Write(strCss);
    }
}