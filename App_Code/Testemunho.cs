using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Testemunho
{
    private int _codigo;
    private string _nome;
    private string _testemunho;
    private string _imagem;
    private string _imagem1;

	public Testemunho()	{}

    public int Codigo { get { return _codigo; } set { _codigo = value; } }
    public string Nome { get { return _nome; } set { _nome = value; } }
    public string TestemunhoTexto { get { return _testemunho; } set { _testemunho = value; } }
    public string Imagem { get { return _imagem; } set { _imagem = value; } }
    public string Imagem1 { get { return _imagem1; } set { _imagem1 = value; } }

    public static System.Data.DataTable Listar()
    {
        string comandoSQL = "SELECT * FROM testemunho";
        return BancoDados.Consultar(comandoSQL);
    }
    public static System.Data.DataTable ListarImagemGrande()
    {
        string comandoSQL = "SELECT * FROM testemunho where imagem1 is not null";
        return BancoDados.Consultar(comandoSQL);
    }
    public void Inserir()
    {
        string comandoSQL = "INSERT INTO testemunho ( nome, testemunho ) VALUES ";
        comandoSQL = comandoSQL + "(  '" + _nome + "', '" + _testemunho + "')";
        BancoDados.Executar(comandoSQL);
        comandoSQL = "SELECT max(cd_testemunho) from testemunho";
        this.Codigo = int.Parse(BancoDados.Consultar(comandoSQL).Rows[0][0].ToString());
    }

    public void Atualizar()
    {
        string ComandoSQL = "UPDATE testemunho SET nome = '" + _nome + "', ";
        ComandoSQL = ComandoSQL + " testemunho = '" + _testemunho + "'";
        ComandoSQL = ComandoSQL + " WHERE cd_testemunho = " + _codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }
    public void AtualizarImagem()
    {
        string ComandoSQL = "UPDATE testemunho SET imagem = '" + _imagem + "'";
        ComandoSQL = ComandoSQL + " WHERE cd_testemunho = " + _codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }
    public void AtualizarImagemGrande()
    {
        string ComandoSQL = "UPDATE testemunho SET imagem1 = '" + _imagem1 + "'";
        ComandoSQL = ComandoSQL + " WHERE cd_testemunho = " + _codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }
    public void Excluir()
    {
        string ComandoSQL = "DELETE FROM testemunho WHERE cd_testemunho = " + Codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }
    public bool Carregar(int Codigo)
    {
        string ComandoSQL = "SELECT * FROM testemunho WHERE cd_testemunho = " + Codigo.ToString();
        System.Data.DataTable dt = BancoDados.Consultar(ComandoSQL);
        if (dt.Rows.Count == 0)
        {
            _codigo = 0;
            _nome = "";
            _testemunho = "";
            _imagem = "";
            _imagem1 = "";
            return false;
        }
        int.TryParse(dt.Rows[0]["cd_testemunho"].ToString(), out _codigo);
        _nome = dt.Rows[0]["nome"].ToString();
        _testemunho = dt.Rows[0]["testemunho"].ToString();
        _imagem = dt.Rows[0]["imagem"].ToString();
        _imagem1 = dt.Rows[0]["imagem1"].ToString();
        return true;
    }

    public bool CarregarRandom()
    {
        string comandoSQL = "SELECT max(cd_testemunho) from testemunho";
        int max = int.Parse(BancoDados.Consultar(comandoSQL).Rows[0][0].ToString());

        Random myRandom = new Random();
        int cd_testemunho_aleatorio = myRandom.Next(max) + 1;

        comandoSQL = "SELECT * FROM testemunho WHERE cd_testemunho = " + cd_testemunho_aleatorio.ToString();
        System.Data.DataTable dt = BancoDados.Consultar(comandoSQL);
        while (dt.Rows.Count == 0)
        {
            cd_testemunho_aleatorio = myRandom.Next(max) + 1;
            comandoSQL = "SELECT * FROM testemunho WHERE cd_testemunho = " + cd_testemunho_aleatorio.ToString();
            dt = BancoDados.Consultar(comandoSQL);
        }
        int.TryParse(dt.Rows[0]["cd_testemunho"].ToString(), out _codigo);
        _nome = dt.Rows[0]["nome"].ToString();
        _testemunho = dt.Rows[0]["testemunho"].ToString();
        _imagem = dt.Rows[0]["imagem"].ToString();
        _imagem1 = dt.Rows[0]["imagem1"].ToString();

        return true;
    }
}