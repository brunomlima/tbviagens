using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BrunoMedeirosLima_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string controle = "OK";

        EmailMkt eml = new EmailMkt();

        // Valida Nome
        if (ValidParam.ValidarParametro(txtNomeCompleto.Text.Trim()) != "Digite seu nome")
        {
            eml.Nome = ValidParam.ValidarParametro(txtNomeCompleto.Text);
        }
        else
        {
            lblResultado.Text = "Favor preencher o nome.";
            controle = "ERRO";
        };
        // Valida Nome em branco
        if (controle != "ERRO")
            if (ValidParam.ValidarParametro(txtNomeCompleto.Text.Trim()) != "")
            {
                eml.Nome = ValidParam.ValidarParametro(txtNomeCompleto.Text);
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

        // Verifica se todas as verificações tiveram existo.
        if (controle == "OK")
        {
            //eml.Inserir();

            EmailBruno emailfuncionario = new EmailBruno();
            //E-mail para funcionário entrar em contato com o cliente.
            emailfuncionario.enviar("bruno@tbviagens.com.br",
                                      "Bruno",
                                      " Nome: " + txtNomeCompleto.Text +"<br>"+
                                      " Telefone: " + txtTelefone.Text + "<br>" +
                                      " Email: " + txtEmail.Text + "<br>" +
                                      " Mensagem: "+ txtMensagem.Text+ "<br>",
                                      " Nome do contato: " + eml.Nome);

            EmailBruno emailcliente = new EmailBruno();
            // Envio de e-mail para o cliente com o código de desconto.
            lblResultado.Text = emailcliente.enviar(
                           eml.Email.ToString(),
                           eml.Nome.ToString(),
                           "<table width='100%' border='1' cellpadding='0' cellspacing='0'>" +
                           "  <tr bgcolor='#599100'> " +
                           "    <td> " +
                           "       <font color='#FFFFFF' size='+1'> " +
                           "            Olá, Senhor(a) " + eml.Nome + " Muito obrigado por entrar em contato" +
                           "        </font> " +
                           "    </td> " +
                           "  </tr>" +
                           "  </tr>" +
                           "    <td>" +
                           "       <table width='100%' border='0'> " +
                           "           <td>" +
                           "              Seu e-mail será respondido assim que possível." +
                           "           </td>" +
                           "       </tr>" +
                           "       </table> " +
                           "    </td>" +
                           "  </tr>" +
                           "  </tr>" +
                           "    <td>" +
                           "    </td>" +
                           "  </tr>" +
                           "</table> ",
                           "Solicitação com Bruno Medeiros Lima");
            txtEmail.Text = "";
            txtMensagem.Text = "";
            txtNomeCompleto.Text = "";
            txtTelefone.Text = "";

        }
    }
}