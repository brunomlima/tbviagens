using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Globalization;
using Microsoft.Practices.EnterpriseLibrary.Data;

public class ShowListadeNoivos
{
    public ShowListadeNoivos() { }

    public static void ShowNoivos()
    {
        string strCss = "";

        DataTable dt = Noivo.Listar();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            Noivo nv = new Noivo();
            nv.Carregar( int.Parse(dt.Rows[i]["cd_noivo"].ToString()));
            string nome_arquivo = dt.Rows[i]["foto"].ToString();
            nome_arquivo = nome_arquivo.Replace(".png", "_p.png");
            strCss = strCss + "<p align='center' class='sidebar-title-noshade'>" + dt.Rows[i]["nome_noivos"].ToString() + "</p>";
            strCss = strCss + "<div align='center' class='sidebar-txtbox-noshade'>";
            strCss = strCss + "<a href='visualizanoivos.aspx?cd_noivo=" + dt.Rows[i]["cd_noivo"].ToString() + "'><img align='center' src='noivos\\" + dt.Rows[i]["cd_noivo"].ToString() + "\\" + nome_arquivo + "' width='130' height='70'/></a><br>";
            strCss = strCss + "Data do casamento: " + nv.DtCasamento.ToString("dd/MM/yyyy");
            strCss = strCss + "</div>";                      

        }

        if (dt.Rows.Count == 0) 
        {

            strCss = strCss + "<b> Seja o primeiro casal a ter uma lua de mel em cotas aqui na TBViagens </b></br></br></br>";
            strCss = strCss + "<a href='LuadeMel.aspx'> Clique aqui para saber mais ... </a> </br>";        
        }

        HttpContext.Current.Response.Write(strCss);
    }

    public static void ShowConvidados(string cdNoivos)
    {
        string strCss = "";

        DataTable dt = Convidado.ListarPorNoivo(cdNoivos);

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            string nome = dt.Rows[i]["nome"].ToString();
            string msg = dt.Rows[i]["mensagem"].ToString();
            strCss = strCss + "<b>" + nome + "</b> </br>" ;
            strCss = strCss + msg + "</br>" ;
            strCss = strCss + "<hr>";
        }

        if (dt.Rows.Count == 0)
        {
            strCss = strCss + "<b> Seja o primeiro convidado a presentear os noivos </b></br>";
        }
        HttpContext.Current.Response.Write(strCss);
    }

    public static string ShowApagaMensagem(string cdNoivos, string cdComentario)
    {
        string strCss = "";

        string Url = "http://www.tbviagens.com.br/ApagaComentario.aspx?cd_noivo=";

        strCss = strCss + Url;

        strCss = strCss + cdNoivos;

        strCss = strCss + "&cd_convidado=";

        strCss = strCss + cdComentario;

        return strCss;
    }

    public static string ShowListaNoivos(string cdNoivos)
    {
        string strCss = "";

        string Url = "http://www.tbviagens.com.br/VisualizaNoivos.aspx?cd_noivo=";

        strCss = strCss + Url;

        strCss = strCss + cdNoivos;

        return strCss;
            
    }
    

}