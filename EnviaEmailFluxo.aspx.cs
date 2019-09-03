using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;

public partial class EnviaEmailFluxo : System.Web.UI.Page
{
    private int _codigo;

    protected void Page_Load(object sender, EventArgs e)
    {
        gridFluxo.DataSource = EmailFluxo.Listar();
        gridFluxo.DataBind();
    }
    protected void BtnEnviaEmails_Click(object sender, EventArgs e)
    {      
        DataTable dt =  EmailFluxo.Listar();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            EmailFluxo ef = new EmailFluxo();
            int.TryParse(dt.Rows[i]["cd_agendador"].ToString(), out _codigo);
            ef.Codigo = _codigo;
            ef.Carregar();

            Email emailcliente = new Email();
            //substitui parametro no corpo do e-mail
            string corpo;           
            corpo = dt.Rows[i]["corpo_email"].ToString().Replace("*|PNOME|*", dt.Rows[i]["nome"].ToString());
            // Envio de e-mail para o cliente
            // Email sem anexo
            if (dt.Rows[i]["anexo"].ToString() == "" )
            {
              lblResultado.Text = emailcliente.enviar( dt.Rows[i]["email"].ToString(), dt.Rows[i]["nome"].ToString(), corpo, dt.Rows[i]["titulo_email"].ToString());
            }
            // Email com anexo
            if (dt.Rows[i]["anexo"].ToString() != "")
            {
                lblResultado.Text = emailcliente.enviarAnexo( dt.Rows[i]["email"].ToString(), dt.Rows[i]["nome"].ToString(), corpo, dt.Rows[i]["titulo_email"].ToString(), dt.Rows[i]["anexo"].ToString());
            }
            ef.AtualizarStatusEmailEnviado("S", dt.Rows[i]["cd_agendador"].ToString());
            
            //Grava log de envio
            Envio ev = new Envio();
            ev.Envia(ef.Cd_Email.ToString(), ef.Cd_Pacote.ToString(), ef.Codigo.ToString());

        }
    }
}