using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AdminAcessos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LOGADO"] == null) { Response.Redirect("Default.aspx"); };
        gridAcessoBloqueado.DataSource = Acesso.ListarBloqueados(Session["cd_usuario"].ToString());
        gridAcessoBloqueado.DataBind();
        gridAcessoLiberado.DataSource = Acesso.ListarLiberados(Session["cd_usuario"].ToString());
        gridAcessoLiberado.DataBind();
    }
    protected void btnRevogar_Click(object sender, ImageClickEventArgs e)
    {
        Acesso ac = new Acesso();
        ac.Revogar(Session["cd_usuario"].ToString(), ((ImageButton)sender).CommandArgument.ToString());
        gridAcessoBloqueado.DataSource = Acesso.ListarBloqueados(Session["cd_usuario"].ToString());
        gridAcessoBloqueado.DataBind();
        gridAcessoLiberado.DataSource = Acesso.ListarLiberados(Session["cd_usuario"].ToString());
        gridAcessoLiberado.DataBind();
    }
    protected void btnConceder_Click(object sender, ImageClickEventArgs e)
    {
        Acesso ac = new Acesso();
        ac.Conceder(Session["cd_usuario"].ToString(), ((ImageButton)sender).CommandArgument.ToString());
        gridAcessoBloqueado.DataSource = Acesso.ListarBloqueados(Session["cd_usuario"].ToString());
        gridAcessoBloqueado.DataBind();
        gridAcessoLiberado.DataSource = Acesso.ListarLiberados(Session["cd_usuario"].ToString());
        gridAcessoLiberado.DataBind();
    }
}