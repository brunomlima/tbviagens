using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;

public class ShowPacote
{
	public ShowPacote(){}



    public static void ShowPacotes(string stipo, int icodigo)
    {
        /*PACOTE NACIONAL*/    
        string strCss = "";
        if (stipo == "N") {

        DataTable dt = Pacote.ListarPorTipo(stipo);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
             string Nome_arquivo = dt.Rows[i]["caminhoimagem"].ToString();
             Nome_arquivo = Nome_arquivo.Replace(".png", "_p.png");

             /*strCss = strCss + "<span itemscope itemtype='http://schema.org/Product'>";
             strCss = strCss + "<p itemprop='name' class='sidebar-title-noshade'>" + dt.Rows[i]["titulo"].ToString() + "</p>";
			 strCss = strCss + "<div itemprop='price' class='sidebar-txtbox-noshade'>";
             strCss = strCss + "<a itemprop='url' href='VisualizaPacote.aspx?cd_pacote=" + dt.Rows[i]["cd_pacote"].ToString() + "'><img itemprop='image' src='PACOTE\\" + dt.Rows[i]["cd_pacote"].ToString() + "\\" + Nome_arquivo + "' width='130' height='70'/></a><br>";
             strCss = strCss + dt.Rows[i]["resumo"].ToString();
             strCss = strCss + "</div></span>";*/

             strCss = strCss + "<p class='sidebar-title-noshade'>" + dt.Rows[i]["titulo"].ToString() + "</p>";
             strCss = strCss + "<div class='sidebar-txtbox-noshade'>";
             strCss = strCss + "<a href='VisualizaPacote.aspx?cd_pacote=" + dt.Rows[i]["cd_pacote"].ToString() + "'><img src='PACOTE\\" + dt.Rows[i]["cd_pacote"].ToString() + "\\" + Nome_arquivo + "' width='130' height='70'/></a><br>";
             strCss = strCss + dt.Rows[i]["resumo"].ToString();
             strCss = strCss + "</div>";


           }
        }
        /*PACOTE INTERNACIONAL*/
        if (stipo == "I") {

        DataTable dt = Pacote.ListarPorTipo(stipo);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
             string Nome_arquivo = dt.Rows[i]["caminhoimagem"].ToString();
             Nome_arquivo = Nome_arquivo.Replace(".png", "_p.png");

             /*strCss = strCss + "<span itemscope itemtype='http://schema.org/Product'>";
             strCss = strCss + "<p itemprop='name' class='sidebar-title-noshade'>" + dt.Rows[i]["titulo"].ToString() + "</p>";
             strCss = strCss + "<div itemprop='price' class='sidebar-txtbox-noshade'>";
             strCss = strCss + "<a itemprop='url' href='VisualizaPacote.aspx?cd_pacote=" + dt.Rows[i]["cd_pacote"].ToString() + "'><img itemprop='image' src='PACOTE\\" + dt.Rows[i]["cd_pacote"].ToString() + "\\" + Nome_arquivo + "' width='130' height='70'/></a><br>";
             strCss = strCss + dt.Rows[i]["resumo"].ToString();
             strCss = strCss + "</div></span>"; */

             strCss = strCss + "<p class='sidebar-title-noshade'>" + dt.Rows[i]["titulo"].ToString() + "</p>";
             strCss = strCss + "<div class='sidebar-txtbox-noshade'>";
             strCss = strCss + "<a href='VisualizaPacote.aspx?cd_pacote=" + dt.Rows[i]["cd_pacote"].ToString() + "'><img src='PACOTE\\" + dt.Rows[i]["cd_pacote"].ToString() + "\\" + Nome_arquivo + "' width='130' height='70'/></a><br>";
             strCss = strCss + dt.Rows[i]["resumo"].ToString();
             strCss = strCss + "</div>";


             }
        }
        /*PACOTE PRINCIPAL*/
        if (stipo == "P") {

        DataTable dt = Pacote.ListarPorTipo(stipo);
        for (int i = 0; i < dt.Rows.Count; i++)
        {

            strCss = strCss + "     <div class='slide'> ";
            strCss = strCss + "         <a href='VisualizaPacote.aspx?cd_pacote=" + dt.Rows[i]["cd_pacote"].ToString() + "&destino=" + dt.Rows[i]["titulo"].ToString() + "'><img src='PACOTE\\" + dt.Rows[i]["cd_pacote"].ToString() + "\\" + dt.Rows[i]["caminhoimagem"].ToString() + "' width='500' height='280'/></a><br>";
            strCss = strCss + "			<p><a href='VisualizaPacote.aspx?cd_pacote=" + dt.Rows[i]["cd_pacote"].ToString() +"&destino=" + dt.Rows[i]["titulo"].ToString() + "'>Detalhes do pacote.</a></p>";
			strCss = strCss + "		</div> ";

             }
        }
        /*PACOTE LUA DE MEL*/
        if (stipo == "L")
        {

            DataTable dt = Pacote.ListarPorCodigo(icodigo);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string Nome_arquivo = dt.Rows[i]["caminhoimagem"].ToString();
                Nome_arquivo = Nome_arquivo.Replace(".png", "_p.png");
                strCss = strCss + "<div class='sidebar-txtbox-noshade'>";
                strCss = strCss + "<a  href='VisualizaPacote.aspx?cd_pacote=" + dt.Rows[i]["cd_pacote"].ToString() + "'><img src='PACOTE\\" + dt.Rows[i]["cd_pacote"].ToString() + "\\" + Nome_arquivo + "' width='160' height='100'/></a><br>";
                strCss = strCss + "</div></span>";

            }
        }

        if (stipo == "E")
        {
            strCss = strCss + "<table style='width: 100%;' cellpadding='5' cellspacing='5'>";
            strCss = strCss + "<tr>";
            DataTable dt = Pacote.ListarPorTipo(stipo);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string Nome_arquivo = dt.Rows[i]["caminhoimagem"].ToString();
                Nome_arquivo = Nome_arquivo.Replace(".png", "_p.png");

                if (System.Math.IEEERemainder(i, 3) == 0) { strCss = strCss + "</tr><tr>"; }

                strCss = strCss + "<td><a  href='VisualizaPacote.aspx?cd_pacote=" + dt.Rows[i]["cd_pacote"].ToString() + "'><img src='PACOTE\\" + dt.Rows[i]["cd_pacote"].ToString() + "\\" + Nome_arquivo + "' width='160' height='100'/></a></br></br></td>";

            }

        }
        strCss = strCss + "</table>";
        HttpContext.Current.Response.Write(strCss);
    }
    
    public static string ShowImagemPacote(string cdPacote, string nome_imagem)
    {
        string strCss = "";

        string Url = "<img id='imgPacote' src='http://www.tbviagens.com.br/PACOTE/";

        strCss = strCss + Url;

        strCss = strCss + cdPacote;

        strCss = strCss + "/" + nome_imagem + "' style='height:300px;width:500px;border-width:0px;' />";

        return strCss;

    }


    public static string ShowProblemaVisualizacao(string cdPacote)
    {
        string strCss = "";
        
        string Url = "Problemas para visualizar a mensagem?<a href='http://www.tbviagens.com.br/VisualizaEmailMarketing.aspx?cd_pacote=";

        strCss = strCss + Url;

        strCss = strCss + cdPacote;

        strCss = strCss +"'>Acesse este link.</a>";

        return strCss;

    }

    public static void ShowImgPacote(string stipo)
    {
        /*PACOTE NACIONAL*/
        string strCss = "";
        if (stipo == "P")
        {
            strCss = strCss + "       <div class='b-one b-two'>";
            DataTable dt = Pacote.ListarPorTipo(stipo);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string Nome_arquivo = dt.Rows[i]["caminhoimagem"].ToString();

                  strCss = strCss + "        <div class='col-md-4 bt-left'>";
                strCss = strCss + "            <div class='hovereffect'>";
                strCss = strCss + "                <img class='img-responsive' src='PACOTE\\" + dt.Rows[i]["cd_pacote"].ToString() + "\\" + Nome_arquivo +"'> ";
                strCss = strCss + "                <div class='overlay'> ";
                strCss = strCss + "                   <h2>" + dt.Rows[i]["titulo"].ToString()+ "</h2> ";
                strCss = strCss + "                   <a class='info' href='VisualizaPacote.aspx?cd_pacote=" + dt.Rows[i]["cd_pacote"].ToString() + "&destino=" + dt.Rows[i]["titulo"].ToString() + "'>Cotar Viagem</a>";
                strCss = strCss + "                </div>";
                strCss = strCss + "            </div>";
                strCss = strCss + "        </div>";


            }
            strCss = strCss + "        </div>";
        }
        HttpContext.Current.Response.Write(strCss);
    }



    
}