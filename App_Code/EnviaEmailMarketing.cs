using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

/// <summary>
/// Summary description for EnviaEmailMarketing
/// </summary>
[WebService(Namespace = "http://www.tbviagens.com.br/WebService", Name = "EnviaEmailMarketing", Description = "Web Service de Envio de E-mail")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class EnviaEmailMarketing : System.Web.Services.WebService {

    public EnviaEmailMarketing () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        
        return "Hello World";
    }
    [WebMethod]
    public string Soma(int a, int b)
    {
        int r;
        r = a + b;
        return r.ToString() ;
    }

    [WebMethod]
    public string ConsultaQtdEmailEnviado(int codigoPacote)
    {

        int qtd = EmailMkt.ContaEmailEnviado(codigoPacote);

        return qtd.ToString();
    }

    [WebMethod]
    public string ConsultanNomedoPacote(int codigoPacote)
    {
        DataTable dt = EmailMkt.ConsultaDescricao(codigoPacote);
        string NomePacote = "";
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            NomePacote = dt.Rows[i]["titulo"].ToString();
        }
        return NomePacote;
    }
    [WebMethod]
    public string ConsultaQtdEmailNaoEnviado(int codigoPacote)
    {

        int qtd = EmailMkt.ContaEmailNaoEnviado(codigoPacote);

        return qtd.ToString();
    }

    [WebMethod]
    public string EnviaEmailPacote(int codigoPacote,string qtdEmail)
    {
        DataTable dt = EmailMkt.ListarLote(qtdEmail, codigoPacote.ToString());

        for (int i = 0; i < dt.Rows.Count; i++)
        {

            Envio ev = new Envio();
            ev.Envia(dt.Rows[i]["cd_email"].ToString(), codigoPacote.ToString());

            EmailMkt eMkt = new EmailMkt();
            eMkt.Carregar(int.Parse(dt.Rows[i]["cd_email"].ToString()));

            Pacote pc = new Pacote();
            pc.Carregar(int.Parse(codigoPacote.ToString()));

            Email enviaEmailMkt = new Email();

            string sproblema = "<a href='http://www.tbviagens.com.br/VisualizaEmailMarketing.aspx?cd_pacote=" + codigoPacote.ToString() + "'>Acesse este link.</a>";

            //E-mail para o noivo com o comprovante enviado pelo convidado.
            enviaEmailMkt.enviar(     eMkt.Email.ToString(),
                                      "TBViagens",
                                      "<body bgcolor='#E8E8E8'>" +
                                      "<table width='650' border='0' cellspacing='0' cellpadding='0' align='center'>" +
                                      "<tr>" +
                                      "<td>" +

                                        ShowPacote.ShowProblemaVisualizacao(pc.Codigo.ToString()) +
                                        "<table width='100%' border='1' cellpadding='0' cellspacing='0' bordercolor='#000000'>" +
                                        "  <tr bgcolor='#599100'> " +
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
                                        "         Olá, <b> " + eMkt.Nome.ToString() + " </b><br>" +
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
        }

        return codigoPacote.ToString();
    }
}
