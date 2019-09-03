using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;

public class ShowFerramentas
{
	public ShowFerramentas(){}

    public static void ShowFerramenta(string t)
    {
        string strCss = "";
        int Contador = 0;
    
        DataTable dt = Ferramentas.ListarTipo(t);

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            Contador++;
            strCss = strCss + "<a href='" + dt.Rows[i]["url"].ToString() + "' ";
            strCss = strCss + "class='enlaceherr' target='_blank'>";
            strCss = strCss + Contador.ToString()+") " + dt.Rows[i]["descricao"].ToString() + "</a> <br />";
        }
 
        HttpContext.Current.Response.Write(strCss);
    }

}