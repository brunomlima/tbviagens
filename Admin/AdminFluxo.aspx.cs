using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AdminFluxo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LOGADO"] == null) { Response.Redirect("Default.aspx"); };
        gridFluxo.DataSource = FluxoEmails.Listar();
        gridFluxo.DataBind();
        Session["Data"] = FluxoEmails.Listar();

    }
    protected void btnCorpoEmailPacote_Click(object sender, ImageClickEventArgs e)
    {
        Session["cd_fluxo_emails"] = int.Parse(((ImageButton)sender).CommandArgument.ToString());
        Response.Redirect("AdminFluxoEmails.aspx?cd_fluxo_emails=" + Session["cd_fluxo_emails"].ToString());
    }
    protected void btnImagemEmailPacote_Click(object sender, ImageClickEventArgs e)
    {
        Session["cd_fluxo_emails"] = int.Parse(((ImageButton)sender).CommandArgument.ToString());
        FluxoEmails fe = new FluxoEmails();
        fe.Carregar(int.Parse(((ImageButton)sender).CommandArgument.ToString()));
        Response.Redirect("AdminEmailImagens.aspx?cd_pacote=" + fe.Cd_Pacote.ToString()+"&cd_fluxo_emails=" + Session["cd_fluxo_emails"].ToString());
    }
    protected void btnAnexoPacote_Click1(object sender, ImageClickEventArgs e)
    {
        Session["cd_fluxo_emails"] = int.Parse(((ImageButton)sender).CommandArgument.ToString());
        FluxoEmails fe = new FluxoEmails();
        fe.Carregar(int.Parse(((ImageButton)sender).CommandArgument.ToString()));
        Response.Redirect("AdminEmailAnexo.aspx?cd_pacote=" + fe.Cd_Pacote.ToString() + "&cd_fluxo_emails=" + Session["cd_fluxo_emails"].ToString());

    }
    protected void btnAlterar_Click(object sender, ImageClickEventArgs e)
    {
        int codigo = int.Parse(((ImageButton)sender).CommandArgument.ToString());
        FluxoEmails fe = new FluxoEmails();
        if (fe.Carregar(codigo))
        {
            lblCodigo.Text = codigo.ToString();
            txtPacote.Text = fe.Cd_Pacote.ToString();
            txtTitulo.Text = fe.Titulo.ToString();
            txtSequencia.Text = fe.Sequencia.ToString();
            txtDias.Text = fe.Tempo_Proximo_Envio.ToString();
        }
        else
        {
            btnNovo_Click(sender, e);
        }

    }
    protected void btnExcluir_Click(object sender, ImageClickEventArgs e)
    {
        int Codigo = int.Parse(((ImageButton)sender).CommandArgument);
        FluxoEmails fe = new FluxoEmails();
        fe.Codigo = Codigo;
        fe.Excluir();
        gridFluxo.DataSource = FluxoEmails.Listar();
        gridFluxo.DataBind();  
    }
    protected void btnGravar_Click(object sender, EventArgs e)
    {
        bool validacao = true;

        if (ValidParam.ValidarTamanho(txtTitulo.Text.Trim(), 200) == false)
        {
            lblResultado.Text = "Tamanho máximo permitido para o campo resumo é de 200 caracteres.";
            validacao = false;
        }
        if (ValidParam.ValidarTamanho(txtSequencia.Text.Trim(), 3) == false)
        {
            lblResultado.Text = "Tamanho máximo permitido para o campo titulo é de 3 caracteres.";
            validacao = false;
        }

        if (validacao == true)
        {
            FluxoEmails fe = new FluxoEmails();
            fe.Titulo = ValidParam.ValidarParametro(txtTitulo.Text.Trim());
            fe.Sequencia = ValidParam.ValidarParametro(txtSequencia.Text.Trim());
            fe.Tempo_Proximo_Envio = ValidParam.ValidarParametro(txtDias.Text.Trim());
            fe.Cd_Pacote = ValidParam.ValidarParametro(txtPacote.Text.Trim());

            if (lblCodigo.Text == "-")
            {
                fe.Inserir();
            }
            else
            {
                fe.Codigo = int.Parse(lblCodigo.Text);
                fe.Atualizar();
            }
            gridFluxo.DataSource = FluxoEmails.Listar();
            gridFluxo.DataBind();
            btnNovo_Click(sender, e);
            lblResultado.Text = "";
        }
    }
    protected void btnNovo_Click(object sender, EventArgs e)
    {
        txtPacote.Text = "";
        txtDias.Text = "";
        txtSequencia.Text = "";
        txtTitulo.Text = "";
        lblCodigo.Text = "-";
    }
    protected void gridFluxo_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void bntFiltrar_Click(object sender, EventArgs e)
    {
        Session["Data"] = FluxoEmails.ListarPacote(txtFiltra.Text.Trim());
        gridFluxo.DataSource = Session["Data"];
        gridFluxo.DataBind(); 
    }
    protected void gridFluxo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gridFluxo.PageIndex = e.NewPageIndex;
        gridFluxo.DataSource = Session["Data"];
        gridFluxo.DataBind();
    }
}