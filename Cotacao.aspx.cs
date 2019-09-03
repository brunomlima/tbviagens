using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cotacao : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["ORIGEM"])) txtOrigem.Text = Request.QueryString["ORIGEM"].ToString();
        if (!string.IsNullOrEmpty(Request.QueryString["DESTINO"])) txtDestino.Text = Request.QueryString["DESTINO"].ToString();
        if (!string.IsNullOrEmpty(Request.QueryString["DTP"])) txtDtPartida_CalendarExtender.SelectedDate = Convert.ToDateTime(Request.QueryString["DTP"].ToString());
        if (!string.IsNullOrEmpty(Request.QueryString["DTR"])) txtDtRegresso_CalendarExtender.SelectedDate = Convert.ToDateTime(Request.QueryString["DTR"].ToString());

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
            lblResultado.Text = "Favor preencher o nome.";
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
        // Valida Origem
        if (controle != "ERRO")
            if (ValidParam.ValidarParametro(txtOrigem.Text.Trim()) != "")
            {
                txtOrigem.Text = ValidParam.ValidarParametro(txtOrigem.Text);
            }
            else
            {
                lblResultado.Text = "Favor preencher a origem.";
                controle = "ERRO";
            };
        // Valida Destino
        if (controle != "ERRO")
            if (ValidParam.ValidarParametro(txtDestino.Text.Trim()) != "")
            {
                txtDestino.Text = ValidParam.ValidarParametro(txtDestino.Text);
            }
            else
            {
                lblResultado.Text = "Favor preencher o destino.";
                controle = "ERRO";
            };
        // Valida Número de Adultos
        if (controle != "ERRO")
            if (ValidParam.ValidarParametro(txtNumeroAdultos.Text.Trim()) != "")
            {
                if (ValidParam.ValidarInteiroPositivo(txtNumeroAdultos.Text.Trim()) != false)
                {
                    txtNumeroAdultos.Text = ValidParam.ValidarParametro(txtNumeroAdultos.Text);
                }
                else
                {
                    lblResultado.Text = "Favor preencher o número de adultos.";
                    controle = "ERRO";
                };
            }
            else
            {
                lblResultado.Text = "Favor preencher o número de adultos.";
                controle = "ERRO";
            };
        // Valida Número de Crianças
        if (controle != "ERRO")
            if (ValidParam.ValidarParametro(txtNumeroCriancas.Text.Trim()) != "")
            {
                if (ValidParam.ValidarInteiroPositivo(txtNumeroCriancas.Text.Trim()) != false)
                {
                    txtNumeroCriancas.Text = ValidParam.ValidarParametro(txtNumeroCriancas.Text);
                }
                else
                {
                    lblResultado.Text = "Favor preencher o número de crianças (até 12 anos).";
                    controle = "ERRO";
                };
            }
            else
            {
                lblResultado.Text = "Favor preencher o número de crianças (até 12 anos).";
                controle = "ERRO";
            };
        // Valida Data de Partida
        if (controle != "ERRO")
            if (ValidParam.ValidarParametro(txtDtPartida.Text.Trim()) != "")
            {
                txtDtPartida.Text = ValidParam.ValidarParametro(txtDtPartida.Text);
            }
            else
            {
                lblResultado.Text = "Favor preencher a data de partida.";
                controle = "ERRO";
            };
        // Valida Data de Regresso
        if (controle != "ERRO")
            if (ValidParam.ValidarParametro(txtDtRegresso.Text.Trim()) != "")
            {
                txtDtRegresso.Text = ValidParam.ValidarParametro(txtDtRegresso.Text);
            }
            else
            {
                lblResultado.Text = "Favor preencher a data de regresso.";
                controle = "ERRO";
            };
        //Verifica se a data de partida é menor do que a de regresso
        if (controle != "ERRO")
            if (Convert.ToDateTime(txtDtRegresso.Text.Trim()) < Convert.ToDateTime(txtDtPartida.Text.Trim()))
            {
                lblResultado.Text = "Favor preencher a data de regresso maior que a data de partida.";
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
            ShowMessage.conversaoGoogle(this);

            Email emailfuncionario = new Email();
            //E-mail para funcionário entrar em contato com o cliente.
            emailfuncionario.enviar(
                                      "tbviagens@tbviagens.com.br",
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
                                                "LIGAR PARA O CLIENTE" +
                                        "    </td>" +
                                        "  </tr>" +
                                        "  <tr>" +
                                      "<hr>" +
                                      "<b>Dados Pessoais</b><br/>" +
                                      "Nome Completo: " + txtNomeCompleto.Text + "<br/>" +
                                      "E-mail: " + txtEmail.Text + "<br/>" +
                                      "Telefone: " + txtCelular.Text + "<br/>" +
                                      "<hr>" +
                                      "<b>Dados da Viagem</b><br/>" +
                                      "Origem: " + txtOrigem.Text + "<br/>" +
                                      "Destino: " + txtDestino.Text + "<br/>" +
                                      "Número de Adultos: " + txtNumeroAdultos.Text + "<br/>" +
                                      "Número de Crianças: " + txtNumeroCriancas.Text + "<br/>" +
                                      "Data da Partida: " + txtDtPartida.Text + "<br/>" +
                                      "Data de Regresso: " + txtDtRegresso.Text + "<br/>" +
                                      "Observação: " + txtObs.Text + "<br/>" +
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

            Email emailcliente = new Email();
            // Envio de e-mail para o cliente
            lblResultado.Text = emailcliente.enviar(
                           txtEmail.Text,
                           txtNomeCompleto.Text,
                                        "<table width='100%' border='1' cellpadding='0' cellspacing='0'>" +
                                        "  <tr bgcolor='#599100'> " +
                                        "    <td> " +
                                        "       <font color='#FFFFFF' size='+1'> " +
                                        "           Olá <b>" + txtNomeCompleto.Text + "! </b>" +
                                        "        </font> " +
                                        "    </td> " +
                                        "  </tr>" +
                                        "  <tr>" +
                                        "    <td>" +
                                        " <table width='100%' border='0'> " +
                                        "  <tr>" +
                                        "    <td>" +
                                        "<br/>" +
                                        " Meu nome é Priscila, faço parte da <b>TBViagens</b> e fiquei muito feliz pelo seu contato. :) </b><br/><br/>" +
                                        " Estou lhe escrevendo apenas para dizer que recebemos a sua solicitação, tá legal?<br/><br/>" +
                                        " Já estou organizando tudo aqui e dentro de algumas horas você receberá um novo e-mail meu já com a cotação.<br/><br/>" +
                                        " Até lá, acompanhe a gente nas redes sociais: <a href='https://www.facebook.com/tbviagens'> Facebook</a>, <a href='https://www.youtube.com/channel/UC-tTX62jaV8wH7fx-kp7A0g'>Youtube</a> e <a href='https://www.instagram.com/tbviagens/'>Instagram</a>! <br/><br/>" +
                                        " Um abraço <br/><br/><br/>" +
                                        " Priscila " +

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
                                        "</table> ",
                            "Cotação de Pacote Turístico Solicitada a TBViagens em " + DateTime.Today.ToString("dd/MM/yyyy"));


            // Grava cliente na base de dados.
            EmailMkt eml = new EmailMkt();
            eml.Email = txtEmail.Text;
            eml.Nome = txtNomeCompleto.Text;
            if (eml.Existe(txtEmail.Text) != true)
            {
                eml.Inserir();
            };

            lblResultado.Text = "Cotação enviada com sucesso!";
            Session["nome_cliente"] = txtNomeCompleto.Text;
            Response.Redirect("obrigado.aspx");
        }
    }
}