using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CancelamentoEmailMarketing : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGravar_Click(object sender, EventArgs e)
    {
        string controle = "OK";
        string strEmail = "";

        // Valida se o E-mail foi preenchido
        if (ValidParam.ValidarParametro(txtEmail.Text.Trim()) != "")
        {
            strEmail = ValidParam.ValidarEditor(txtEmail.Text.Trim());
            strEmail = ValidParam.ValidarParametro(txtEmail.Text.Trim());
        }
        else
        {
            lblResultado.Text = "Favor preencher o e-mail.";
            controle = "ERRO";
        };
        if (ValidParam.ValidaEmail(txtEmail.Text) == false)
        {
            lblResultado.Text = "Favor preencher um e-mail válido.";
            controle = "ERRO";
        };
        // Valida se é um humano a fazer o cadastro.
        if (txtCaptcha.Text != Session["CaptchaValue"].ToString())
        {
            lblResultado.Text = "Favor digitar o número conforme imagem apresentada.";
            controle = "ERRO";
        };

        EmailMkt eml = new EmailMkt();
        eml.CarregarPorEmail(strEmail);

        // Valida se nao existir o e-mail.
        if (eml.Existe(txtEmail.Text) == false)
        {
            lblResultado.Text = "Este e-mail já foi cancelado.";
            controle = "ERRO";
        };

        // Verifica se todas as verificações tiveram existo.
        if (controle == "OK")
        {
            eml.Excluir();
            lblResultado.Text = "O e-mail : " + eml.Email.ToString() + " foi cancelado com sucesso!";
        }
    }
}