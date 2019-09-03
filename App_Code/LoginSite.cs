using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class LoginSite
{
    private string _login;
    private string _senha;
    private string _nome;
    private string _permissao;
    private int _codigo;


    public string Login { get { return _login; } set { _login = BlockSqlInjection(value); } }
    public string Senha { get { return _senha; } set { _senha = BlockSqlInjection(value); } }
    public string Nome { get { return _nome; } set { _nome = value; } }
    public string Permissao { get { return _permissao; } set { _permissao = value; } }
    public int Codigo { get { return _codigo; } set { _codigo = value; } }

	
    public LoginSite()
	{
	}
    public bool Valida()
    {
        string ComandoSQL = "SELECT * FROM usuario WHERE cpf = '" + _login + "' AND senha = '" + _senha + "' AND status in ('A','C') ";
        System.Data.DataTable dt = BancoDados.Consultar(ComandoSQL);
        if (dt.Rows.Count == 0)
        {
            _nome = "";
            _codigo = 0;
            return false;
        }
        _nome = dt.Rows[0]["nome"].ToString();
        int.TryParse(dt.Rows[0]["cd_usuario"].ToString(), out _codigo);
        return true;
    }
    //Este método tem como objetivo bloquear o ataque básico de Sql Injection;
    public static string BlockSqlInjection(string Parametro)
    {
        string s;
        Parametro = Parametro.ToString().Trim();
        Parametro = Parametro.Replace("=", "");
        Parametro = Parametro.Replace("'", "");
        Parametro = Parametro.Replace(" or ", "");
        Parametro = Parametro.Replace(" and ", "");
        Parametro = Parametro.Replace("(", "");
        Parametro = Parametro.Replace(")", "");
        Parametro = Parametro.Replace("<", "[");
        Parametro = Parametro.Replace(">", "]");
        Parametro = Parametro.Replace("update", "");
        Parametro = Parametro.Replace("-shutdown", "");
        Parametro = Parametro.Replace("--", "");
        Parametro = Parametro.Replace("'", "");
        Parametro = Parametro.Replace("#", "");
        Parametro = Parametro.Replace("$", "");
        Parametro = Parametro.Replace("%", "");
        Parametro = Parametro.Replace("¨", "");
        Parametro = Parametro.Replace("&", "");
        Parametro = Parametro.Replace("'or'1'='1'", "");
        Parametro = Parametro.Replace("--", "");
        Parametro = Parametro.Replace("insert", "");
        Parametro = Parametro.Replace("drop", "");
        Parametro = Parametro.Replace("delet", "");
        Parametro = Parametro.Replace("xp_", "");
        Parametro = Parametro.Replace("select", "");
        Parametro = Parametro.Replace("*", "");
        s = Parametro;
        return s;
    }

    public static System.Data.DataTable Listar(string cpf)
    {     
        string comandoSQL = "select u.nome nome_completo ,m.nome nome_modulo,m.pagina ";
        comandoSQL = comandoSQL + "from usuario u, acessos a, modulo m ";
        comandoSQL = comandoSQL + "where u.cd_usuario = a.cd_usuario and ";
        comandoSQL = comandoSQL + "a.cd_modulo = m.cd_modulo and ";
        comandoSQL = comandoSQL + "u.cpf = " + cpf;       
        return BancoDados.Consultar(comandoSQL);
    }
  
}
