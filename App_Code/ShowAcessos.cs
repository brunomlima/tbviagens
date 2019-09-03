using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;


public class ShowAcessos
{
	public ShowAcessos(){}

    public static void ShowAcesso(string cpf)
    {
        string strCss = "";
        DataTable dt = LoginSite.Listar(cpf);
        for (int i = 0; i < dt.Rows.Count; i++)
        {

            strCss = strCss + "<li><a href='" + dt.Rows[i]["pagina"].ToString() + "'>" + dt.Rows[i]["nome_modulo"].ToString() + "</a></li>";

        }
        HttpContext.Current.Response.Write(strCss);
    }
}