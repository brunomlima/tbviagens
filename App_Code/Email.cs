using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mail;
using System.Net.Mail;
using System.Net.Mime;
using System.IO;

public class Email
{
    private string _userName = "webmaster@tbviagens.com.br";
    private string _password = "tbv123Web";
    private string _host = "smtp.tbviagens.com.br";
    private string _remetente = "priscila@tbviagens.com.br";
    private string _nome_remetente = "Priscila Batista Barbosa";

    public string UserName { get { return _userName; } set { _userName = value; } }
    public string Password { get { return _password; } set { _password = value; } }
    public string Host { get { return _host; } set { _host = value; } }
    public string Remetente { get { return _remetente; } set { _remetente = value; } }
    public string Nome_Remetente { get { return _nome_remetente; } set { _nome_remetente = value; } }

    public Email()
	{
	}
    public string enviarAnexo(string emailDestinatario,string nomeDestinatario,string mensagem, string titulo, string caminho_anexo)
    {
        //cria objeto com dados do e-mail 
        System.Net.Mail.MailMessage objEmail = new System.Net.Mail.MailMessage();

        //remetente do e-mail 
        objEmail.From = new System.Net.Mail.MailAddress(_remetente, _nome_remetente);
        
        //destinatários do e-mail 
        System.Net.Mail.MailAddress oTo = new System.Net.Mail.MailAddress(emailDestinatario, nomeDestinatario);

        objEmail.To.Add(oTo);
        
        //prioridade do e-mail 
        objEmail.Priority = System.Net.Mail.MailPriority.Normal;

        //formato do e-mail HTML (caso não queira HTML alocar valor false) 
        objEmail.IsBodyHtml = true;

        //título do e-mail 
        objEmail.Subject = titulo.ToString();

        //corpo do e-mail 
        objEmail.Body = mensagem.ToString();
        //Para evitar problemas de caracteres "estranhos", configuramos o charset para "ISO-8859-1" 
        objEmail.SubjectEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
        objEmail.BodyEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");

        // Cria o anexo para o e-mail
        Attachment anexo = new Attachment(caminho_anexo, MediaTypeNames.Application.Pdf);

        // Anexa o arquivo a mensagem
        objEmail.Attachments.Add(anexo);



        
        //cria objeto com os dados do SMTP 
        System.Net.Mail.SmtpClient objSmtp = new System.Net.Mail.SmtpClient();

        System.Net.NetworkCredential autenticacao = new System.Net.NetworkCredential();
        autenticacao.UserName = _userName;
        autenticacao.Password = _password;
        //alocamos o endereço do host para enviar os e-mails, smtp2.locaweb.com.br 
        objSmtp.Host = _host;
        objSmtp.UseDefaultCredentials = false;
        objSmtp.Port = 587;
        objSmtp.Credentials = autenticacao;
        
        //enviamos o e-mail através do método .send() 
        try
        {
            objSmtp.Send(objEmail);
            return "E-mail enviado com sucesso! Para o e-mail " + emailDestinatario.ToString();
        }
        catch (Exception ex)
        {
            return "Ocorreram problemas no envio do e-mail. Error = " + ex.ToString();            
        }
        //excluímos o objeto de e-mail da memória 
        objEmail.Dispose(); 
    }

    public string enviar(string emailDestinatario, string nomeDestinatario, string mensagem, string titulo)
    {
        //cria objeto com dados do e-mail 
        System.Net.Mail.MailMessage objEmail = new System.Net.Mail.MailMessage();

        //remetente do e-mail 
        objEmail.From = new System.Net.Mail.MailAddress(_remetente, _nome_remetente);

        //destinatários do e-mail 
        System.Net.Mail.MailAddress oTo = new System.Net.Mail.MailAddress(emailDestinatario, nomeDestinatario);

        objEmail.To.Add(oTo);

        //prioridade do e-mail 
        objEmail.Priority = System.Net.Mail.MailPriority.Normal;

        //formato do e-mail HTML (caso não queira HTML alocar valor false) 
        objEmail.IsBodyHtml = true;

        //título do e-mail 
        objEmail.Subject = titulo.ToString();

        //corpo do e-mail 
        objEmail.Body = mensagem.ToString();
        //Para evitar problemas de caracteres "estranhos", configuramos o charset para "ISO-8859-1" 
        objEmail.SubjectEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
        objEmail.BodyEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");


        //cria objeto com os dados do SMTP 
        System.Net.Mail.SmtpClient objSmtp = new System.Net.Mail.SmtpClient();

        System.Net.NetworkCredential autenticacao = new System.Net.NetworkCredential();
        autenticacao.UserName = _userName;
        autenticacao.Password = _password;
        //alocamos o endereço do host para enviar os e-mails, smtp2.locaweb.com.br 
        objSmtp.Host = _host;
        objSmtp.UseDefaultCredentials = false;
        objSmtp.Port = 587;
        objSmtp.Credentials = autenticacao;

        //enviamos o e-mail através do método .send() 
        try
        {
            objSmtp.Send(objEmail);
            return "E-mail enviado com sucesso! Para o e-mail " + emailDestinatario.ToString();
        }
        catch (Exception ex)
        {
            return "Ocorreram problemas no envio do e-mail. Error = " + ex.ToString();
        }
        //excluímos o objeto de e-mail da memória 
        objEmail.Dispose();
    }
}

