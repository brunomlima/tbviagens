using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Sorteio : System.Web.UI.Page
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
            // Valida se e-mail já foi cadastrado.
            if (eml.Existe(txtEmail.Text) == false)
            {
                eml.Inserir();
            };            

            Email emailfuncionario = new Email();
            //E-mail para funcionário entrar em contato com o cliente.
            emailfuncionario.enviar(
                                      "tbviagens@tbviagens.com.br",
                                      "Webmaster",
                                      "Cliente se cadastrou no sorteio: " + eml.Nome +
                                      " E-mail:  " + eml.Email.ToString(),
                                      "Inscrição do Sorteio no Site TBViagens " + eml.Nome);

            Email emailcliente = new Email();
            // Envio de e-mail para o cliente com o código de desconto.
            lblResultado.Text = emailcliente.enviar(
                           eml.Email.ToString(),
                           eml.Nome.ToString(),

                           "<table width='100%' border='1' cellpadding='0' cellspacing='0'>" +
                           "  <tr bgcolor='#599100'> " +
                           "    <td> " +
                           "       <font color='#FFFFFF' size='+1'> " +
                           "            Olá " + eml.Nome + " sua inscrição foi realializada com sucesso!" +
                           "        </font> " +
                           "    </td> " +
                           "  </tr>" +
                           "  </tr>" +
                           "    <td>" +
                           "       <table width='100%' border='0'> " +
                           "           <td>" +
                           "              Boa Sorte! <br><br> " +
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
                           "Inscrição para Sorteio no Site TBViagens");
        }
    }
}