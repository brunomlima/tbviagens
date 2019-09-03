using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;

public partial class Admin_AdminEnvio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LOGADO"] == null) { Response.Redirect("Default.aspx"); };
        Pacote pc = new Pacote();
        pc.Carregar(int.Parse(Session["cd_pacote"].ToString()));
        lblResumo.Text = pc.Resumo.ToString();
        imgPacote.ImageUrl = "~\\PACOTE\\" + pc.Codigo + "\\" + pc.CaminhoImagem.ToString();
        AtualizaTela();
    }
    protected void AtualizaTela()
    {
        Session["DataEnviado"] = Envio.ListarEnviados(Session["cd_pacote"].ToString());
        gridEmailEnviado.DataSource = Envio.ListarEnviados(Session["cd_pacote"].ToString());
        gridEmailEnviado.DataBind();

        Session["DataNaoEnviado"] = Envio.ListarNaoEnviados(Session["cd_pacote"].ToString());
        gridEmailNaoEnviado.DataSource = Envio.ListarNaoEnviados(Session["cd_pacote"].ToString());
        gridEmailNaoEnviado.DataBind();

        Envio ev = new Envio();
        ev.Carregar(Session["cd_pacote"].ToString());
        lblQtdEnviado.Text = ev.QtdEnviada;
        lblQtdNAOenviado.Text = ev.QtdNAOEnviada;
    }
    protected void btnReenvia_Click(object sender, ImageClickEventArgs e)
    {
        Envio ev = new Envio();
        ev.Reenvia(((ImageButton)sender).CommandArgument.ToString(), Session["cd_pacote"].ToString());
        AtualizaTela();
      
    }
    protected void btnEnvia_Click(object sender, ImageClickEventArgs e)
    {
        Envio ev = new Envio();
        ev.Envia(((ImageButton)sender).CommandArgument.ToString(), Session["cd_pacote"].ToString());

        EmailMkt eMkt = new EmailMkt();
        eMkt.Carregar(int.Parse(((ImageButton)sender).CommandArgument.ToString()));

        Pacote pc = new Pacote();
        pc.Carregar(int.Parse(Session["cd_pacote"].ToString()));

        Email enviaEmailMkt = new Email();

        string sproblema = "<a href='http://www.tbviagens.com.br/VisualizaEmailMarketing.aspx?cd_pacote=" +Session["cd_pacote"].ToString()+"'>Acesse este link.</a>";

        //E-mail para o noivo com o comprovante enviado pelo convidado.
        enviaEmailMkt.enviar(
                                   eMkt.Email.ToString(),
                                  "TBViagens",
                                  "<body bgcolor='#E8E8E8'>" +
                                  "<table width='650' border='0' cellspacing='0' cellpadding='0' align='center'>"+
                                  "<tr>" +
                                  "<td>" +
        
                                    ShowPacote.ShowProblemaVisualizacao(pc.Codigo.ToString()) +
                                    "<table width='100%' border='1' cellpadding='0' cellspacing='0' bordercolor='#000000'>" +
                                    "  <tr bgcolor='#599100'> " +
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
                                                ShowPacote.ShowImagemPacote(pc.Codigo.ToString(),pc.CaminhoImagem.ToString())+
                                    "          </td>" +
                                    "        </tr>" +
                                    "        <tr bgcolor='#FFFFFF'>" +
                                    "          <td >" +
                                    "         Prezado Senhor(a) <b> " + eMkt.Nome.ToString() + " </b> <br>" +
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
                                    "</td>"+
                                    "</tr>"+
                                    "</table>",
                                  pc.Titulo.ToString());

        AtualizaTela();

    }
    protected void BtnEnviarEmLote_Click(object sender, EventArgs e)
    {

        DataTable dt = EmailMkt.ListarLote(txtQtdLote.Text, Session["cd_pacote"].ToString());

        for (int i = 0; i < dt.Rows.Count; i++)
        {

            Envio ev = new Envio();
            ev.Envia(dt.Rows[i]["cd_email"].ToString(), Session["cd_pacote"].ToString());

            EmailMkt eMkt = new EmailMkt();
            eMkt.Carregar(int.Parse(dt.Rows[i]["cd_email"].ToString()));

            Pacote pc = new Pacote();
            pc.Carregar(int.Parse(Session["cd_pacote"].ToString()));

            Email enviaEmailMkt = new Email();

            string sproblema = "<a href='http://www.tbviagens.com.br/VisualizaEmailMarketing.aspx?cd_pacote=" + Session["cd_pacote"].ToString() + "'>Acesse este link.</a>";

            //E-mail para o noivo com o comprovante enviado pelo convidado.
            enviaEmailMkt.enviar(
                                       eMkt.Email.ToString(),
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
                                        "         Prezado Senhor(a) <b> " + eMkt.Nome.ToString() + " </b><br>" +
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

        AtualizaTela();
    }
    protected void gridEmailNaoEnviado_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gridEmailNaoEnviado.PageIndex = e.NewPageIndex;
        gridEmailNaoEnviado.DataSource = Session["DataNaoEnviado"];
        gridEmailNaoEnviado.DataBind();        
    }
    protected void gridEmailEnviado_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gridEmailNaoEnviado.PageIndex = e.NewPageIndex;
        gridEmailNaoEnviado.DataSource = Session["DataEnviado"];
        gridEmailNaoEnviado.DataBind();     
    }
}