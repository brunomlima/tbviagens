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

public class Portifolios
{
    private int _codigo;
    private string _url;
    private string _imagem;
    private string _detalhes;

    public int Codigo { get { return _codigo; } set { _codigo = value; } }
    public string Url { get { return _url; } set { _url = value; } }
    public string CaminhoImagem { get { return _imagem; } set { _imagem = value; } }
    public string Detalhes { get { return _detalhes; } set { _detalhes = value; } }

	public Portifolios()
	{
	}

    public void Inserir()
    {
        string comandoSQL = "INSERT INTO portifolio ( url, imagem, detalhes ) VALUES ";
        comandoSQL = comandoSQL + "(  '" + _url + "', '" + _imagem + "', '" + _detalhes + "')";
        BancoDados.Executar(comandoSQL);
        comandoSQL = "SELECT max(cd_portifolio) from portifolio";
        this.Codigo = int.Parse(BancoDados.Consultar(comandoSQL).Rows[0][0].ToString());
    }

    public void Atualizar()
    {
        string ComandoSQL = "UPDATE portifolio SET url = '" + _url + "', ";
        ComandoSQL = ComandoSQL + " imagem = '" + _imagem + "',";
        ComandoSQL = ComandoSQL + " detalhes = '" + _detalhes + "'";
        ComandoSQL = ComandoSQL + " WHERE cd_portifolio = " + _codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }

    public void Excluir()
    {
        string ComandoSQL = "DELETE FROM portifolio WHERE cd_portifolio = " + Codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }

    public bool Carregar(int Codigo)
    {
        string ComandoSQL = "SELECT * FROM portifolio WHERE cd_portifolio = " + Codigo.ToString();
        System.Data.DataTable dt = BancoDados.Consultar(ComandoSQL);
        if (dt.Rows.Count == 0)
        {
            _codigo = 0;
            _url = "";
            _imagem = "";
            _detalhes = "";
            return false;
        }
        int.TryParse(dt.Rows[0]["cd_portifolio"].ToString(), out _codigo);
        _url = dt.Rows[0]["url"].ToString();
        _imagem = dt.Rows[0]["imagem"].ToString();
        _detalhes = dt.Rows[0]["detalhes"].ToString();
        return true;
    }

    public static System.Data.DataTable Listar()
    {
        string comandoSQL = "SELECT * FROM portifolio";
        return BancoDados.Consultar(comandoSQL);
    }


}
