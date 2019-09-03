using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LOGADO"] != null) { Response.Redirect("Default.aspx"); };   
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        LoginSite lg = new LoginSite();
        lg.Senha = ValidParam.ValidarParametro(txtSenha.Text);
        lg.Login = ValidParam.ValidarParametro(txtLogin.Text);
        if (lg.Senha != "")
        {
            if (lg.Valida() == true)
            {
                Session["LOGADO"] = lg.Nome;
                Session["CPF"] = lg.Login;
                Session["cd_usuario"] = lg.Codigo;
                lblResultado.Text = lg.Nome;
                Response.Redirect("AreaRestrita.aspx");               
            }
            else
            {
                lblResultado.Text = "Erro ao efetuar o login";
            }
        }
        else
        {
            lblResultado.Text = "Erro ao efetuar o login informe uma senha.";
        }
    }
}