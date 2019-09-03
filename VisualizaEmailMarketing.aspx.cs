using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VisualizaEmailMarketing : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Pacote pc = new Pacote();
        pc.Carregar(int.Parse(Request.QueryString["CD_PACOTE"].ToString()));
        lblTitulo.Text = pc.Titulo.ToString();
        lblResumo.Text = pc.Resumo.ToString();
        imgPacote.ImageUrl = "~\\PACOTE\\" + pc.Codigo + "\\" + pc.CaminhoImagem.ToString();
        Session["cd_pacote"] = Request.QueryString["CD_PACOTE"].ToString();

    }
    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        Pacote pc = new Pacote();
        pc.Carregar(int.Parse(Session["CD_PACOTE"].ToString()));

        Email enviaEmailMkt = new Email();

        string sproblema = "<a href='http://www.tbviagens.com.br/VisualizaEmailMarketing.aspx?cd_pacote=" + Session["cd_pacote"].ToString() + "'>Acesse este link.</a>";

        //E-mail para o noivo com o comprovante enviado pelo convidado.
        enviaEmailMkt.enviar(      txtEmail.Text,
                                  "TBViagens",
                                  "<body bgcolor='#E8E8E8'>" +
                                  "<table width='650' border='0' cellspacing='0' cellpadding='0' align='center'>" +
                                  "<tr>" +
                                  "<td>" +

                                    ShowPacote.ShowProblemaVisualizacao(pc.Codigo.ToString()) +
                                    "<table width='100%' border='1' cellpadding='0' cellspacing='0' bordercolor='#000000'>" +
                                    "  <tr bgcolor='#84c226'> " +
                                    "    <td align='center'> " +
                                    "       <font color='#FFFFFF' size='+2'> " +
                                                pc.Titulo.ToString() +
                                    "        </font> " +
                                    "    </td> " +
                                    "  </tr>" +
                                    "  <tr bgcolor='#3bb3c2'> " +
                                    "    <td align='center'> " +
                                    "       <font color='#FFFFFF' size='+2'> " +
                                                pc.Resumo.ToString() +
                                    "        </font> " +
                                    "    </td> " +
                                    "  </tr>" +
                                    "  <tr>" +
                                    "    <td>" +
                                    "      <table width='100%' border='0'> " +
                                    "        <tr bgcolor='#FFFFFF'>" +
                                    "          <td align='center'>" +
                                                ShowPacote.ShowImagemPacote(pc.Codigo.ToString(), pc.CaminhoImagem.ToString()) +
                                    "          </td>" +
                                    "        </tr>" +
                                    "        <tr bgcolor='#FFFFFF'>" +
                                    "          <td >" +
                                    "         Olá, <b> NOME DO CLIENTE </b><br>" +
                                                pc.Detalhe.ToString() +
                                    "          </td>" +
                                    "        </tr>" +
                                    "      </table> " +
                                    "    </td> " +
                                    "  </tr>" +
                                    "  <tr bgcolor='#FFFFFF'>" +
                                    "    <td align='center' >" +
                                    "       <a href='http://www.tbviagens.com.br'><img src='http://www.tbviagens.com.br/img/logo_tbviagens.png' width='300' height='50'></a><br>" +
                                    "       <span class='style2'><a href='http://www.tbviagens.com.br'>www.tbviagens.com.br</a></span><br>" +
                                    "       <span class='style1'><strong>(11) 2305-3530</strong></span>" +
                                    "    </td>" +
                                    "  </tr>" +
                                    "</table> " +
                                     "<font size='1'> Não deseja mais receber nossas mensagens? <a href='http://www.tbviagens.com.br/CancelamentoEmailMarketing.aspx'>Acesse este link.</a> </font>" +
                                    "</td>" +
                                    "</tr>" +
                                    "</table>",
                                  pc.Titulo.ToString());

        txtEmail.Text = "";
    }
}