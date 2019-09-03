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

public class Usuario
{
    private int _codigo;
    private string _cpf;
    private string _senha;
    private string _email;
    private string _skype;
    private string _nome;
    private string _cargo;
    private string _status;


    public int Codigo { get { return _codigo; } set { _codigo = value; } }
    public string Cpf { get { return _cpf; } set { _cpf = value; } }
    public string Senha { get { return _senha; } set { _senha = value; } }
    public string Email { get { return _email; } set { _email = value; } }
    public string Skype { get { return _skype; } set { _skype = value; } }
    public string Nome { get { return _nome; } set { _nome = value; } }
    public string Cargo { get { return _cargo; } set { _cargo = value; } }
    public string Status { get { return _status; } set { _status = value; } }
    
    public Usuario()
	{
	}
    public void Inserir()
    {
        string comandoSQL = "INSERT INTO usuario ( cpf, senha, email, skype, nome, cargo, status ) VALUES ";
        comandoSQL = comandoSQL + "(  '" + _cpf + "', '" + _senha + "', '" + _email + "', '" + _skype + "', '" + _nome + "', '" + _cargo + "','I')";
        BancoDados.Executar(comandoSQL);
        comandoSQL = "SELECT max(cd_usuario) from usuario";
        this.Codigo = int.Parse(BancoDados.Consultar(comandoSQL).Rows[0][0].ToString());
    }

    public void Atualizar()
    {
        string ComandoSQL = "UPDATE usuario SET cpf = '" + _cpf + "', ";
        ComandoSQL = ComandoSQL + " senha = '" + _senha + "',";
        ComandoSQL = ComandoSQL + " email = '" + _email + "',";
        ComandoSQL = ComandoSQL + " skype = '" + _skype + "',";
        ComandoSQL = ComandoSQL + " nome = '" + _nome + "',";
        ComandoSQL = ComandoSQL + " cargo = '" + _cargo + "',";
        ComandoSQL = ComandoSQL + " status = '" + _status + "'";
        ComandoSQL = ComandoSQL + " WHERE cd_usuario = " + _codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }

    public void Excluir()
    {
        string ComandoSQL = "DELETE FROM acessos WHERE cd_usuario = " + Codigo.ToString();
        BancoDados.Executar(ComandoSQL);
        ComandoSQL = "DELETE FROM usuario WHERE cd_usuario = " + Codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }

    public bool Carregar(int Codigo)
    {
        string ComandoSQL = "SELECT * FROM usuario WHERE cd_usuario = " + Codigo.ToString();
        System.Data.DataTable dt = BancoDados.Consultar(ComandoSQL);
        if (dt.Rows.Count == 0)
        {
            _codigo = 0;
            _cpf = "";
            _email = "";
            _nome = "";
            _cargo = "";
            _senha = "";
            _status = "";
            return false;
        }
        int.TryParse(dt.Rows[0]["cd_usuario"].ToString(), out _codigo);
        _cpf = dt.Rows[0]["cpf"].ToString();
        _email = dt.Rows[0]["email"].ToString();
        _skype = dt.Rows[0]["skype"].ToString();
        _nome = dt.Rows[0]["nome"].ToString();
        _senha = dt.Rows[0]["senha"].ToString();
        _cargo = dt.Rows[0]["cargo"].ToString();
        _status = dt.Rows[0]["status"].ToString();
        return true;
    }

    public bool Carregar(string Cpf)
    {
        string ComandoSQL = "SELECT * FROM usuario WHERE cpf = " + Cpf;
        System.Data.DataTable dt = BancoDados.Consultar(ComandoSQL);
        if (dt.Rows.Count == 0)
        {
            _codigo = 0;
            _cpf = "";
            _email = "";
            _nome = "";
            _senha = "";
            _cargo = "";
            _status = "";
            return false;
        }
        int.TryParse(dt.Rows[0]["cd_usuario"].ToString(), out _codigo);
        _cpf = dt.Rows[0]["cpf"].ToString();
        _email = dt.Rows[0]["email"].ToString();
        _skype = dt.Rows[0]["skype"].ToString();
        _nome = dt.Rows[0]["nome"].ToString();
        _cargo = dt.Rows[0]["cargo"].ToString();
        _senha = dt.Rows[0]["senha"].ToString();
        _status = dt.Rows[0]["status"].ToString().ToUpper();
        return true;
    }
    public static System.Data.DataTable Listar()
    {
        string comandoSQL = "SELECT * FROM usuario";
        return BancoDados.Consultar(comandoSQL);
    }
    public static System.Data.DataTable ListarContatos()
    {
        string comandoSQL = "SELECT * FROM usuario where status = 'A' order by nome ";
        return BancoDados.Consultar(comandoSQL);
    }
}
