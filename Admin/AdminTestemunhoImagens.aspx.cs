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

public partial class Admin_AdminTestemunhoImagens : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["LOGADO"] == null) { Response.Redirect("Default.aspx"); };
            Testemunho ts = new Testemunho();
            ts.Carregar(int.Parse(Request.QueryString["CD_TESTEMUNHO"].ToString()));
            lblNome.Text = ts.Nome.ToString();
            lblcaminhodaimagem.Text = ts.Imagem.ToString();
            if (ts.Imagem.ToString().Trim() != "") { btnExcluiImagem.Visible = true; } else { btnExcluiImagem.Visible = false; };
            ImgPacote.ImageUrl = "~\\TESTEMUNHO\\" + ts.Codigo + "\\" + ts.Imagem.ToString();
        }
    }
    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        lblMensagem.Text = "";
        lblMensagem.Visible = false;
        if (!ValidaTamanhodaImagem(FileUploadImagem.PostedFile.InputStream, 150, 150))
        {
            lblMensagem.Visible = true;
            lblMensagem.Text = "Tamanho da imagem fora do padrão - Utilize uma imagem 150px x 150px ";
            return;
        }

        if (lblcaminhodaimagem.Text != "")
        {
            Testemunho tsExclui = new Testemunho();
            tsExclui.Carregar(int.Parse(Request.QueryString["CD_TESTEMUNHO"].ToString()));

            if (tsExclui.Imagem.ToString().Trim() != "")
                if (System.IO.File.Exists(Request.ServerVariables["APPL_PHYSICAL_PATH"] + @"TESTEMUNHO\" + tsExclui.Codigo + "\\" + tsExclui.Imagem))
                {
                    System.IO.File.Delete(Request.ServerVariables["APPL_PHYSICAL_PATH"] + @"TESTEMUNHO\" + tsExclui.Codigo + "\\" + tsExclui.Imagem);
                }
            tsExclui.Imagem = "";
            tsExclui.AtualizarImagem();
        }

        Testemunho ts = new Testemunho();
        ts.Carregar(int.Parse(Request.QueryString["CD_TESTEMUNHO"].ToString()));
        //ts.Imagem = FileUploadImagem.FileName.Substring(0, FileUploadImagem.FileName.Length - 4) + ".png";
        ts.Imagem = FileUploadImagem.FileName;
        ts.AtualizarImagem();
        if (this.FileUploadImagem.PostedFile.ContentLength != 0 && this.FileUploadImagem.HasFile)
        {
            //capturando nome original do arquivo
            string fileName = this.FileUploadImagem.FileName;
            //capturando extensão do arquivo postado
            string extension = System.IO.Path.GetExtension(fileName);
            //Se existir o diretorio entao exclui e cria um novo sem imagem.
            string DiretorioPacote = Request.ServerVariables["APPL_PHYSICAL_PATH"] + @"TESTEMUNHO\" + ts.Codigo;
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
            //        bmpImg = Resize_Image(FileUploadImagem.PostedFile.InputStream, 150, 150);
            //        img = vCamArq.Substring(0, vCamArq.Length - 4) + ".png";
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
        Response.Redirect("AdminTestemunhoImagens.aspx?cd_testemunho=" + ts.Codigo);
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

    protected void btnExcluiImagem_Click(object sender, ImageClickEventArgs e)
    {
        Testemunho ts = new Testemunho();
        ts.Carregar(int.Parse(Request.QueryString["CD_TESTEMUNHO"].ToString()));

        if (ts.Imagem.ToString().Trim() != "")
            if (System.IO.File.Exists(Request.ServerVariables["APPL_PHYSICAL_PATH"] + @"TESTEMUNHO\" + ts.Codigo + "\\" + ts.Imagem))
            {
                System.IO.File.Delete(Request.ServerVariables["APPL_PHYSICAL_PATH"] + @"TESTEMUNHO\" + ts.Codigo + "\\" + ts.Imagem);
            }
        ts.Imagem = "";
        ts.AtualizarImagem();

        Response.Redirect("AdminTestemunhoImagens.aspx?cd_testemunho=" + ts.Codigo);
    }
}