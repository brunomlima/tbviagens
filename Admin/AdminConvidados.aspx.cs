using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AdminConvidados : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LOGADO"] == null) { Response.Redirect("Default.aspx"); };
        gridConvidados.DataSource = Convidado.ListarPorNoivo(Session["cd_noivo"].ToString());
        gridConvidados.DataBind();
    }
    protected void btnReenviarEmail_Click(object sender, ImageClickEventArgs e)
    {
       
        Noivo nv = new Noivo();
        nv.Carregar(int.Parse(Session["cd_noivo"].ToString()));

        int Codigo = int.Parse(((ImageButton)sender).CommandArgument);
        Convidado cv = new Convidado();
        cv.Carregar(Codigo);

        string vCamArq = Request.ServerVariables["APPL_PHYSICAL_PATH"] + @"\NOIVOS\" + cv.CdNoivo.ToString() + "\\COMPROVANTES" + "\\" + cv.Arquivo;


        Email emailNoivo = new Email();
        //E-mail para o noivo com o comprovante enviado pelo convidado.
        //emailNoivo.enviarAnexo("tbviagens@tbviagens.com.br",
        //                          "TBViagens",
        //                          nv.EmailNoivo.ToString(),
        //                            "<table width='100%' border='1' cellpadding='0' cellspacing='0'>" +
        //                            "  <tr bgcolor='#599100'> " +
        //                            "    <td> " +
        //                            "       <font color='#FFFFFF' size='+1'> " +
        //                            "          Olá Noivos <b> " + nv.Nome_Noivos.ToString() +
        //                            "        </font> " +
        //                            "    </td> " +
        //                            "  </tr>" +
        //                            "  <tr>" +
        //                            "    <td>" +
        //                            " <table width='100%' border='0'> " +
        //                            "  <tr>" +
        //                            "    <td>" +
        //                                    "Vocês receberam uma mensagem do seu(s) convidado(s) <b>" + cv.Nome.ToString() +
        //                            "    </td>" +
        //                            "  </tr>" +
        //                            "  <tr>" +
        //                            "    <td>" +
        //                                    "Telefone: <b>" + cv.Telefones.ToString() +
        //                            "    </td>" +
        //                            "  </tr>" +
        //                            "  <tr>" +
        //                            "    <td>" +
        //                                    "Cota escolhida: <b>" + cv.CotaEscolhida.ToString() +
        //                            "    </td>" +
        //                            "  </tr>" +
        //                            "  <tr>" +
        //                            "    <td>" +
        //                                    "Mensagem: <b>" + cv.MsgNoivos.ToString() +
        //                            "    </td>" +
        //                            "  </tr>" +
        //                            "  <tr>" +
        //                            "    <td>" +
        //                                    "Obs: <b>" + cv.Obs.ToString() +
        //                            "    </td>" +
        //                            "  </tr>" +
        //                            "  <tr>" +
        //                            "    <td> " +
        //                            "     <a href='" + ShowListadeNoivos.ShowListaNoivos(nv.Codigo.ToString()) + "'>Clique aqui para visualizar suas mensagens </a> <br>" +
        //                            "     <a href='" + ShowListadeNoivos.ShowApagaMensagem(nv.Codigo.ToString(), cv.Codigo.ToString()) + "'>Clique aqui para excluir esta mensagens da sua página personalizada. </a> " +
        //                            "    </td>" +
        //                            "  </tr>" +
        //                            "  <tr>" +
        //                            "  </table> " +
        //                            "    </td> " +
        //                            "  </tr>" +
        //                            "    <td>" +
        //                                    "<a href='http://www.tbviagens.com.br'><img src='http://www.tbviagens.com.br/img/logo_tbviagens.png' width='300' height='50'></a>" +
        //                            "    </td>" +
        //                            "  </tr>" +
        //                            "</table> ",
        //                          "Mensagem recebida de " + cv.Nome,
        //                          vCamArq);

        Email emailNoiva = new Email();
        //E-mail para a noiva com o comprovante enviado pelo convidado.
        //emailNoiva.enviarAnexo("tbviagens@tbviagens.com.br",
        //                          "TBViagens",
        //                          nv.EmaiNoiva.ToString(),
        //                          "TBViagens",
        //                            "<table width='100%' border='0' cellpadding='0' cellspacing='0'>" +
        //                            "  <tr bgcolor='#599100'> " +
        //                            "    <td> " +
        //                            "       <font color='#FFFFFF' size='+1'> " +
        //                            "          Olá Noivos <b> " + nv.Nome_Noivos.ToString() +
        //                            "        </font> " +
        //                            "    </td> " +
        //                            "  </tr>" +
        //                            "  <tr>" +
        //                            "    <td>" +
        //                            " <table width='100%' border='0'> " +
        //                            "  <tr>" +
        //                            "    <td>" +
        //                                    "Vocês receberam uma mensagem do seu(s) convidado(s) <b>" + cv.Nome.ToString() +
        //                            "    </td>" +
        //                            "  </tr>" +
        //                            "  <tr>" +
        //                            "    <td>" +
        //                                    "Telefone: <b>" + cv.Telefones.ToString() +
        //                            "    </td>" +
        //                            "  </tr>" +
        //                            "  <tr>" +
        //                            "    <td>" +
        //                                    "Cota escolhida: <b>" + cv.CotaEscolhida.ToString() +
        //                            "    </td>" +
        //                            "  </tr>" +
        //                            "  <tr>" +
        //                            "    <td>" +
        //                                    "Mensagem: <b>" + cv.MsgNoivos.ToString() +
        //                            "    </td>" +
        //                            "  </tr>" +
        //                            "  <tr>" +
        //                            "    <td>" +
        //                                    "Obs: <b>" + cv.Obs.ToString() +
        //                            "    </td>" +
        //                            "  </tr>" +
        //                            "  <tr>" +
        //                            "    <td> " +
        //                            "     <a href='" + ShowListadeNoivos.ShowListaNoivos(nv.Codigo.ToString()) + "'>Clique aqui para visualizar suas mensagens </a> <br> " +
        //                            "     <a href='" + ShowListadeNoivos.ShowApagaMensagem(nv.Codigo.ToString(), cv.Codigo.ToString()) + "'>Clique aqui para excluir esta mensagens da sua página personalizada. </a> " +
        //                            "    </td>" +
        //                            "  </tr>" +
        //                            "  <tr>" +
        //                            "  </table> " +
        //                            "    </td> " +
        //                            "  </tr>" +
        //                            "    <td>" +
        //                                    "<a href='http://www.tbviagens.com.br'><img src='http://www.tbviagens.com.br/img/logo_tbviagens.png' width='300' height='50'></a>" +
        //                            "    </td>" +
        //                            "  </tr>" +
        //                            "</table> ",
        //                          "Mensagem recebida de " + cv.Nome,
        //                          vCamArq);

        lblResultado.Text = "E-mail enviado com sucesso!";

    }
    protected void btnExcluir_Click(object sender, ImageClickEventArgs e)
    {
        int Codigo = int.Parse(((ImageButton)sender).CommandArgument);
        Convidado cv = new Convidado();
        cv.Codigo = Codigo;
        cv.Excluir();
        gridConvidados.DataSource = Convidado.ListarPorNoivo(Session["cd_noivo"].ToString());
        gridConvidados.DataBind();     
    }
}