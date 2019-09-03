using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;

public class ShowImagens
{
	public ShowImagens(){}
    public static void ShowDir(string dir, string aref, string title)
    {
        string strCss = "";
        System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(dir);
        System.IO.FileInfo[] fi = di.GetFiles();
        int x = 0;
        foreach (System.IO.FileInfo arquivo in fi){x = x + 1;}        
        if (x > 0)        
        {
            strCss = strCss + "<h3>" + title + "</h3><p>|";        
            foreach (System.IO.FileInfo arquivo in fi)
            {                
                strCss = strCss + "<a href='" + aref + arquivo.Name + "'> " + arquivo.Name.Substring(0, arquivo.Name.Length - 4) + " (" + arquivo.Name.Substring(arquivo.Name.Length - 3, 3).ToUpper() + ")" + "</a> |";
            }
            strCss = strCss + "</p>";
        }                 
        HttpContext.Current.Response.Write(strCss);
    }
    public static void ShowDirImag(string dir, string aref, string title)
    {
        string strCss = "";
        int contador = 0;
        System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(dir);
        System.IO.FileInfo[] fi = di.GetFiles();
        strCss = strCss + "<h1 class='title'><a href='#'>" + title + "</a></h1>";
        strCss = strCss + "<BR><BR>";
        strCss = strCss = "<table style='width: 100%;'>";
        strCss = strCss = "<tr>";

        foreach (System.IO.FileInfo arquivo in fi)
        {
            contador = contador + 1;
            if (System.Math.IEEERemainder(contador, 3) == 0) { strCss = strCss + "</tr><tr>"; }
            strCss = strCss + "<td><a href='" + aref + "AMPLIADA/" + arquivo.Name + "'  rel='lightbox' title='" + arquivo.Name + "' > <img alt='" + arquivo.Name + "' src='" + aref + arquivo.Name + "' style='height: 137px; width: 170px' /></a></td>";
        }
        strCss = strCss + "</table>";
        HttpContext.Current.Response.Write(strCss);
    }
    
    public static void MostraMensagem()
    {
        Mensagem ms = new Mensagem();
        ms.CarregarRandom();
        string strCss = "";       
        strCss = strCss + "<div>";
	    strCss = strCss + "	<p>"+ ms.Conteudo.ToString() +" </p>";
	    strCss = strCss + "<p><b>"+ ms.Autor.ToString() +"</b></p> ";
	    strCss = strCss + "</div> ";
        HttpContext.Current.Response.Write(strCss);
    }

    public static void ShowPortifolio(string aref)
    {
        string strCss = "";
        int contador = 0;
        DataTable dt = Portifolios.Listar();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            strCss = strCss + "<h3>" + dt.Rows[i]["url"].ToString() + "</h3>";
            strCss = strCss + "<table style='width: 100%'>";
            strCss = strCss + "    <tr>";
            strCss = strCss + "        <td>";
            strCss = strCss + "           <a href=http://" + dt.Rows[i]["url"].ToString() + "/> ";
            strCss = strCss + "           <img src='" + aref + "\\" + dt.Rows[i]["cd_portifolio"].ToString() + "\\" + dt.Rows[i]["imagem"].ToString() + "' width='400' height='300' class='float-left' /> ";
            strCss = strCss + "        </td>";
            strCss = strCss + "    </tr>";
            strCss = strCss + "    <tr>";
            strCss = strCss + "        <td>";
            strCss = strCss + dt.Rows[i]["detalhes"].ToString();
            strCss = strCss + "        </td>";
            strCss = strCss + "    </tr>";
            strCss = strCss + "</table>";            
            contador = contador + 1;
        }        
        HttpContext.Current.Response.Write(strCss);
    }

    public static void ShowAcessos(string cpf)
    {
        string strCss = "";        
        DataTable dt = LoginSite.Listar(cpf);
        for (int i = 0; i < dt.Rows.Count; i++)
        {                       
            strCss = strCss + "<li><span><a href='" + dt.Rows[i]["pagina"].ToString() + "'>" + dt.Rows[i]["nome_modulo"].ToString() + "</a></span></li>";
        }       
        HttpContext.Current.Response.Write(strCss);
    }

    public static void ShowCategorias()
    {
        string strCss = "";
        DataTable dt = Categoria.ListarPaginaInicial();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            strCss = strCss + "<li><a href='Artigos.aspx?cd=" + dt.Rows[i]["cd_categoria"].ToString() + " '>" + dt.Rows[i]["nome_categoria"].ToString() + " (" + dt.Rows[i]["qtd_artigos"].ToString() + ")</a></li>";						
        }        
        HttpContext.Current.Response.Write(strCss);
    }

    public static void ShowCategoriasEdicao()
    {
        string strCss = "";        
        DataTable dt = Categoria.Listar();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            strCss = strCss + "<li><a href='ArtigosEditor.aspx?cd=" + dt.Rows[i]["cd_categoria"].ToString() + " '>" + dt.Rows[i]["nome_categoria"].ToString() + "</a></li>";						
        }        
        HttpContext.Current.Response.Write(strCss);
    }
    


    public static void ShowArtigos(string cd_categoria)
    {
        string strCss = "";
        strCss = strCss + "<ol>";
        DataTable dt = Artigo.Listar(cd_categoria);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            strCss = strCss + "<li><span><a href='ArtigoNaIntegra.aspx?cd=" + dt.Rows[i]["cd_artigo"].ToString() + " '>" + dt.Rows[i]["titulo"].ToString() + "</a></span></li>";
        }
        strCss = strCss + "</ol>";
        HttpContext.Current.Response.Write(strCss);
    }
    public static void ShowArtigosEditor(string cd_categoria)
    {
        string strCss = "";        
        DataTable dt = Artigo.Listar(cd_categoria);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            strCss = strCss + "<li><span><a href='Editor.aspx?cd=" + dt.Rows[i]["cd_artigo"].ToString() + " '>" + dt.Rows[i]["titulo"].ToString() + "</a>";
            strCss = strCss + "<a href='AdmArquivos.aspx?cd=" + dt.Rows[i]["cd_artigo"].ToString() + " '>" + " (Arquivos)" + "</a>";
            strCss = strCss + "<a href='AdmExcluiArtigo.aspx?cd=" + dt.Rows[i]["cd_artigo"].ToString() + " '>" + " (Excluir)" + "</a>";
            strCss = strCss + "</span></li>";
        }        
        HttpContext.Current.Response.Write(strCss);
    }
    public static void ShowComentarios(string cd_artigo)
    {
        string strCss = "";
        int x = 0;
        DataTable dt = Comentario.Listar(cd_artigo);
        for (int i = 0; i < dt.Rows.Count; i++){x = x + 1;}
        if (x > 0)
        {
            
            strCss = strCss + "<h3>Comentários</h3>";            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                strCss = strCss + "<blockquote><p>";
                strCss = strCss + dt.Rows[i]["conteudo"].ToString();
                strCss = strCss + "</p></blockquote>";
            }
        }
        HttpContext.Current.Response.Write(strCss);
    }
    
}
