using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AdminNoivos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LOGADO"] == null) { Response.Redirect("Default.aspx"); };
        gridNoivo.DataSource = Noivo.Listar();
        gridNoivo.DataBind();
        txtMsgNoivos.Attributes["onkeydown"] = String.Format("countMsgNoivos('{0}')", txtMsgNoivos.ClientID);
        txtMsgNoivos.Attributes["onkeyup"] = String.Format("countMsgNoivos('{0}')", txtMsgNoivos.ClientID);
    }
    protected void btnAlterar_Click(object sender, ImageClickEventArgs e)
    {
        int codigo = int.Parse(((ImageButton)sender).CommandArgument.ToString());
        Noivo nv = new Noivo();
        if (nv.Carregar(codigo))
        {
            lblCodigo.Text = codigo.ToString();
            txtNomedosNoivos.Text = nv.Nome_Noivos.ToString();
            txtBanco.Text = nv.Banco.ToString();
            txtAgencia.Text = nv.Agencia.ToString();
            txtContaCorrente.Text = nv.ContaCorrente.ToString();
            txtFavorecido.Text = nv.Favorecido.ToString();
            txtCPF.Text = nv.Cpf.ToString();
            txtDtCasamento.Text = nv.DtCasamento.ToString("dd/MM/yyyy");
            txtEmailNoiva.Text = nv.EmaiNoiva.ToString();
            txtEmailNoivo.Text = nv.EmailNoivo.ToString();
            txtMsgNoivos.Text = nv.Mensagem.ToString();
            txtTipoCota.Text = nv.TipoCota.ToString();
            txtValor1.Text = nv.Valor1.ToString();
            txtValor2.Text = nv.Valor2.ToString();
            txtValor3.Text = nv.Valor3.ToString();
            txtValor4.Text = nv.Valor4.ToString();
            txtValor5.Text = nv.Valor5.ToString();
            txtCdPacote.Text = nv.CdPacote.ToString();
        }
        else
        {
            btnNovo_Click(sender, e);
        }
    }
    protected void btnExcluir_Click(object sender, ImageClickEventArgs e)
    {
        int Codigo = int.Parse(((ImageButton)sender).CommandArgument);
        Noivo nv = new Noivo();
        nv.Codigo = Codigo;
        nv.Excluir();
        gridNoivo.DataSource = Noivo.Listar();
        gridNoivo.DataBind();      
    }
    protected void btnNovo_Click(object sender, EventArgs e)
    {
        lblCodigo.Text = "-"; 
        txtAgencia.Text = "";
        txtBanco.Text = "";
        txtContaCorrente.Text = "";
        txtCPF.Text = "";
        txtDtCasamento.Text = "";
        txtEmailNoiva.Text = "";
        txtEmailNoivo.Text = "";
        txtFavorecido.Text = "";
        txtTipoCota.Text = "";
        txtMsgNoivos.Text = "";
        txtNomedosNoivos.Text = "";
        txtValor1.Text = "";
        txtValor2.Text = "";
        txtValor3.Text = "";
        txtValor4.Text = "";
        txtValor5.Text = "";
        txtCdPacote.Text = "";
    }
    protected void btnGravar_Click(object sender, EventArgs e)
    {
        Noivo nv = new Noivo();
        DateTime dtx;
        DateTime.TryParse(txtDtCasamento.Text, out dtx);
        nv.DtCasamento = dtx;
        nv.Nome_Noivos = txtNomedosNoivos.Text;
        nv.ContaCorrente = txtContaCorrente.Text;
        nv.Banco = txtBanco.Text;
        nv.Agencia = txtAgencia.Text;
        nv.Cpf = txtCPF.Text;
        nv.EmailNoivo = txtEmailNoivo.Text;
        nv.EmaiNoiva = txtEmailNoiva.Text;
        nv.Favorecido = txtFavorecido.Text;
        nv.Mensagem = txtMsgNoivos.Text;
        nv.TipoCota = txtTipoCota.Text;
        nv.Valor1 = txtValor1.Text;
        nv.Valor2 = txtValor2.Text;
        nv.Valor3 = txtValor3.Text;
        nv.Valor4 = txtValor4.Text;
        nv.Valor5 = txtValor5.Text;
        nv.CdPacote = int.Parse(txtCdPacote.Text);

        if (lblCodigo.Text == "-")
        {
            nv.Inserir();
        }
        else
        {
            nv.Codigo = int.Parse(lblCodigo.Text);
            nv.Atualizar();
        }
        gridNoivo.DataSource = Noivo.Listar();
        gridNoivo.DataBind();
        btnNovo_Click(sender, e);
    }
    protected void btnImagemPacote_Click(object sender, ImageClickEventArgs e)
    {
        
    }
    protected void btnImagemNoivo_Click(object sender, ImageClickEventArgs e)
    {
        Session["cd_noivo"] = int.Parse(((ImageButton)sender).CommandArgument);
        Response.Redirect("AdminNoivosImagens.aspx?cd_noivo=" + Session["cd_noivo"].ToString());
    }
    protected void txtDtCasamento_TextChanged(object sender, EventArgs e)
    {

    }
    protected void btnConvidados_Click(object sender, ImageClickEventArgs e)
    {
        Session["cd_noivo"] = int.Parse(((ImageButton)sender).CommandArgument.ToString());
        Response.Redirect("AdminConvidados.aspx");
    }
}