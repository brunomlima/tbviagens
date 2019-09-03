using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PacoteEspecial : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void BtnCotacao_Click(object sender, EventArgs e)
    {
        string controle = "OK";
        string nome_completo = "";
        string email;

        // Valida Nome
        if (ValidParam.ValidarParametro(txtNomeCompleto.Text.Trim()) != "")
        {
            nome_completo = ValidParam.ValidarParametro(txtNomeCompleto.Text);
        }
        else
        {
            lblResultado.Text = "Favor preencher o nome ou apelido.";
            controle = "ERRO";
        };
        // Valida se o E-mail foi preenchido
        if (controle != "ERRO")
            if (ValidParam.ValidarParametro(txtEmail.Text.Trim()) != "")
            {
                email = ValidParam.ValidarEditor(txtEmail.Text.Trim());
                email = ValidParam.ValidarParametro(email);
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
        // Valida Telefone
        if (controle != "ERRO")
            if (ValidParam.ValidarParametro(txtCelular.Text.Trim()) != "")
            {
                txtCelular.Text = ValidParam.ValidarParametro(txtCelular.Text);
            }
            else
            {
                lblResultado.Text = "Favor preencher o telefone.";
                controle = "ERRO";
            };
        // Verifica se todas as verificações tiveram existo.
        if (controle == "OK")
        {
            ShowMessage.conversaoGoogle(this);

            Session["nome_cliente"] = txtNomeCompleto.Text;

            Email emailfuncionario = new Email();
            //E-mail para funcionário entrar em contato com o cliente.
            emailfuncionario.enviar("tbviagens@tbviagens.com.br",
                                      "Webmaster",

                                        "<table width='100%' border='1' cellpadding='0' cellspacing='0'>" +
                                        "  <tr bgcolor='#599100'> " +
                                        "    <td> " +
                                        "       <font color='#FFFFFF' size='+1'> " +
                                        "           O senhor(a) <b> " + txtNomeCompleto.Text + "</b> solita uma cotação do pacote " +
                                        "        </font> " +
                                        "    </td> " +
                                        "  </tr>" +
                                        "  <tr>" +
                                        "    <td>" +
                                        " <table width='100%' border='0'> " +
                                        "  <tr>" +
                                        "    <td align='center'>" +
                                                "Lead ativado" +
                                        "    </td>" +
                                        "  </tr>" +
                                        "  <tr>" +
                                      "<hr>" +
                                      "<b>Dados Pessoais</b><br/>" +
                                      "Nome Completo: " + txtNomeCompleto.Text + "<br/>" +
                                      "E-mail: " + txtEmail.Text + "<br/>" +
                                      "Telefone: " + txtCelular.Text + "<br/>" +
                                      "<hr>" +
                                        "    </td>" +
                                        "  </tr>" +
                                        "  </table> " +
                                        "    </td> " +
                                        "  </tr>" +
                                        "    <td align='center'>" +
                                        "      <a href='http://www.tbviagens.com.br'><img src='http://www.tbviagens.com.br/img/logo_tbviagens.png' width='300' height='50'></a> <br/>" +
                                        "      <span class='style2'><a href='http://www.tbviagens.com.br'>www.tbviagens.com.br</a></span><br/>" +
                                        "      <span class='style1'><strong>(11) 2305-3530</strong></span></td>" +
                                        "    </td>" +
                                        "  </tr>" +
                                        "</table> "
                                        , "Cotação WEB : " + txtNomeCompleto.Text + " " + txtCelular.Text);



            // Grava cliente na base de dados.
            EmailMkt eml = new EmailMkt();
            eml.Email = txtEmail.Text;
            eml.Nome = txtNomeCompleto.Text;
            if (eml.Existe(txtEmail.Text) != true)
            {
                eml.Inserir();
            };
            
            
            EmailFluxo ef = new EmailFluxo();
            ef.Cd_Email = eml.Codigo;
            ef.Cd_Pacote = int.Parse(Request.QueryString["CD_PACOTE"].ToString());
            if (ef.Valida() == false)
            {
                ef.InserirNoAgendador();
           
                if (ef.Carregar())
                {
                    Email emailcliente = new Email();
                    // Envio de e-mail para o cliente
                    string corpo;
                    corpo = "";
                    // PNOME
                    corpo = ef.Corpo_Email.ToString().Replace("*|PNOME|*", txtNomeCompleto.Text);
                    lblResultado.Text = emailcliente.enviar(txtEmail.Text, txtNomeCompleto.Text, corpo, ef.Titulo_Email);
                    ef.AtualizarStatusEmailEnviado("S",ef.Codigo.ToString());
                    //Grava log de envio
                    Envio ev = new Envio();
                    ev.Envia(ef.Cd_Email.ToString(), ef.Cd_Pacote.ToString(), ef.Codigo.ToString());
                };

            }
            lblResultado.Text = "Cotação enviada com sucesso!";

            Response.Redirect("obrigado.aspx");
        }
    }
}