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

public partial class Admin_AdminRoteiroImagens : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["LOGADO"] == null) { Response.Redirect("Default.aspx"); };
            Roteiro rt = new Roteiro();
            rt.Carregar(int.Parse(Request.QueryString["CD_ROTEIRO"].ToString()));
            lblTitulo.Text = rt.Nome.ToString();
            if (rt.CaminhoImagem.ToString().Trim() != "") { btnExcluiImagem.Visible = true; } else { btnExcluiImagem.Visible = false; };
            lblcaminhodaimagem.Text = rt.CaminhoImagem.ToString();
            ImgPacote.ImageUrl = "~\\ROTEIRO\\" + rt.Codigo + "\\" + rt.CaminhoImagem.ToString();
        }
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

    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        lblMensagem.Text = "";
        lblMensagem.Visible = false;
        if (!ValidaTamanhodaImagem(FileUploadImagem.PostedFile.InputStream, 684, 350))
        {
            lblMensagem.Visible = true;
            lblMensagem.Text = "Tamanho da imagem fora do padrão - Utilize uma imagem 684px por 350px ";
            return;
        }

        if (lblTitulo.Text != "")
        {
            Roteiro rtExcluir = new Roteiro();
            rtExcluir.Carregar(int.Parse(Request.QueryString["CD_ROTEIRO"].ToString()));

            if (rtExcluir.CaminhoImagem.ToString().Trim() != "")
                if (System.IO.File.Exists(Request.ServerVariables["APPL_PHYSICAL_PATH"] + @"PACOTE\" + rtExcluir.Codigo + "\\" + rtExcluir.CaminhoImagem))
                {
                    System.IO.File.Delete(Request.ServerVariables["APPL_PHYSICAL_PATH"] + @"PACOTE\" + rtExcluir.Codigo + "\\" + rtExcluir.CaminhoImagem);
                }
            rtExcluir.CaminhoImagem = "";
            rtExcluir.AtualizarImagem();
        }
        Roteiro rt = new Roteiro();
        rt.Carregar(int.Parse(Request.QueryString["CD_ROTEIRO"].ToString()));
        rt.CaminhoImagem = FileUploadImagem.FileName;
        rt.AtualizarImagem();
        if (this.FileUploadImagem.PostedFile.ContentLength != 0 && this.FileUploadImagem.HasFile)
        {
            //capturando nome original do arquivo
            string fileName = this.FileUploadImagem.FileName;
            //capturando extensão do arquivo postado
            string extension = System.IO.Path.GetExtension(fileName);
            //Se existir o diretorio entao exclui e cria um novo sem imagem.
            string DiretorioPacote = Request.ServerVariables["APPL_PHYSICAL_PATH"] + @"ROTEIRO\" + rt.Codigo;
            //Cria diretório com o código.
            System.IO.Directory.CreateDirectory(DiretorioPacote);
            string vCamArq = DiretorioPacote + "\\" + fileName;
            //Salvando o arquivo com o nome original
            this.FileUploadImagem.PostedFile.SaveAs(vCamArq);
        }
        Response.Redirect("AdminRoteiroImagens.aspx?cd_roteiro=" + rt.Codigo);
    }

    protected void btnExcluiImagem_Click(object sender, ImageClickEventArgs e)
    {
        Roteiro rt = new Roteiro();
        rt.Carregar(int.Parse(Request.QueryString["CD_ROTEIRO"].ToString()));

        if (rt.CaminhoImagem.ToString().Trim() != "")
            if (System.IO.File.Exists(Request.ServerVariables["APPL_PHYSICAL_PATH"] + @"ROTEIRO\" + rt.Codigo + "\\" + rt.CaminhoImagem))
            {
                System.IO.File.Delete(Request.ServerVariables["APPL_PHYSICAL_PATH"] + @"ROTEIRO\" + rt.Codigo + "\\" + rt.CaminhoImagem);
            }
        rt.CaminhoImagem = "";
        rt.AtualizarImagem();

        Response.Redirect("AdminRoteiroImagens.aspx?cd_roteiro=" + rt.Codigo);
    }

}