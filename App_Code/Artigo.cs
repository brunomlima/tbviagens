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

public class Artigo
{
    private int _codigo;
    private string _titulo;
    private string _conteudo;
    private string _diretorio;
    private int _cd_usuario;
    private int _cd_categoria;

    public int Codigo { get { return _codigo; } set { _codigo = value; } }
    public string Conteudo { get { return _conteudo; } set { _conteudo = value; } }
    public string Titulo { get { return _titulo; } set { _titulo = value; } }
    public string Diretorio { get { return _diretorio; } set { _diretorio = value; } }
    public int CdUsuario { get { return _cd_usuario; } set { _cd_usuario = value; } }
    public int cdCategoria { get { return _cd_categoria; } set { _cd_categoria = value; } }

    public Artigo()
	{
	}
    public static System.Data.DataTable Listar(string cd_categoria)
    {
        string comandoSQL = "SELECT * FROM artigo where cd_categoria = " + cd_categoria;
        return BancoDados.Consultar(comandoSQL);
    }
    public void Inserir()
    {
        string comandoSQL = "INSERT INTO artigo ( conteudo, titulo, cd_usuario, cd_categoria ) VALUES ";
        comandoSQL = comandoSQL + "(  '" + _conteudo + "', '" + _titulo + "', '" + _cd_usuario + "', '" + _cd_categoria + "')";
        BancoDados.Executar(comandoSQL);
        comandoSQL = "SELECT max(cd_artigo) from artigo";
        this.Codigo = int.Parse(BancoDados.Consultar(comandoSQL).Rows[0][0].ToString());
        
    }

    public void Atualizar()
    {
        string ComandoSQL = "UPDATE artigo SET conteudo = '" + _conteudo + "', ";
        ComandoSQL = ComandoSQL + " titulo = '" + _titulo + "'";
        ComandoSQL = ComandoSQL + " WHERE cd_artigo = " + _codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }

    public void Excluir()
    {
        string ComandoSQL = "DELETE FROM artigo WHERE cd_artigo = " + Codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }

    public bool Carregar(int Codigo)
    {
        string ComandoSQL = "SELECT * FROM artigo WHERE cd_artigo = " + Codigo.ToString();
        System.Data.DataTable dt = BancoDados.Consultar(ComandoSQL);
        if (dt.Rows.Count == 0)
        {
            _codigo = 0;
            _conteudo = "";
            _titulo = "";
            _cd_categoria = 0;
            _cd_usuario = 0;
            return false;
        }
        int.TryParse(dt.Rows[0]["cd_artigo"].ToString(), out _codigo);
        _conteudo = dt.Rows[0]["conteudo"].ToString();
        _titulo = dt.Rows[0]["titulo"].ToString();
        _diretorio = dt.Rows[0]["diretorio"].ToString();
        int.TryParse(dt.Rows[0]["cd_usuario"].ToString(), out _cd_usuario);
        int.TryParse(dt.Rows[0]["cd_categoria"].ToString(), out _cd_categoria);
        return true;
    }
   
    public static System.Data.DataTable Listar()
    {
        string comandoSQL = "SELECT * FROM artigo";
        return BancoDados.Consultar(comandoSQL);
    }
}
