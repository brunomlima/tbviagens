using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AdminFerramentas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LOGADO"] == null) { Response.Redirect("Default.aspx"); };
        gridFerramenta.DataSource = Ferramentas.Listar();
        gridFerramenta.DataBind();
    }
    protected void btnExcluir_Click(object sender, ImageClickEventArgs e)
    {
        int Codigo = int.Parse(((ImageButton)sender).CommandArgument);
        Ferramentas fr = new Ferramentas();
        fr.Codigo = Codigo;
        fr.Excluir();
        gridFerramenta.DataSource = Ferramentas.Listar();
        gridFerramenta.DataBind();      
    }
    protected void gridFerramenta_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnGravar_Click(object sender, EventArgs e)
    {

        bool validacao = true;

        if (ValidParam.ValidarTamanho(txtUrl.Text.Trim(), 200) == false)
        {
            lblResultado.Text = "Tamanho máximo permitido para o campo resumo é de 200 caracteres.";
            validacao = false;
        }
        if (ValidParam.ValidarTamanho(txtDescricao.Text.Trim(), 100) == false)
        {
            lblResultado.Text = "Tamanho máximo permitido para o campo titulo é de 100 caracteres.";
            validacao = false;
        }
        if (ValidParam.ValidarTamanho(txtTipo.Text.Trim(), 1) == false)
        {
            lblResultado.Text = "Tamanho máximo permitido para o campo titulo é de 1 caractere.";
            validacao = false;
        }

        if (validacao == true)
        {
            Ferramentas pc = new Ferramentas();
            pc.Descricao = ValidParam.ValidarParametro(txtDescricao.Text.Trim());
            pc.Url = ValidParam.ValidarParametro(txtUrl.Text.Trim());
            pc.Tipo = ValidParam.ValidarParametro(txtTipo.Text.Trim());

            if (lblCodigo.Text == "-")
            {
                pc.Inserir();
            }
            else
            {
                pc.Codigo = int.Parse(lblCodigo.Text);
                pc.Atualizar();
            }
            gridFerramenta.DataSource = Ferramentas.Listar();
            gridFerramenta.DataBind();
            btnNovo_Click(sender, e);
            lblResultado.Text = "";
        }

    }
    protected void btnNovo_Click(object sender, EventArgs e)
    {
        lblCodigo.Text = "-";
        txtDescricao.Text = "";
        txtUrl.Text = "";
        lblCodigo.Text = "-";
        txtTipo.Text = "";
    }
    protected void btnAlterar_Click(object sender, ImageClickEventArgs e)
    {
        int codigo = int.Parse(((ImageButton)sender).CommandArgument.ToString());
        Ferramentas pc = new Ferramentas();
        if (pc.Carregar(codigo))
        {
            lblCodigo.Text = codigo.ToString();
            txtDescricao.Text = pc.Descricao.ToString();
            txtUrl.Text = pc.Url.ToString();
            txtTipo.Text = pc.Tipo.ToString();
 
        }
        else
        {
            btnNovo_Click(sender, e);
        }
    }
}