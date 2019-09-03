using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public class Comentario
{
    private int _codigo;
    private string _conteudo;
    private string _email;
    private string _cd_artigo;

    public int Codigo { get { return _codigo; } set { _codigo = value; } }
    public string Conteudo { get { return _conteudo; } set { _conteudo = value; } }
    public string Email { get { return _email; } set { _email = value; } }
    public string CdArtigo { get { return _cd_artigo; } set { _cd_artigo = value; } }   

	public Comentario()
	{
	}
    
    public static int ListarQtd(string cd_artigo)
    {
        string comandoSQL = "select count(1) qtd from comentario where cd_artigo = " + cd_artigo;
        int max = int.Parse(BancoDados.Consultar(comandoSQL).Rows[0][0].ToString());
        return max;
    }

    public static System.Data.DataTable Listar(string cd_artigo)
    {
        string comandoSQL = "SELECT * FROM comentario where cd_artigo = " + cd_artigo;
        return BancoDados.Consultar(comandoSQL);
    }

    public void Inserir()
    {
        string comandoSQL = "INSERT INTO comentario ( cd_artigo, conteudo, email ) VALUES ";
        comandoSQL = comandoSQL + "(  '" + _cd_artigo + "', '" + _conteudo + "', '" + _email + "')";
        BancoDados.Executar(comandoSQL);
        comandoSQL = "SELECT max(cd_comentario) from comentario";
        this.Codigo = int.Parse(BancoDados.Consultar(comandoSQL).Rows[0][0].ToString());
    }

    public void Excluir()
    {
        string ComandoSQL = "DELETE FROM comentario WHERE cd_comentario = " + Codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }
}
