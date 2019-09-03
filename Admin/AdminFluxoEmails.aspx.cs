using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AdminFluxoEmails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["LOGADO"] == null) { Response.Redirect("Default.aspx"); };
            FluxoEmails fe = new FluxoEmails();
            fe.Carregar(int.Parse(Request.QueryString["CD_FLUXO_EMAILS"].ToString()));
            Session["CD_FLUXO_EMAILS"] = Request.QueryString["CD_FLUXO_EMAILS"].ToString();
            txtTitulo.Text = fe.Titulo.ToString();
            txtSequencia.Text = fe.Sequencia.ToString();
            txtDias.Text = fe.Tempo_Proximo_Envio.ToString();
            txtEditorHTML.Text = fe.Corpo;
        }

    }
    protected void btbGravar_Click(object sender, EventArgs e)
    {
        FluxoEmails fe = new FluxoEmails();
        fe.Carregar(int.Parse(Request.QueryString["CD_FLUXO_EMAILS"].ToString()));
        fe.Corpo = ValidParam.ValidarEditor(txtEditorHTML.Text);
        fe.Tempo_Proximo_Envio = ValidParam.ValidarParametro(txtDias.Text.Trim());
        fe.Sequencia = ValidParam.ValidarParametro(txtSequencia.Text.Trim());
        fe.Titulo = ValidParam.ValidarParametro(txtTitulo.Text.Trim());
        fe.AtualizarEmail();
    }
}