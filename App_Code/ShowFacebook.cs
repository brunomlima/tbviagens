using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;


public class ShowFacebook
{
	public ShowFacebook()
	{
	}
    



    public static void CurtirPacote(int Codigo)
    {
        string strCss = "";
        string ssrc = "http://www.facebook.com/plugins/like.php?href=http://www.tbviagens.com.br/VisualizaPacote.aspx?cd_pacote=";
        strCss = "<IFRAME style='border-style: none; border-color: inherit; border-width: medium; WIDTH: 538px; HEIGHT: 25px; OVERFLOW: hidden;'" +
                "src='" + ssrc + Codigo.ToString() + "&;layout=standard&show_faces=false&width=380&action=like&colorscheme=light&height=25&locale=pt_BR' " +
                "frameBorder=0 allowTransparency scrolling=no id='I1' name='I1'></IFRAME>";



        strCss = strCss + "<div class='g-plusone' data-size='tall' data-annotation='inline' data-width='300'></div>";
        strCss = strCss + "<script type='text/javascript'>";
        strCss = strCss + "  window.___gcfg = {lang: 'pt-BR'}; ";
        strCss = strCss + "  (function() { ";
        strCss = strCss + "    var po = document.createElement('script'); po.type = 'text/javascript'; po.async = true; ";
        strCss = strCss + "    po.src = 'https://apis.google.com/js/plusone.js';";
        strCss = strCss + "    var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(po, s);";
        strCss = strCss + "  })();";
        strCss = strCss + "</script>";




        HttpContext.Current.Response.Write(strCss);
    }

    public static void CurtirNoivos(int Codigo)
    {
        string strCss = "";
        string ssrc = "http://www.facebook.com/plugins/like.php?href=http://www.tbviagens.com.br/VisualizaNoivos.aspx?cd_noivo=";
        strCss = "<IFRAME style='border-style: none; border-color: inherit; border-width: medium; WIDTH: 538px; HEIGHT: 25px; OVERFLOW: hidden;'" +
                "src='" + ssrc + Codigo.ToString() + "&;layout=standard&show_faces=false&width=380&action=like&colorscheme=light&height=25&locale=pt_BR' " +
                "frameBorder=0 allowTransparency scrolling=no id='I1' name='I1'></IFRAME>";



        strCss = strCss + "<div class='g-plusone' data-size='tall' data-annotation='inline' data-width='300'></div>";
        strCss = strCss + "<script type='text/javascript'>";
        strCss = strCss + "  window.___gcfg = {lang: 'pt-BR'}; ";
        strCss = strCss + "  (function() { ";
        strCss = strCss + "    var po = document.createElement('script'); po.type = 'text/javascript'; po.async = true; ";
        strCss = strCss + "    po.src = 'https://apis.google.com/js/plusone.js';";
        strCss = strCss + "    var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(po, s);";
        strCss = strCss + "  })();";
        strCss = strCss + "</script>";




        HttpContext.Current.Response.Write(strCss);
    }


}