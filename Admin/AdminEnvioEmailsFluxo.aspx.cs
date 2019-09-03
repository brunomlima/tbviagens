using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;

public partial class Admin_AdminEnvioEmailsFluxo : System.Web.UI.Page
{
    private int _codigo;

    protected void Page_Load(object sender, EventArgs e)
    {
        gridFluxo.DataSource = EmailFluxo.Listar();
        gridFluxo.DataBind();
    }
    protected void BtnEnviaEmails_Click(object sender, EventArgs e)
    {
        DataTable dt = EmailFluxo.Listar();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            EmailFluxo ef = new EmailFluxo();
            int.TryParse(dt.Rows[i]["cd_agendador"].ToString(), out _codigo);
            ef.Codigo = _codigo;
            ef.Carregar();
            ef.AtualizarStatusEmailEnviado("S", dt.Rows[i]["cd_agendador"].ToString());

            Email emailcliente = new Email();
            //substitui parametro no corpo do e-mail
            string corpo;
            corpo = "";
            // PNOME
            corpo = dt.Rows[i]["corpo_email"].ToString().Replace("*|PNOME|*", dt.Rows[i]["nome"].ToString());
            // PIMAGEM
            if (dt.Rows[i]["imagem"].ToString() != "")
            {
                corpo = corpo.ToString().Replace("*|PIMAGEM|*", "<img src='http://www.tbviagens.com.br//pacote//" + dt.Rows[i]["cd_pacote"].ToString() + "//" + dt.Rows[i]["imagem"].ToString() + "'>");
            }
            else
            { 
                corpo = corpo.ToString().Replace("*|PIMAGEM|*", "");
            }
         
            // Envia e-mail sem anexo
            if (dt.Rows[i]["anexo"].ToString() == "")
            {
                lblResultado.Text = emailcliente.enviar(dt.Rows[i]["email"].ToString(), dt.Rows[i]["nome"].ToString(), corpo, dt.Rows[i]["titulo_email"].ToString());
            }
            // Envia e-mail com anexo
            if (dt.Rows[i]["anexo"].ToString() != "")
            {
                lblResultado.Text = emailcliente.enviarAnexo(dt.Rows[i]["email"].ToString(), dt.Rows[i]["nome"].ToString(), corpo, dt.Rows[i]["titulo_email"].ToString(), Request.ServerVariables["APPL_PHYSICAL_PATH"] + @"pacote\" + dt.Rows[i]["cd_pacote"].ToString() + "\\" + dt.Rows[i]["anexo"].ToString());
            }
           //Grava log de envio
           Envio ev = new Envio();
           ev.Envia(dt.Rows[i]["cd_email"].ToString(), dt.Rows[i]["cd_pacote"].ToString(),dt.Rows[i]["cd_agendador"].ToString());

        }
    }
}