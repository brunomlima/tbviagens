using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AdminMensagem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LOGADO"] == null) { Response.Redirect("Default.aspx"); };
        Session["Data"] = Mensagem.Listar();
        gridMensagens.DataSource = Session["Data"];
        gridMensagens.DataBind();
    }
    protected void btnAlterar_Click(object sender, ImageClickEventArgs e)
    {
        int codigo = int.Parse(((ImageButton)sender).CommandArgument.ToString());
        Mensagem mg = new Mensagem();
        if (mg.Carregar(codigo))
        {
            lblCodigo.Text = codigo.ToString();
            txtAutor.Text = mg.Autor.ToString();
            txtConteudo.Text = mg.Conteudo.ToString();
        }
        else
        {
            btnNovo_Click(sender, e);
        }
    }
    protected void btnExcluir_Click(object sender, ImageClickEventArgs e)
    {
        int Codigo = int.Parse(((ImageButton)sender).CommandArgument);
        Mensagem mg = new Mensagem();
        mg.Codigo = Codigo;
        mg.Excluir();
        Session["Data"] = Mensagem.Listar();
        gridMensagens.DataSource = Session["Data"];
        gridMensagens.DataBind();
    }
    protected void btnNovo_Click(object sender, EventArgs e)
    {
        lblCodigo.Text = "-";
        txtAutor.Text = "";
        txtConteudo.Text = "";
    }
    protected void btnGravar_Click(object sender, EventArgs e)
    {
        Mensagem mg = new Mensagem();
        mg.Autor = ValidParam.ValidarParametro(txtAutor.Text.Trim());
        mg.Conteudo = ValidParam.ValidarParametro(txtConteudo.Text.Trim());

        if (lblCodigo.Text == "-")
        {
            mg.Inserir();
        }
        else
        {
            mg.Codigo = int.Parse(lblCodigo.Text);
            mg.Atualizar();
        }
        Session["Data"] = Mensagem.Listar();
        gridMensagens.DataSource = Session["Data"];
        gridMensagens.DataBind();
        btnNovo_Click(sender, e);
    }
    protected void gridMensagens_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gridMensagens.PageIndex = e.NewPageIndex;
        gridMensagens.DataSource = Session["Data"];
        gridMensagens.DataBind();    
    }
}