using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AdminEmailMarketing : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LOGADO"] == null) { Response.Redirect("Default.aspx"); };
        Session["Data"] = EmailMkt.Listar();
        gridEmailMkt.DataSource = Session["Data"];
        gridEmailMkt.DataBind();
    }
    protected void btnExcluir_Click(object sender, ImageClickEventArgs e)
    {
        int Codigo = int.Parse(((ImageButton)sender).CommandArgument);
        EmailMkt em = new EmailMkt();
        em.Codigo = Codigo;
        em.Excluir();
        gridEmailMkt.DataSource = EmailMkt.Listar();
        gridEmailMkt.DataBind();      
    }

    protected void btnGravar_Click(object sender, EventArgs e)
    {
        EmailMkt em = new EmailMkt();

        em.Email = ValidParam.ValidarParametro(txtEmail.Text.Trim());
        em.Nome = ValidParam.ValidarParametro(txtNome.Text.Trim());

        
        if (em.Existe(txtEmail.Text.Trim()) == true)
            lblResultado.Text = "Já existe o e-mail";
        else
        {
            if (lblCodigo.Text == "-")
            {
                em.Inserir();
            }
            else
            {
                em.Codigo = int.Parse(lblCodigo.Text);
                em.Atualizar();
            }
            Session["Data"] = EmailMkt.Listar();
            gridEmailMkt.DataSource = Session["Data"];
            gridEmailMkt.DataBind();
            btnNovo_Click(sender, e);
        }
    }
    protected void btnNovo_Click(object sender, EventArgs e)
    {
        lblCodigo.Text = "-";
        txtEmail.Text = "";
        txtNome.Text = "";
    }
    protected void gridEmailMkt_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gridEmailMkt.PageIndex = e.NewPageIndex;
        gridEmailMkt.DataSource = Session["Data"];
        gridEmailMkt.DataBind();    

    }
    protected void btnAlterar_Click(object sender, ImageClickEventArgs e)
    {
        int codigo = int.Parse(((ImageButton)sender).CommandArgument.ToString());

        EmailMkt em = new EmailMkt();
        if (em.Carregar(codigo))
        {
            lblCodigo.Text = codigo.ToString();
            txtNome.Text = em.Nome.ToString();
            txtEmail.Text = em.Email.ToString();
        }
        else
        {
            btnNovo_Click(sender, e);
        }
    }
    protected void btnPesquisar_Click(object sender, EventArgs e)
    {
        Session["Data"] = EmailMkt.ListarEmail(txtPesquisa.Text.Trim());
        gridEmailMkt.DataSource = Session["Data"];
        gridEmailMkt.DataBind();   
    }
}