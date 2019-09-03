using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class ShowMessage
{
    public ShowMessage()
    {
    }
    public static void alert(string mensagemErro, System.Web.UI.Control Controle)
    {
        System.Web.UI.ScriptManager.RegisterClientScriptBlock(Controle, typeof(string), "erro", "<script language=\"javascript\">alert('" + mensagemErro + "');</script>", true);
    }
    public static void openWindow(string parametros, System.Web.UI.Control Controle)
    {
        System.Web.UI.ScriptManager.RegisterClientScriptBlock(Controle, typeof(string), "erro", "<script language=javascript> function janelaSecundaria (URL){ window.open(URL,'janela1','" + parametros + "')   } </script>", false);
    }

    public static void lightBox(System.Web.UI.Control Controle)
    {
        System.Web.UI.ScriptManager.RegisterClientScriptBlock(Controle, typeof(string), "erro", "<script type='text/javascript' src='lightbox.js'></script>", false);
    }
    public static void Skype(System.Web.UI.Control Controle)
    {
        System.Web.UI.ScriptManager.RegisterClientScriptBlock(Controle, typeof(string), "erro", "<script type='text/javascript' src='http://cdn.dev.skype.com/uri/skype-uri.js'></script>", false);
    }
    public static void conversaoGoogle(System.Web.UI.Control Controle)
    {
        System.Web.UI.ScriptManager.RegisterClientScriptBlock(Controle, typeof(string), "erro", "<script type='text/javascript'></script><script type='text/javascript' src='//www.googleadservices.com/pagead/conversion.js'></script><noscript><div style='display:inline;'><img height='1' width='1' style='border-style:none;' alt='' src='//www.googleadservices.com/pagead/conversion/990353346/?label=qH26CJy75FYQwq-e2AM&amp;guid=ON&amp;script=0'/></div></noscript>", false);      
    }

}
