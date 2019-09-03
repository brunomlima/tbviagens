using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Descrição resumida de ShowEnderecos
/// </summary>
public class ShowEnderecos
{
    public ShowEnderecos()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }
    public static void Show()
    {
    }

    public static void ShowBig()
    {
        string strCss = "";
        DataTable dt = Ferramentas.ListarImagemGrande();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if (i % 2 == 0)
            {
                //Esquerdo
                strCss = strCss + "   <div class='blog'>";
                strCss = strCss + "   <div class='col-md-4 blog-text'> ";
                strCss = strCss + "		   <h5></h5> ";
                strCss = strCss + "		   <a href='"+ dt.Rows[i]["url"].ToString() + "'><h4>" + dt.Rows[i]["url"].ToString() + "</h4></a> ";
                strCss = strCss + "		   <p>" + dt.Rows[i]["descricao"].ToString() + "</p> ";
                strCss = strCss + "	   </div> ";
                strCss = strCss + "		<div class='col-md-8 welcome-img'> ";
                //strCss = strCss + "		 <a href='single.html' class='mask'><img src='" + "testemunho/" + dt.Rows[i]["cd_testemunho"].ToString() + "/" + dt.Rows[i]["imagem1"].ToString() + "' alt='image' class='img-responsive zoom-img'></a> ";
                strCss = strCss + "		</div> ";
                strCss = strCss + "	   <div class='clearfix'> </div> ";
                strCss = strCss + "   </div> ";
            }
            else
            {
                //Direito                  
                strCss = strCss + "   <div class='blog'> ";
                strCss = strCss + "	 <div class='col-md-4 blog-text two'> ";
                strCss = strCss + "		   <h5></h5> ";
                strCss = strCss + "		  <a href='single.html'><h4>" + dt.Rows[i]["nome"].ToString() + "</h4></a>";
                strCss = strCss + "		   <p>" + dt.Rows[i]["testemunho"].ToString() + "</p> ";
                strCss = strCss + "	   </div> ";
                strCss = strCss + "		<div class='col-md-8 blog-img two'> ";
                //strCss = strCss + "		 <a href='single.html' class='mask'><img src='" + "testemunho/" + dt.Rows[i]["cd_testemunho"].ToString() + "/" + dt.Rows[i]["imagem1"].ToString() + "' alt='image' class='img-responsive zoom-img'></a> ";
                strCss = strCss + "		</div> ";
                strCss = strCss + "	   <div class='clearfix'> </div> ";
                strCss = strCss + "   </div> ";
            }
        }

        HttpContext.Current.Response.Write(strCss);
    }
}