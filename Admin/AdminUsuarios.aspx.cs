using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AdminUsuarios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LOGADO"] == null) { Response.Redirect("Default.aspx"); };
        gridUsuario.DataSource = Usuario.Listar();
        gridUsuario.DataBind();
    }
    protected void btnNovo_Click(object sender, EventArgs e)
    {
        txtSkype.Text = "";
        txtCpf.Text = "";
        txtEmail.Text = "";
        txtNome.Text = "";
        txtSenha.Text = "";
        txtStatus.Text = "";
        txtCargo.Text = "";
        lblCodigo.Text = "-";
    }
    protected void btnGravar_Click(object sender, EventArgs e)
    {
        Usuario us = new Usuario();
        us.Cpf = ValidParam.ValidarParametro(txtCpf.Text.Trim());
        us.Senha = ValidParam.ValidarParametro(txtSenha.Text.Trim());
        us.Email = ValidParam.ValidarParametro(txtEmail.Text.Trim());
        us.Nome = ValidParam.ValidarParametro(txtNome.Text.Trim());
        us.Status = ValidParam.ValidarParametro(txtStatus.Text.Trim());
        us.Skype = ValidParam.ValidarParametro(txtSkype.Text.Trim());
        us.Cargo = ValidParam.ValidarParametro(txtCargo.Text.Trim());

        if (lblCodigo.Text == "-")
        {
            us.Inserir();
        }
        else
        {
            us.Codigo = int.Parse(lblCodigo.Text);
            if (us.Status == "A")
            {
                Email em = new Email();
                lblResultado.Text = em.enviar(
                                    us.Email,
                                    us.Nome,
                                     "Olá " + us.Nome + " seja bem vindo" +
                                     "<br> <br>  Seu login é : " + us.Cpf + " e sua senha é : " + us.Senha +
                                     "<br> <br> <a href='http://www.tbviagens.com.br/Admin/Default.aspx'>Clique aqui para efetuar o login</a> ",
                                    "Ativação do Login no Site TBViagens " + us.Nome);
            };
            us.Atualizar();
        }
        gridUsuario.DataSource = Usuario.Listar();
        gridUsuario.DataBind();
        btnNovo_Click(sender, e);
    }
    protected void btnAcessos_Click1(object sender, ImageClickEventArgs e)
    {
        Session["cd_usuario"] = int.Parse(((ImageButton)sender).CommandArgument.ToString());
        Response.Redirect("AdminAcessos.aspx");
    }
    protected void btnAlterar_Click(object sender, ImageClickEventArgs e)
    {
        int codigo = int.Parse(((ImageButton)sender).CommandArgument.ToString());
        Usuario us = new Usuario();
        if (us.Carregar(codigo))
        {
            lblCodigo.Text = codigo.ToString();
            txtNome.Text = us.Nome.ToString();
            txtCpf.Text = us.Cpf.ToString();
            txtSenha.Text = us.Senha.ToString();
            txtEmail.Text = us.Email.ToString();
            txtSkype.Text = us.Skype.ToString();
            txtStatus.Text = us.Status.ToString();
            txtCargo.Text = us.Cargo.ToString();
        }
        else
        {
            btnNovo_Click(sender, e);
        }
    }
    protected void btnExcluir_Click(object sender, ImageClickEventArgs e)
    {
        int Codigo = int.Parse(((ImageButton)sender).CommandArgument);
        Usuario us = new Usuario();
        us.Codigo = Codigo;
        us.Excluir();
        gridUsuario.DataSource = Usuario.Listar();
        gridUsuario.DataBind();       
    }
    protected void gridUsuario_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}