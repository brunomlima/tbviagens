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

public class EmailMkt
{
    private int _codigo;
    private string _email;
    private string _nome;

    public EmailMkt() { }

    public int Codigo { get { return _codigo; } set { _codigo = value; } }
    public string Email { get { return _email; } set { _email = value; } }
    public string Nome { get { return _nome; } set { _nome = value; } }

    public static System.Data.DataTable Listar(string cd_email_mkt)
    {
        string comandoSQL = "SELECT * FROM email_mkt where cd_email = " + cd_email_mkt + " order by nome";
        return BancoDados.Consultar(comandoSQL);
    }
    public void Inserir()
    {
        string comandoSQL = "INSERT INTO email_mkt ( email, nome ) VALUES ";
        comandoSQL = comandoSQL + "(  '" + _email + "','" + _nome + "')";
        BancoDados.Executar(comandoSQL);
        comandoSQL = "SELECT max(cd_email) from email_mkt";
        this.Codigo = int.Parse(BancoDados.Consultar(comandoSQL).Rows[0][0].ToString());

    }

    public void Excluir()
    {
        string ComandoSQL = "DELETE FROM email_mkt WHERE cd_email = " + Codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }

    public bool Carregar(int Codigo)
    {
        string ComandoSQL = "SELECT * FROM email_mkt WHERE cd_email = " + Codigo.ToString();
        System.Data.DataTable dt = BancoDados.Consultar(ComandoSQL);
        if (dt.Rows.Count == 0)
        {
            return false;
        }
        int.TryParse(dt.Rows[0]["cd_email"].ToString(), out _codigo);
        _email = dt.Rows[0]["email"].ToString();
        _nome = dt.Rows[0]["nome"].ToString();
        return true;
    }

    public bool Existe(string Email)
    {
        string ComandoSQL = "SELECT * FROM email_mkt WHERE email = '" + Email.ToString().Trim() + "'";
        System.Data.DataTable dt = BancoDados.Consultar(ComandoSQL);
        if (dt.Rows.Count == 0)
        {
            return false;
        }
        int.TryParse(dt.Rows[0]["cd_email"].ToString(), out _codigo);
        _email = dt.Rows[0]["email"].ToString();
        _nome = dt.Rows[0]["nome"].ToString();
        return true;
    }
    public bool CarregarPorEmail(string semail)
    {
        string ComandoSQL = "SELECT * FROM email_mkt WHERE email = '" + semail + "'";
        System.Data.DataTable dt = BancoDados.Consultar(ComandoSQL);
        if (dt.Rows.Count == 0)
        {
            _codigo = 0;
            _email = "";
            _nome = "";
            return false;
        }
        int.TryParse(dt.Rows[0]["cd_email"].ToString(), out _codigo);
        _email = dt.Rows[0]["email"].ToString();
        _nome = dt.Rows[0]["nome"].ToString();
        return true;
    }



    public static System.Data.DataTable Listar()
    {
        string comandoSQL = "SELECT * FROM email_mkt order by nome";
        return BancoDados.Consultar(comandoSQL);
    }

    public static System.Data.DataTable ListarEmail(string semail)
    {
        string comandoSQL = "SELECT * FROM email_mkt where email like '%" + semail + "%'";
        return BancoDados.Consultar(comandoSQL);
    }

    public static System.Data.DataTable ListarLote(string qtd, string cd_pacote)
    {
        string comandoSQL = "SELECT * FROM email_mkt where cd_email not in (select cd_email from envio where cd_pacote = " + cd_pacote + ")  order by nome LIMIT 0, " + qtd;
        return BancoDados.Consultar(comandoSQL);
    }

    public void Atualizar()
    {
        string ComandoSQL = "UPDATE email_mkt SET nome = '" + _nome + "', ";
        ComandoSQL = ComandoSQL + " email = '" + _email + "'";
        ComandoSQL = ComandoSQL + " WHERE cd_email = " + _codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }
    public static int ContaEmailEnviado(int cd_pacote)
    {
        string comandoSQL = "SELECT count(1) as qtd FROM tbviagens.email_mkt where cd_email in (select cd_email from tbviagens.envio where cd_pacote = " + cd_pacote + ")";
        int max = int.Parse(BancoDados.Consultar(comandoSQL).Rows[0][0].ToString());
        return max;
    }

    public static int ContaEmailNaoEnviado(int cd_pacote)
    {
        string comandoSQL = "SELECT count(1) as qtd FROM tbviagens.email_mkt where cd_email not in (select cd_email from tbviagens.envio where cd_pacote = " + cd_pacote + ")";
        int max = int.Parse(BancoDados.Consultar(comandoSQL).Rows[0][0].ToString());
        return max;
    }
    public static System.Data.DataTable ConsultaDescricao(int cd_pacote)
    {
        string comandoSQL = "SELECT titulo FROM tbviagens.pacote where cd_pacote = " + cd_pacote + "";
        return BancoDados.Consultar(comandoSQL);
    }

}