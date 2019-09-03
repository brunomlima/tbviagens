using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGravar_Click(object sender, EventArgs e)
    {
        string controle = "OK";

        EmailMkt eml = new EmailMkt();

        // Valida Nome
        if (ValidParam.ValidarParametro(txtNome.Text.Trim()) != "Digite seu nome")
        {
            eml.Nome = ValidParam.ValidarParametro(txtNome.Text);
        }
        else
        {
            lblResultado.Text = "Favor preencher o nome.";
            controle = "ERRO";
        };
        // Valida Nome em branco
        if (controle != "ERRO")
            if (ValidParam.ValidarParametro(txtNome.Text.Trim()) != "")
            {
                eml.Nome = ValidParam.ValidarParametro(txtNome.Text);
            }
            else
            {
                lblResultado.Text = "Favor preencher o nome.";
                controle = "ERRO";
            };
        // Valida se o E-mail foi preenchido
        if (controle != "ERRO")
            if (ValidParam.ValidarParametro(txtEmail.Text.Trim()) != "Digite seu e-mail")
            {
                eml.Email = ValidParam.ValidarEditor(txtEmail.Text.Trim());
                eml.Email = ValidParam.ValidarParametro(txtEmail.Text.Trim());
            }
            else
            {
                lblResultado.Text = "Favor preencher o e-mail.";
                controle = "ERRO";
            };
        if (controle != "ERRO")
            if (ValidParam.ValidarParametro(txtEmail.Text.Trim()) != "")
            {
                eml.Email = ValidParam.ValidarEditor(txtEmail.Text.Trim());
                eml.Email = ValidParam.ValidarParametro(txtEmail.Text.Trim());
            }
            else
            {
                lblResultado.Text = "Favor preencher o e-mail.";
                controle = "ERRO";
            };
        if (controle != "ERRO")
            if (ValidParam.ValidaEmail(txtEmail.Text) == false)
            {
                lblResultado.Text = "Favor preencher um e-mail válido.";
                controle = "ERRO";
            };
        // Valida se e-mail já foi cadastrado.
        if (controle != "ERRO")
            if (eml.Existe(txtEmail.Text) == true)
            {
                lblResultado.Text = "Este e-mail já esta cadastrado.";
                controle = "ERRO";
            };

        // Valida se é um humano a fazer o cadastro.
        if (controle != "ERRO")
            if (txtCaptcha.Text != Session["CaptchaValue"].ToString())
            {
                lblResultado.Text = "Favor digitar o número conforme imagem apresentada.";
                controle = "ERRO";
            };

        // Verifica se todas as verificações tiveram existo.
        if (controle == "OK")
        {
            eml.Inserir();

            Email emailfuncionario = new Email();
            //E-mail para funcionário entrar em contato com o cliente.
            emailfuncionario.enviar(  "tbviagens@tbviagens.com.br",
                                      "Webmaster",
                                      "Mais um futuro cliente..." + eml.Nome +
                                      " Código para desconto é  " + eml.Codigo.ToString(),
                                      "Solicitação de cadastro no Site TBViagens " + eml.Nome);

            Email emailcliente = new Email();
            // Envio de e-mail para o cliente com o código de desconto.
            lblResultado.Text = emailcliente.enviar(
                           eml.Email.ToString(),
                           eml.Nome.ToString(),

                           "<table width='100%' border='1' cellpadding='0' cellspacing='0'>" +
                           "  <tr bgcolor='#599100'> " +
                           "    <td> " +
                           "       <font color='#FFFFFF' size='+1'> " +
                           "            Olá " + eml.Nome + " seja bem vindo(a)" +
                           "        </font> " +
                           "    </td> " +
                           "  </tr>" +
                           "  </tr>" +
                           "    <td>" +
                           "       <table width='100%' border='0'> " +
                           "           <td>" +
                           "              Comprando um pacote de viagens receba 3% de desconto, encaminhando este e-mail para tbviagens@tbviagens.com.br <br><br> " +
                           "              Seu código promocional é : " + eml.Codigo.ToString() + "<br>" +
                           "           </td>" +
                           "       </tr>" +
                           "       </table> " +
                           "    </td>" +
                           "  </tr>" +
                           "  </tr>" +
                           "    <td>" +
                                   "<a href='http://www.tbviagens.com.br'><img src='http://www.tbviagens.com.br/img/logo_tbviagens.png' width='300' height='50'></a>" +
                           "    </td>" +
                           "  </tr>" +
                           "</table> ",
                           "Solicitação de cadastro no E-mail Maketing do Site TBViagens");
        }
    }
}