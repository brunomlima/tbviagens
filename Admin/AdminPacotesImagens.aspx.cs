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

public partial class Admin_AdminPacotesImagens : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["LOGADO"] == null) { Response.Redirect("Default.aspx"); };
            Pacote pc = new Pacote();
            pc.Carregar(int.Parse(Request.QueryString["CD_PACOTE"].ToString()));
            lblTitulo.Text = pc.Titulo.ToString();
            if (pc.CaminhoImagem.ToString().Trim() != "") { btnExcluiImagem.Visible = true; } else { btnExcluiImagem.Visible = false; };
            lblcaminhodaimagem.Text = pc.CaminhoImagem.ToString();
            ImgPacote.ImageUrl = "~\\PACOTE\\" + pc.Codigo + "\\" + pc.CaminhoImagem.ToString();
        }

    }
    private Bitmap Resize_Image(Stream streamImage, int maxWidth, int maxHeight)
    {
        Bitmap originalImage = new Bitmap(streamImage);
        int newWidth = originalImage.Width;
        int newHeight = originalImage.Height;
        Graphics g = default(Graphics);

        g = Graphics.FromImage(originalImage);
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
        g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
        g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
        g.Dispose();

        newWidth = maxWidth;
        newHeight = maxHeight;

        return new Bitmap(originalImage, newWidth, newHeight);
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

        if (lblTitulo.Text != "") {
            Pacote pcExcuir = new Pacote();
            pcExcuir.Carregar(int.Parse(Request.QueryString["CD_PACOTE"].ToString()));

            if (pcExcuir.CaminhoImagem.ToString().Trim() != "")
                if (System.IO.File.Exists(Request.ServerVariables["APPL_PHYSICAL_PATH"] + @"PACOTE\" + pcExcuir.Codigo + "\\" + pcExcuir.CaminhoImagem))
                {
                    System.IO.File.Delete(Request.ServerVariables["APPL_PHYSICAL_PATH"] + @"PACOTE\" + pcExcuir.Codigo + "\\" + pcExcuir.CaminhoImagem);
                }
            pcExcuir.CaminhoImagem = "";
            pcExcuir.AtualizarImagem();
        }
        Pacote pc = new Pacote();
        pc.Carregar(int.Parse(Request.QueryString["CD_PACOTE"].ToString()));
        pc.CaminhoImagem = FileUploadImagem.FileName;         
        pc.AtualizarImagem();
        if (this.FileUploadImagem.PostedFile.ContentLength != 0 && this.FileUploadImagem.HasFile)
        {
            //capturando nome original do arquivo
            string fileName = this.FileUploadImagem.FileName;
            //capturando extensão do arquivo postado
            string extension = System.IO.Path.GetExtension(fileName);
            //Se existir o diretorio entao exclui e cria um novo sem imagem.
            string DiretorioPacote = Request.ServerVariables["APPL_PHYSICAL_PATH"] + @"PACOTE\" + pc.Codigo;
            //Cria diretório com o código.
            System.IO.Directory.CreateDirectory(DiretorioPacote);
            string vCamArq = DiretorioPacote + "\\" + fileName;
            //Salvando o arquivo com o nome original
            this.FileUploadImagem.PostedFile.SaveAs(vCamArq);

            //if (FileUploadImagem.HasFile)
            //{
            //    string img = string.Empty;
            //    Bitmap bmpImg = null;
            //    try
            //    {
            //        bmpImg = Resize_Image(FileUploadImagem.PostedFile.InputStream, 500, 300);
            //        img = vCamArq.Substring(0, vCamArq.Length - 4) + ".png";
            //        bmpImg.Save(img, ImageFormat.Jpeg);

            //        bmpImg = Resize_Image(FileUploadImagem.PostedFile.InputStream, 250, 150);
            //        img = vCamArq.Substring(0, vCamArq.Length - 4) + "_p.png";
            //        bmpImg.Save(img, ImageFormat.Jpeg);

            //    }
            //    catch (Exception ex)
            //    {
            //        Response.Write("Error occured: " + ex.Message.ToString());
            //    }
            //    finally
            //    {
            //        img = string.Empty;
            //        bmpImg.Dispose();
            //    }
            //}

        }
        Response.Redirect("AdminPacotesImagens.aspx?cd_pacote=" +pc.Codigo);
    }

    protected void btnExcluiImagem_Click(object sender, ImageClickEventArgs e)
    {

        Pacote pc = new Pacote();
        pc.Carregar(int.Parse(Request.QueryString["CD_PACOTE"].ToString()));

        if (pc.CaminhoImagem.ToString().Trim() != "")
            if (System.IO.File.Exists(Request.ServerVariables["APPL_PHYSICAL_PATH"] + @"PACOTE\" + pc.Codigo + "\\" + pc.CaminhoImagem))
            {
                System.IO.File.Delete(Request.ServerVariables["APPL_PHYSICAL_PATH"] + @"PACOTE\" + pc.Codigo + "\\" + pc.CaminhoImagem);
            }
        pc.CaminhoImagem = "";
        pc.AtualizarImagem();

        Response.Redirect("AdminPacotesImagens.aspx?cd_pacote=" + pc.Codigo);
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