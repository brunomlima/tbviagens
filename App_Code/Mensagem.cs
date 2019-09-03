using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;


public class Mensagem
{
    private int _codigo;
    private string _conteudo;
    private string _autor;

    public int Codigo { get { return _codigo; } set { _codigo = value; } }
    public string Conteudo { get { return _conteudo; } set { _conteudo = value; } }
    public string Autor { get { return _autor; } set { _autor = value; } }

    public Mensagem()
	{
	}

    public void Inserir()
    {
        string comandoSQL = "INSERT INTO mensagem ( conteudo, autor ) VALUES ";
        comandoSQL = comandoSQL + "(  '" + _conteudo + "', '" + _autor + "')";
        BancoDados.Executar(comandoSQL);
        comandoSQL = "SELECT max(cd_mensagem) from mensagem";
        this.Codigo = int.Parse(BancoDados.Consultar(comandoSQL).Rows[0][0].ToString());
    }

    public void Atualizar()
    {
        string ComandoSQL = "UPDATE mensagem SET conteudo = '" + _conteudo + "', ";
        ComandoSQL = ComandoSQL + " autor = '" + _autor + "'";
        ComandoSQL = ComandoSQL + " WHERE cd_mensagem = " + _codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }

    public void Excluir()
    {
        string ComandoSQL = "DELETE FROM mensagem WHERE cd_mensagem = " + Codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }

    public bool Carregar(int Codigo)
    {
        string ComandoSQL = "SELECT * FROM mensagem WHERE cd_mensagem = " + Codigo.ToString();
        System.Data.DataTable dt = BancoDados.Consultar(ComandoSQL);
        if (dt.Rows.Count == 0)
        {
            _codigo = 0;
            _conteudo = "";
            _autor = "";
            return false;
        }
        int.TryParse(dt.Rows[0]["cd_mensagem"].ToString(), out _codigo);
        _conteudo = dt.Rows[0]["conteudo"].ToString();
        _autor = dt.Rows[0]["autor"].ToString();       
        return true;
    }

    public bool CarregarRandom()
    {
        string comandoSQL = "SELECT max(cd_mensagem) from mensagem";
        int max = int.Parse(BancoDados.Consultar(comandoSQL).Rows[0][0].ToString());

        Random myRandom = new Random();
        int cd_mensagem_aleatorio = myRandom.Next(max) + 1;
            
        comandoSQL = "SELECT * FROM mensagem WHERE cd_mensagem = " + cd_mensagem_aleatorio.ToString();
        System.Data.DataTable dt = BancoDados.Consultar(comandoSQL);
        if (dt.Rows.Count == 0)
        {
            _codigo = 0;
            _conteudo = "";
            _autor = "";
            return false;
        }
        int.TryParse(dt.Rows[0]["cd_mensagem"].ToString(), out _codigo);
        _conteudo = dt.Rows[0]["conteudo"].ToString();
        _autor = dt.Rows[0]["autor"].ToString();
        return true;
    }

    public static System.Data.DataTable Listar()
    {
        string comandoSQL = "SELECT * FROM mensagem";
        return BancoDados.Consultar(comandoSQL);
    }
}
