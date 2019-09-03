using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Convidado
{
    private int _codigo;
    private int _cd_noivo;
    private string _nome;
    private string _telefones;
    private string _email;
    private string _cota_escolhida;
    private string _obs;
    private string _msg_noivos;
    private string _arquivo;
    private DateTime _dt_msg; 


    public int Codigo { get { return _codigo; } set { _codigo = value; } }
    public int CdNoivo { get { return _cd_noivo; } set { _cd_noivo = value; } }
    public string Nome { get { return _nome; } set { _nome = value; } }
    public string Telefones { get { return _telefones; } set { _telefones = value; } }
    public string Email { get { return _email; } set { _email = value; } }
    public string CotaEscolhida { get { return _cota_escolhida; } set { _cota_escolhida = value; } }
    public string Obs { get { return _obs; } set { _obs = value; } }
    public string MsgNoivos { get { return _msg_noivos; } set { _msg_noivos = value; } }
    public string Arquivo { get { return _arquivo; } set { _arquivo = value; } }
    public DateTime DtMsg { get { return _dt_msg; } set { _dt_msg = value; } }
    
    public Convidado()
	{
	}
    public void Inserir()
    {
        string comandoSQL = "INSERT INTO convidado ( nome,email,telefones,cota_escolhida,obs,mensagem,cd_noivo,dt_msg, arquivo ) VALUES ";
        comandoSQL = comandoSQL + "(  '" + _nome + "', '" + _email + "', '" + _telefones + "', '" + _cota_escolhida + "', '" + _obs + "', '" + _msg_noivos + "', '" + _cd_noivo + "', '" + DateTime.Now.ToString("yyyy/MM/dd") + "', '" + _arquivo + "')";
        BancoDados.Executar(comandoSQL);
        comandoSQL = "SELECT max(cd_convidado) from convidado";
        this.Codigo = int.Parse(BancoDados.Consultar(comandoSQL).Rows[0][0].ToString());
    }

    public void Atualizar()
    {
        string ComandoSQL = "UPDATE convidado SET nome = '" + _nome + "', ";
        ComandoSQL = ComandoSQL + " telefones = '" + _telefones + "',";
        ComandoSQL = ComandoSQL + " email = '" + _email + "',";
        ComandoSQL = ComandoSQL + " cota_escolhida = '" + _cota_escolhida + "',";
        ComandoSQL = ComandoSQL + " nome = '" + _nome + "',";
        ComandoSQL = ComandoSQL + " obs = '" + _obs + "',";
        ComandoSQL = ComandoSQL + " mensagem = '" + _msg_noivos + "',";
        ComandoSQL = ComandoSQL + " arquivo = '" + _arquivo + "',";
        ComandoSQL = ComandoSQL + " cd_noivo = '" + _cd_noivo + "'";
        ComandoSQL = ComandoSQL + " WHERE cd_convidado = " + _codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }

    public void Excluir()
    {
        string ComandoSQL = "DELETE FROM convidado WHERE cd_convidado = " + Codigo.ToString();
        BancoDados.Executar(ComandoSQL);
        ComandoSQL = "DELETE FROM convidado WHERE cd_convidado = " + Codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }

    public bool Carregar(int Codigo)
    {
        string ComandoSQL = "SELECT * FROM convidado WHERE cd_convidado = " + Codigo.ToString();
        System.Data.DataTable dt = BancoDados.Consultar(ComandoSQL);
        if (dt.Rows.Count == 0)
        {
            _codigo = 0;
            _cd_noivo = 0;
            _nome = "";
            _email = "";
            _obs = "";
            _telefones = "";
            _msg_noivos = "";
            _cota_escolhida = "" ;
            _msg_noivos = "";
            _arquivo = "";
            return false;
        }
        int.TryParse(dt.Rows[0]["cd_convidado"].ToString(), out _codigo);
        _nome = dt.Rows[0]["nome"].ToString();
        _email = dt.Rows[0]["email"].ToString();
        _cota_escolhida = dt.Rows[0]["cota_escolhida"].ToString();
        _telefones = dt.Rows[0]["telefones"].ToString();
        _obs = dt.Rows[0]["obs"].ToString();
        _msg_noivos = dt.Rows[0]["mensagem"].ToString();
        _arquivo = dt.Rows[0]["arquivo"].ToString();
        _cd_noivo = int.Parse(dt.Rows[0]["cd_noivo"].ToString());
        return true;
    }
        
    public static System.Data.DataTable Listar()
    {
        string comandoSQL = "SELECT * FROM convidado";
        return BancoDados.Consultar(comandoSQL);
    }

    public static System.Data.DataTable ListarPorNoivo(String cdNoivo)
    {
        string comandoSQL = "SELECT * FROM convidado where cd_noivo = " + cdNoivo.ToString() + " order by dt_msg";
        return BancoDados.Consultar(comandoSQL);
    }
   
}
