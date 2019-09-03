using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Roteiro
{
    private int      _codigo;
    private string   _nome;
    private string   _destino;
    private string   _detalhe;
    private string   _imagem;
    private string   _mapa;
    private string   _endereco;
    private DateTime _data;
    private string _horaminutosegundo;

    public int Codigo { get { return _codigo; } set { _codigo = value; } }
    public string Nome { get { return _nome; } set { _nome = value; } }
    public string Destino { get { return _destino; } set { _destino = value; } }
    public string Detalhe { get { return _detalhe; } set { _detalhe = value; } }
    public string CaminhoImagem { get { return _imagem; } set { _imagem = value; } }
    public string Mapa { get { return _mapa; } set { _mapa = value; } }
    public string Endereco { get { return _endereco; } set { _endereco = value; } }
    public DateTime Data { get { return _data; } set { _data = value; } }
    public string HoraMinSegundo { get { return _horaminutosegundo; } set { _horaminutosegundo = value; } }

    public Roteiro(){}

    public static System.Data.DataTable Listar(string cd_roteiro)
    {
        string comandoSQL = "SELECT * FROM roteiro where cd_roteiro = " + cd_roteiro + " order by data desc";
        return BancoDados.Consultar(comandoSQL);
    }
    public void Inserir()
    {
        string comandoSQL = "INSERT INTO roteiro (nome,data,destino,detalhe,imagem,mapa,endereco) VALUES ";
        comandoSQL = comandoSQL + "(  '" + _nome + "', '" + _data.ToString("yyyy/MM/dd") + " " + _horaminutosegundo +"', '" + _destino + "', '" + _detalhe + "', '" + _imagem + "', '" + _mapa + "', '" + _endereco + "')";
        BancoDados.Executar(comandoSQL);
        comandoSQL = "SELECT max(cd_roteiro) from roteiro";
        this.Codigo = int.Parse(BancoDados.Consultar(comandoSQL).Rows[0][0].ToString());
    }

    public void Atualizar()
    {
        string ComandoSQL = "UPDATE roteiro SET destino = '" + _destino + "', ";
        ComandoSQL = ComandoSQL + " nome = '" + _nome + "',";
        ComandoSQL = ComandoSQL + " detalhe = '" + _detalhe + "',";
        ComandoSQL = ComandoSQL + " imagem = '" + _imagem + "',";
        ComandoSQL = ComandoSQL + " mapa = '" + _mapa + "',";
        ComandoSQL = ComandoSQL + " endereco = '" + _endereco + "',";       
        ComandoSQL = ComandoSQL + " data = '" + _data.ToString("yyyy/MM/dd") +" "+ _horaminutosegundo + "'";
        ComandoSQL = ComandoSQL + " WHERE cd_roteiro = " + _codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }

    public void AtualizarImagem()
    {
        string ComandoSQL = "UPDATE roteiro SET imagem = '" + _imagem + "' ";
        ComandoSQL = ComandoSQL + " WHERE cd_roteiro = " + _codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }
    public void Excluir()
    {
        string ComandoSQL = "DELETE FROM roteiro WHERE cd_roteiro = " + Codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }

    public bool Carregar(int Codigo)
    {
        string ComandoSQL = "SELECT * FROM roteiro WHERE cd_roteiro = " + Codigo.ToString();
        System.Data.DataTable dt = BancoDados.Consultar(ComandoSQL);
        if (dt.Rows.Count == 0)
        {
            _codigo = 0;
            _nome = "";
            _imagem = "";
            _destino = "";
            _detalhe = "";
            _mapa = "";
            _data = DateTime.Now;
            _horaminutosegundo = "";
            return false;
        }
        int.TryParse(dt.Rows[0]["cd_roteiro"].ToString(), out _codigo);
        _nome = dt.Rows[0]["nome"].ToString();
        _imagem = dt.Rows[0]["imagem"].ToString();
        _destino = dt.Rows[0]["destino"].ToString();
        _detalhe = dt.Rows[0]["detalhe"].ToString();
        _mapa = dt.Rows[0]["mapa"].ToString();
        _endereco = dt.Rows[0]["endereco"].ToString();
        _data = DateTime.Parse(dt.Rows[0]["data"].ToString());
        _horaminutosegundo = String.Format("{0:HH:mm:ss}", DateTime.Parse(dt.Rows[0]["data"].ToString()));
        return true;
    }

    public static System.Data.DataTable Listar()
    {
        string comandoSQL = "SELECT * FROM roteiro order by nome, data asc";
        return BancoDados.Consultar(comandoSQL);
    }

    public static System.Data.DataTable ListarImagem(string snome)
    {
        string comandoSQL = "SELECT * FROM roteiro where nome = '" + snome + "' order by nome, data asc ";
        return BancoDados.Consultar(comandoSQL);
    }
}