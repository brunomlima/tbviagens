using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AdminEmailAnexo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LOGADO"] == null) { Response.Redirect("Default.aspx"); };

        FluxoEmails ef = new FluxoEmails();
        ef.Carregar(int.Parse(Request.QueryString["cd_fluxo_emails"].ToString()));
        lblTitulo.Text = ef.Titulo.ToString();
        lblcaminhodaimagem.Text = ef.Anexo;
    }
    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        if (this.FileUploadImagem.PostedFile.ContentLength != 0 && this.FileUploadImagem.HasFile)
        {
            //capturando nome original do arquivo
            string fileName = this.FileUploadImagem.FileName;
            //capturando extensão do arquivo postado
            string extension = System.IO.Path.GetExtension(fileName);
            //Se existir o diretorio entao exclui e cria um novo sem imagem.
            string DiretorioPacote = Request.ServerVariables["APPL_PHYSICAL_PATH"] + @"PACOTE\" + Request.QueryString["CD_PACOTE"].ToString();
            //Cria diretório com o código.
            System.IO.Directory.CreateDirectory(DiretorioPacote);
            string vCamArq = DiretorioPacote + "\\" + fileName;
            // Atualizar campo no fluxo do e-mail
            FluxoEmails ef = new FluxoEmails();
            ef.Carregar(int.Parse(Request.QueryString["cd_fluxo_emails"].ToString()));
            ef.Anexo = FileUploadImagem.FileName;
            ef.AtualizarAnexo();

            //Salvando o arquivo com o nome original
            this.FileUploadImagem.PostedFile.SaveAs(vCamArq);

        }
        Response.Redirect("AdminEmailAnexo.aspx?cd_pacote=" + Request.QueryString["CD_PACOTE"].ToString() + "&cd_fluxo_emails=" + Request.QueryString["cd_fluxo_emails"].ToString());
    }
}