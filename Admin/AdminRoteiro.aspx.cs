using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AdminRoteiro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LOGADO"] == null) { Response.Redirect("Default.aspx"); };
        gridRoteiro.DataSource = Roteiro.Listar();
        gridRoteiro.DataBind();
    }

    protected void btnNovo_Click(object sender, EventArgs e)
    {
        lblCodigo.Text = "-";
        txtDestino.Text = "";
        txtDetalhe.Text = "";
        txtDtRoteiro.Text = "";
        txtEndereco.Text = "";
        txtMapa.Text = "";
        txtNome.Text = "";
        lblimagem.Text = "";
        txtHorario.Text = "";
    }

    protected void btnGravar_Click(object sender, EventArgs e)
    {
        Roteiro rt = new Roteiro();
        DateTime dtx;
        DateTime.TryParse(txtDtRoteiro.Text, out dtx);
        rt.Data = dtx;
        rt.Nome = txtNome.Text;
        rt.Destino = txtDestino.Text;
        rt.Detalhe = txtDetalhe.Text;
        rt.Mapa = txtMapa.Text;
        rt.Endereco = txtEndereco.Text;
        rt.CaminhoImagem = lblimagem.Text;
        rt.HoraMinSegundo = txtHorario.Text;
        if (lblCodigo.Text == "-")
        {
            rt.Inserir();
        }
        else
        {
            rt.Codigo = int.Parse(lblCodigo.Text);
            rt.Atualizar();
        }
        gridRoteiro.DataSource = Roteiro.Listar();
        gridRoteiro.DataBind();
        btnNovo_Click(sender, e);
    }

    protected void btnImagem_Click(object sender, ImageClickEventArgs e)
    {
        Session["cd_roteiro"] = int.Parse(((ImageButton)sender).CommandArgument);
        Response.Redirect("AdminRoteiroImagens.aspx?cd_roteiro=" + Session["cd_roteiro"].ToString());
    }

    protected void btnAlterar_Click(object sender, ImageClickEventArgs e)
    {
        int codigo = int.Parse(((ImageButton)sender).CommandArgument.ToString());
        Roteiro rt = new Roteiro();
        if (rt.Carregar(codigo))
        {
            lblCodigo.Text = codigo.ToString();
            txtDestino.Text = rt.Destino.ToString();
            txtDtRoteiro.Text = rt.Data.ToString("dd/MM/yyyy");
            txtNome.Text = rt.Nome.ToString();
            txtDetalhe.Text = rt.Detalhe.ToString();
            txtMapa.Text = rt.Mapa.ToString();
            txtEndereco.Text = rt.Endereco.ToString();
            lblimagem.Text = rt.CaminhoImagem.ToString();
            txtHorario.Text = rt.HoraMinSegundo.ToString();
        }
        else
        {
            btnNovo_Click(sender, e);
        }
    }

    protected void btnExcluir_Click(object sender, ImageClickEventArgs e)
    {
        int Codigo = int.Parse(((ImageButton)sender).CommandArgument);
        Roteiro rt = new Roteiro();
        rt.Codigo = Codigo;
        rt.Excluir();
        gridRoteiro.DataSource = Noivo.Listar();
        gridRoteiro.DataBind();
    }

    protected void txtDtRoteiro_TextChanged(object sender, EventArgs e)
    {

    }
}