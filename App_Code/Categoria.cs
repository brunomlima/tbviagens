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

public class Categoria
{
    private int _codigo;
    private string _categoria;

    public int Codigo { get { return _codigo; } set { _codigo = value; } }
    public string NomeCategoria { get { return _categoria; } set { _categoria = value; } }

    public Categoria()
	{
	}
    public void Inserir()
    {
        string comandoSQL = "INSERT INTO categoria ( nome ) VALUES ";
        comandoSQL = comandoSQL + "(  '" + _categoria + "')";
        BancoDados.Executar(comandoSQL);
        comandoSQL = "SELECT max(cd_categoria) from categoria";
        this.Codigo = int.Parse(BancoDados.Consultar(comandoSQL).Rows[0][0].ToString());
    }

    public void Atualizar()
    {
        string ComandoSQL = "UPDATE categoria SET nome = '" + _categoria + "' ";
        ComandoSQL = ComandoSQL + " WHERE cd_categoria = " + _codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }

    public void Excluir()
    {
        string ComandoSQL = "DELETE FROM categoria WHERE cd_categoria = " + Codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }

    public bool Carregar(int Codigo)
    {
        string ComandoSQL = "SELECT * FROM categoria WHERE cd_categoria = " + Codigo.ToString();
        System.Data.DataTable dt = BancoDados.Consultar(ComandoSQL);
        if (dt.Rows.Count == 0)
        {
            _codigo = 0;
            _categoria = "";
            return false;
        }
        int.TryParse(dt.Rows[0]["cd_categoria"].ToString(), out _codigo);
        _categoria = dt.Rows[0]["nome"].ToString();
        return true;
    }

    public static System.Data.DataTable Listar()
    {
        string comandoSQL = "SELECT c.nome nome_categoria,c.cd_categoria FROM categoria c";
        return BancoDados.Consultar(comandoSQL);
    }
    
    public static System.Data.DataTable ListarPaginaInicial()
    {
        string comandoSQL = "select c.nome nome_categoria,c.cd_categoria, count(1) qtd_artigos ";
        comandoSQL = comandoSQL + " from artigo a, categoria c ";
        comandoSQL = comandoSQL + "where a.cd_categoria = c.cd_categoria ";
        comandoSQL = comandoSQL + "group by c.nome,c.cd_categoria ";
        return BancoDados.Consultar(comandoSQL);
    }
}
