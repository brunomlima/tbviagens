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

public partial class Admin_AdminNoivosImagens : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["LOGADO"] == null) { Response.Redirect("Default.aspx"); };
            Noivo nv = new Noivo();
            nv.Carregar(int.Parse(Request.QueryString["cd_noivo"].ToString()));                     
            lblNomeNoivos.Text = nv.Nome_Noivos.ToString();
            lblcaminhodaimagem.Text = nv.CaminhoImagem.ToString();
            ImgPacote.ImageUrl = "~\\NOIVOS\\" + nv.Codigo + "\\" + nv.CaminhoImagem.ToString();
        }

    }
    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        Noivo nv = new Noivo();
        nv.Carregar(int.Parse(Request.QueryString["cd_noivo"].ToString()));
        nv.CaminhoImagem = FileUploadImagem.FileName.Substring(0, FileUploadImagem.FileName.Length - 4) + ".png";
        nv.AtualizarImagem();
        if (this.FileUploadImagem.PostedFile.ContentLength != 0 && this.FileUploadImagem.HasFile)
        {
            //capturando nome original do arquivo
            string fileName = this.FileUploadImagem.FileName;
            //capturando extensão do arquivo postado
            string extension = System.IO.Path.GetExtension(fileName);
            //Se existir o diretorio entao exclui e cria um novo sem imagem.
            string DiretorioPacote = Request.ServerVariables["APPL_PHYSICAL_PATH"] + @"NOIVOS\" + nv.Codigo;
            //Cria diretório com o código.
            System.IO.Directory.CreateDirectory(DiretorioPacote);
            string vCamArq = DiretorioPacote + "\\" + fileName;
            //Salvando o arquivo com o nome original
            //this.FileUploadImagem.PostedFile.SaveAs(vCamArq);

            if (FileUploadImagem.HasFile)
            {
                string img = string.Empty;
                Bitmap bmpImg = null;
                try
                {
                    bmpImg = Resize_Image(FileUploadImagem.PostedFile.InputStream, 500, 300);
                    img = vCamArq.Substring(0, vCamArq.Length - 4) + ".png";
                    bmpImg.Save(img, ImageFormat.Jpeg);

                    bmpImg = Resize_Image(FileUploadImagem.PostedFile.InputStream, 250, 150);
                    img = vCamArq.Substring(0, vCamArq.Length - 4) + "_p.png";
                    bmpImg.Save(img, ImageFormat.Jpeg);

                }
                catch (Exception ex)
                {
                    Response.Write("Error occured: " + ex.Message.ToString());
                }
                finally
                {
                    img = string.Empty;
                    bmpImg.Dispose();
                }
            }

        }
        Response.Redirect("AdminNoivosImagens.aspx?cd_noivo=" + nv.Codigo);
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
}