using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_RecuperandoLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnEnviarEmail_Click(object sender, EventArgs e)
    {
        Usuario us = new Usuario();
        us.Carregar(ValidParam.ValidarParametro(txtLogin.Text));
        if (us.Senha != "")
        {
            if (us.Status != "I")
            {
                Email em = new Email();
                lblResultado.Text = em.enviar(us.Email.ToString(),
                                              us.Nome.ToString(),

                                              "<table width='100%' border='1' cellpadding='0' cellspacing='0'>" +
                                            "  <tr bgcolor='#599100'> " +
                                            "    <td> " +
                                            "       <font color='#FFFFFF' size='+1'> " +
                                            "          Olá <b> " + us.Nome +
                                            "        </font> " +
                                            "    </td> " +
                                            "  </tr>" +
                                            "  <tr> " +
                                            "    <td> " +
                                            "       <table width='100%' border='0'> " +
                                            "           <tr> " +
                                            "           <td> " +
                                            "               <br>  Seu login é : " + us.Cpf + " e sua senha é : " + us.Senha +
                                            "               <br> <br> <a href='http://www.tbviagens.com.br/Admin/Default.aspx'>Clique aqui para efetuar o login</a> " +
                                            "           </td> " +
                                            "           </tr>" +
                                            "       </table> " +
                                            "    </td> " +
                                            "  </tr>" +
                                            "  <tr> " +
                                            "    <td> " +
                                            "      <a href='http://www.tbviagens.com.br'><img src='http://www.tbviagens.com.br/img/logo_tbviagens.png' width='300' height='50'></a>" +
                                            "    </td> " +
                                            "  </tr>" +
                                            "</table> ",
                                              "Recuperando Login no Site TBViagens");
            }
            else
            {
                lblResultado.Text = "Usuário Inativo";
            }

        }
        else
        {
            lblResultado.Text = "CPF não encontrado";
        }
    }
}