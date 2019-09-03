using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AdminPacotesDetalhes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["LOGADO"] == null) { Response.Redirect("Default.aspx"); };
            Pacote pc = new Pacote();
            pc.Carregar(int.Parse(Request.QueryString["CD_PACOTE"].ToString()));
            Session["cd_pacote"] = Request.QueryString["CD_PACOTE"].ToString();
            lblTitulo.Text = pc.Titulo.ToString();
            txtTipo.Text = pc.Tipo.ToString();
            Editor1.Content = pc.Detalhe;
        }
    }
    protected void btbGravar_Click(object sender, EventArgs e)
    {
        Pacote pc = new Pacote();
        pc.Carregar(int.Parse(Request.QueryString["CD_PACOTE"].ToString()));
        pc.Detalhe = ValidParam.ValidarEditor(Editor1.Content);
        pc.Tipo = ValidParam.ValidarParametro(txtTipo.Text.Trim());
        pc.AtualizarDetalhe();
    }
    protected void btnVisualizar_Click(object sender, EventArgs e)
    {
        Response.Redirect("../VisualizaEmailMarketing.aspx?cd_pacote=" + Session["cd_pacote"].ToString());
    }
}