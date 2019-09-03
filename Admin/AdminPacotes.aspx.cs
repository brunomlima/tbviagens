using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AdminPacotes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LOGADO"] == null) { Response.Redirect("Default.aspx"); };
        gridPacote.DataSource = Pacote.Listar();
        gridPacote.DataBind();
    }
    protected void btnNovo_Click(object sender, EventArgs e)
    {
        txtResmo.Text = "";
        txtTitulo.Text = "";
        lblCodigo.Text = "-";
    }
    protected void btnGravar_Click(object sender, EventArgs e)
    {
        bool validacao = true;

        if (ValidParam.ValidarTamanho(txtResmo.Text.Trim(), 500) == false)
        {
            lblResultado.Text = "Tamanho máximo permitido para o campo resumo é de 500 caracteres.";
            validacao = false;
        }
        if (ValidParam.ValidarTamanho(txtTitulo.Text.Trim(), 150) == false)
        {
            lblResultado.Text = "Tamanho máximo permitido para o campo titulo é de 50 caracteres.";
            validacao = false;
        }

        if (validacao == true)
        {
            Pacote pc = new Pacote();
            pc.Resumo = ValidParam.ValidarParametro(txtResmo.Text.Trim());
            pc.Titulo = ValidParam.ValidarParametro(txtTitulo.Text.Trim());
            
            if (lblCodigo.Text == "-")
            {
                pc.Inserir();
            }
            else
            {
                pc.Codigo = int.Parse(lblCodigo.Text);
                pc.Atualizar();
            }
            gridPacote.DataSource = Pacote.Listar();
            gridPacote.DataBind();
            btnNovo_Click(sender, e);
            lblResultado.Text = "";
        }
    }
    protected void btnAlterar_Click(object sender, ImageClickEventArgs e)
    {
        int codigo = int.Parse(((ImageButton)sender).CommandArgument.ToString());
        Pacote pc = new Pacote();
        if (pc.Carregar(codigo))
        {
            lblCodigo.Text = codigo.ToString();
            txtTitulo.Text = pc.Titulo.ToString();
            txtResmo.Text = pc.Resumo.ToString();
        }
        else
        {
            btnNovo_Click(sender, e);
        }
    }
    protected void btnDetalhePacote_Click(object sender, ImageClickEventArgs e)
    {
        Session["cd_pacote"] = int.Parse(((ImageButton)sender).CommandArgument.ToString());
        Response.Redirect("AdminPacotesDetalhes.aspx?cd_pacote=" + Session["cd_pacote"].ToString());
    }
    protected void btnExcluir_Click(object sender, ImageClickEventArgs e)
    {
        int Codigo = int.Parse(((ImageButton)sender).CommandArgument);
        // Exclui o diretorio.
        System.IO.Directory.Delete(Request.ServerVariables["APPL_PHYSICAL_PATH"] + @"PACOTE\" + Codigo, true);

        Pacote pc = new Pacote();
        pc.Codigo = Codigo;
        pc.Excluir();
        gridPacote.DataSource = Pacote.Listar();
        gridPacote.DataBind();       

    }
    protected void gridUsuario_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnImagemPacote_Click(object sender, ImageClickEventArgs e)
    {
        Session["cd_pacote"] = int.Parse(((ImageButton)sender).CommandArgument.ToString());
        Response.Redirect("AdminPacotesImagens.aspx?cd_pacote=" + Session["cd_pacote"].ToString());
    }
    protected void btnEmailMarketing_Click(object sender, ImageClickEventArgs e)
    {
        Session["cd_pacote"] = int.Parse(((ImageButton)sender).CommandArgument.ToString());
        Response.Redirect("../VisualizaEmailMarketing.aspx?cd_pacote=" + Session["cd_pacote"].ToString());
    }
    protected void btnEnviaEmailMarketing_Click(object sender, ImageClickEventArgs e)
    {
        Session["cd_pacote"] = int.Parse(((ImageButton)sender).CommandArgument.ToString());
        Response.Redirect("AdminEnvio.aspx");
    }
    protected void btnImagemPacote_Click1(object sender, ImageClickEventArgs e)
    {
        Session["cd_pacote"] = int.Parse(((ImageButton)sender).CommandArgument.ToString());
        Response.Redirect("AdminPacotesImagens1.aspx?cd_pacote=" + Session["cd_pacote"].ToString());
    }
    protected void btnVisualizaPacoteEspecial_Click(object sender, ImageClickEventArgs e)
    {
        Session["cd_pacote"] = int.Parse(((ImageButton)sender).CommandArgument.ToString());
        Response.Redirect("../PacoteEspecial.aspx?cd_pacote=" + Session["cd_pacote"].ToString());
    }
}