using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;

public class ShowRoteiro
{
    public ShowRoteiro()
    {
    }

    public static void ShowBig(string sRoteiro)
    {
        string strCss = "";
        DataTable dt = Roteiro.ListarImagem(sRoteiro);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if (i % 2 == 0)
            {
                //Esquerdo
                strCss = strCss + "   <div class='blog'>";
                strCss = strCss + "   <div class='col-md-4 blog-text'> ";
                strCss = strCss + "		   <h5></h5> ";
                strCss = strCss + "		   <a href='#'><h4>" + dt.Rows[i]["data"].ToString().Substring(0, 10) + " <br> " + dt.Rows[i]["destino"].ToString() + "</h4></a> ";
                strCss = strCss + "		   <p>" + dt.Rows[i]["detalhe"].ToString() + "</p> ";
                strCss = strCss + "	   </div> ";
                strCss = strCss + "		<div class='col-md-8 welcome-img'> ";
                String caminho_imagem;
                if (dt.Rows[i]["imagem"].ToString().Trim() != "")
                {
                    caminho_imagem = "roteiro/" + dt.Rows[i]["cd_roteiro"].ToString() + "/" + dt.Rows[i]["imagem"].ToString();
                }
                else
                {
                    caminho_imagem = "imagens/localizador.jpg"; 
                };
                strCss = strCss + "		 <a href='"+ dt.Rows[i]["mapa"].ToString() + "' class='mask'><img src='" + caminho_imagem + "' alt='image' class='img-responsive zoom-img'></a> ";
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
                strCss = strCss + "		  <a href='#'><h4>" + dt.Rows[i]["data"].ToString().Substring(0, 10) + " <br> " + dt.Rows[i]["destino"].ToString() + "</h4></a>";
                strCss = strCss + "		   <p>" + dt.Rows[i]["detalhe"].ToString() + "</p> ";
                strCss = strCss + "	   </div> ";
                strCss = strCss + "		<div class='col-md-8 blog-img two'> ";

                String caminho_imagem;
                if (dt.Rows[i]["imagem"].ToString().Trim() != "")
                {
                    caminho_imagem = "roteiro/" + dt.Rows[i]["cd_roteiro"].ToString() + "/" + dt.Rows[i]["imagem"].ToString();
                }
                else
                {
                    caminho_imagem = "imagens/localizador.jpg";
                };

                strCss = strCss + "		 <a href='" + dt.Rows[i]["mapa"].ToString() + "' class='mask'><img src='" + caminho_imagem + "' alt='image' class='img-responsive zoom-img'></a> ";
                strCss = strCss + "		</div> ";
                strCss = strCss + "	   <div class='clearfix'> </div> ";
                strCss = strCss + "   </div> ";
            }
        }

        HttpContext.Current.Response.Write(strCss);
    }
}