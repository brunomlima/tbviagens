using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Design;
using System.IO;

public partial class Admin_AdminEmailImagens : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["LOGADO"] == null) { Response.Redirect("Default.aspx"); };

            FluxoEmails ef = new FluxoEmails();
            ef.Carregar(int.Parse(Request.QueryString["cd_fluxo_emails"].ToString()));
            lblTitulo.Text = ef.Titulo.ToString();
            lblcaminhodaimagem.Text = ef.Imagem;
            ImgPacote.ImageUrl = "~\\PACOTE\\" + Request.QueryString["CD_PACOTE"].ToString() + "\\" + ef.Imagem.ToString();
        }
    }

    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        lblMensagem.Text = "";
        lblMensagem.Visible = false;
        if (!ValidaTamanhodaImagem(FileUploadImagem.PostedFile.InputStream, 600, 400))
        {
            lblMensagem.Visible = true;
            lblMensagem.Text = "Tamanho da imagem fora do padrão - Utilize uma imagem 600px x 400px ";
            return;
        }
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
            ef.Imagem = FileUploadImagem.FileName;
            ef.AtualizarImagem(); 

            //Salvando o arquivo com o nome original
            this.FileUploadImagem.PostedFile.SaveAs(vCamArq);

        }
        Response.Redirect("AdminEmailImagens.aspx?cd_pacote=" + Request.QueryString["CD_PACOTE"].ToString() + "&cd_fluxo_emails=" + Request.QueryString["cd_fluxo_emails"].ToString());
    }

    private Boolean ValidaTamanhodaImagem(Stream streamImage, int maxWidth, int maxHeight)
    {
        Boolean tamanhoIdeal = false;
        Bitmap originalImage = new Bitmap(streamImage);
        if ((maxWidth == originalImage.Width) && (maxHeight == originalImage.Height))
        {
            tamanhoIdeal = true;
        }
        return tamanhoIdeal;
    }

}