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

public class Ferramentas
{
    private int _codigo;
    private string _url;
    private string _descricao;
    private string _tipo;

	public Ferramentas(){}

    public int Codigo { get { return _codigo; } set { _codigo = value; } }
    public string Url { get { return _url; } set { _url = value; } }
    public string Descricao { get { return _descricao; } set { _descricao = value; } }
    public string Tipo { get { return _tipo; } set { _tipo = value; } }


    public static System.Data.DataTable Listar(string cd_ferramenta)
    {
        string comandoSQL = "SELECT * FROM ferramenta where cd_ferramenta = " + cd_ferramenta;
        return BancoDados.Consultar(comandoSQL);
    }
    public void Inserir()
    {
        string comandoSQL = "INSERT INTO ferramenta ( url, descricao, tipo ) VALUES ";
        comandoSQL = comandoSQL + "(  '" + _url + "','" + _descricao + "','" + _tipo + "')";
        BancoDados.Executar(comandoSQL);
        comandoSQL = "SELECT max(cd_ferramenta) from ferramenta";
        this.Codigo = int.Parse(BancoDados.Consultar(comandoSQL).Rows[0][0].ToString());

    }

    public void Excluir()
    {
        string ComandoSQL = "DELETE FROM ferramenta WHERE cd_ferramenta = " + Codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }

    public bool Carregar(int Codigo)
    {
        string ComandoSQL = "SELECT * FROM ferramenta WHERE cd_ferramenta = " + Codigo.ToString();
        System.Data.DataTable dt = BancoDados.Consultar(ComandoSQL);
        if (dt.Rows.Count == 0)
        {
            _codigo = 0;
            _url = "";
            _descricao = "";
            _tipo = "";
            return false;
        }
        int.TryParse(dt.Rows[0]["cd_ferramenta"].ToString(), out _codigo);
        _url = dt.Rows[0]["url"].ToString();
        _descricao = dt.Rows[0]["descricao"].ToString();
        _tipo = dt.Rows[0]["tipo"].ToString();
        return true;
    }

    public bool Existe(string url)
    {
        string ComandoSQL = "SELECT * FROM ferramenta WHERE url = '" + url.ToString() + "'";
        System.Data.DataTable dt = BancoDados.Consultar(ComandoSQL);
        if (dt.Rows.Count == 0)
        {
            return false;
        }
        return true;
    }

    public static System.Data.DataTable Listar()
    {
        string comandoSQL = "SELECT * FROM ferramenta order by tipo, descricao";
        return BancoDados.Consultar(comandoSQL);
    }

    public static System.Data.DataTable ListarTipo(string tp)
    {
        string comandoSQL = "SELECT * FROM ferramenta where tipo = '"+tp+"' order by descricao";
        return BancoDados.Consultar(comandoSQL);
    }

    public void Atualizar()
    {
        string ComandoSQL = "UPDATE ferramenta SET url = '" + _url + "', ";
        ComandoSQL = ComandoSQL + " descricao = '" + _descricao + "',";
        ComandoSQL = ComandoSQL + " tipo = '" + _tipo.ToUpper() + "'";
        ComandoSQL = ComandoSQL + " WHERE cd_ferramenta = " + _codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }

    public static System.Data.DataTable ListarImagemGrande()
    {
        string comandoSQL = "SELECT * FROM ferramenta where tipo = "  ;
        return BancoDados.Consultar(comandoSQL);
    }
}