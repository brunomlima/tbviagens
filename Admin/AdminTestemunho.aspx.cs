using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AdminTestemunho : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LOGADO"] == null) { Response.Redirect("Default.aspx"); };
        gridTestemunho.DataSource = Testemunho.Listar();
        gridTestemunho.DataBind();
    }
    protected void btnNovo_Click(object sender, EventArgs e)
    {
        txtNome.Text = "";
        txtTestemunho.Text = "";
        lblCodigo.Text = "-";
    }
    protected void btnGravar_Click(object sender, EventArgs e)
    {
        bool validacao = true;

        if (ValidParam.ValidarTamanho(txtTestemunho.Text.Trim(), 1000) == false)
        {
            lblResultado.Text = "Tamanho máximo permitido para o campo testemunho é de 1000 caracteres.";
            validacao = false;
        }
        if (ValidParam.ValidarTamanho(txtNome.Text.Trim(), 150) == false)
        {
            lblResultado.Text = "Tamanho máximo permitido para o campo nome é de 50 caracteres.";
            validacao = false;
        }

        if (validacao == true)
        {
            Testemunho ts = new Testemunho();
            ts.Nome = ValidParam.ValidarParametro(txtNome.Text.Trim());
            ts.TestemunhoTexto = ValidParam.ValidarParametro(txtTestemunho.Text.Trim());

            if (lblCodigo.Text == "-")
            {
                ts.Inserir();
            }
            else
            {
                ts.Codigo = int.Parse(lblCodigo.Text);
                ts.Atualizar();
            }
            gridTestemunho.DataSource = Testemunho.Listar();
            gridTestemunho.DataBind();
            btnNovo_Click(sender, e);
            lblResultado.Text = "";
        }
    }
    protected void gridTestmunho_SelectedIndexChanged(object sender, EventArgs e)
    {
        gridTestemunho.DataSource = Testemunho.Listar();
        gridTestemunho.DataBind();
    }
    protected void btnImagemdaPessoa_Click(object sender, ImageClickEventArgs e)
    {
        Session["cd_testemunho"] = int.Parse(((ImageButton)sender).CommandArgument.ToString());
        Response.Redirect("AdminTestemunhoImagens.aspx?cd_testemunho=" + Session["cd_testemunho"].ToString());
    }
    protected void btnAlterar_Click(object sender, ImageClickEventArgs e)
    {
        int codigo = int.Parse(((ImageButton)sender).CommandArgument.ToString());
        Testemunho ts = new Testemunho(); 
        if (ts.Carregar(codigo))
        {
            lblCodigo.Text = codigo.ToString();
            txtNome.Text = ts.Nome.ToString();
            txtTestemunho.Text = ts.TestemunhoTexto.ToString();
        }
        else
        {
            btnNovo_Click(sender, e);
        }
    }
    protected void btnExcluir_Click(object sender, ImageClickEventArgs e)
    {

        int Codigo = int.Parse(((ImageButton)sender).CommandArgument);

        //Testemunho tsExcluirImagens = new Testemunho();
        //tsExcluirImagens.Carregar(Codigo);
        //if (tsExcluirImagens.Imagem1.ToString().Trim() != "")
        //    if (System.IO.File.Exists(Request.ServerVariables["APPL_PHYSICAL_PATH"] + @"TESTEMUNHO\" + tsExcluirImagens.Codigo + "\\" + tsExcluirImagens.Imagem1))
        //    {
        //        System.IO.File.Delete(Request.ServerVariables["APPL_PHYSICAL_PATH"] + @"TESTEMUNHO\" + tsExcluirImagens.Codigo + "\\" + tsExcluirImagens.Imagem1);
        //    }
        //if (tsExcluirImagens.Imagem.ToString().Trim() != "")
        //    if (System.IO.File.Exists(Request.ServerVariables["APPL_PHYSICAL_PATH"] + @"TESTEMUNHO\" + tsExcluirImagens.Codigo + "\\" + tsExcluirImagens.Imagem))
        //    {
        //        System.IO.File.Delete(Request.ServerVariables["APPL_PHYSICAL_PATH"] + @"TESTEMUNHO\" + tsExcluirImagens.Codigo + "\\" + tsExcluirImagens.Imagem);
        //    }

        // Exclui o diretorio.
        System.IO.Directory.Delete(Request.ServerVariables["APPL_PHYSICAL_PATH"] + @"TESTEMUNHO\" + Codigo, true);

        Testemunho ts = new Testemunho();
        ts.Codigo = Codigo;
        ts.Excluir();

        gridTestemunho.DataSource = Testemunho.Listar();
        gridTestemunho.DataBind();  
    }
    protected void btnImagemGrande_Click(object sender, ImageClickEventArgs e)
    {
        Session["cd_testemunho"] = int.Parse(((ImageButton)sender).CommandArgument.ToString());
        Response.Redirect("AdminTestemunhoImagensGrande.aspx?cd_testemunho=" + Session["cd_testemunho"].ToString());
    }
}