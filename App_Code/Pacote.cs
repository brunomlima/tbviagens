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

public class Pacote
{
    private int _codigo;
    private string _titulo;
    private string _resumo;
    private string _detalhe;
    private string _caminhoimagem;
    private string _tipo;
    private string _caminhoimagem1;

    public Pacote()	{}

    public int Codigo { get { return _codigo; } set { _codigo = value; } }
    public string Titulo { get { return _titulo; } set { _titulo = value; } }
    public string Resumo { get { return _resumo; } set { _resumo = value; } }
    public string Detalhe { get { return _detalhe; } set { _detalhe = value; } }
    public string CaminhoImagem { get { return _caminhoimagem; } set { _caminhoimagem = value; } }
    public string Tipo { get { return _tipo; } set { _tipo = value; } }
    public string CaminhoImagem1 { get { return _caminhoimagem1; } set { _caminhoimagem1 = value; } }

    public static System.Data.DataTable Listar(string cd_pacote)
    {
        string comandoSQL = "SELECT * FROM pacote where cd_pacote = " + cd_pacote;
        return BancoDados.Consultar(comandoSQL);
    }
    public void Inserir()
    {
        string comandoSQL = "INSERT INTO pacote ( titulo, resumo) VALUES ";
        comandoSQL = comandoSQL + "(  '" + _titulo + "', '" + _resumo + "')";
        BancoDados.Executar(comandoSQL);
        comandoSQL = "SELECT max(cd_pacote) from pacote";
        this.Codigo = int.Parse(BancoDados.Consultar(comandoSQL).Rows[0][0].ToString());
    }

    public void Atualizar()
    {
        string ComandoSQL = "UPDATE pacote SET resumo = '" + _resumo + "', ";
        ComandoSQL = ComandoSQL + " titulo = '" + _titulo + "'";
        ComandoSQL = ComandoSQL + " WHERE cd_pacote = " + _codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }
    public void AtualizarDetalhe()
    {
        string ComandoSQL = "UPDATE pacote SET detalhe = '" + _detalhe + "',";
        ComandoSQL = ComandoSQL + " tipo = '" + _tipo.ToUpper() + "'";
        ComandoSQL = ComandoSQL + " WHERE cd_pacote = " + _codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }

    public void AtualizarImagem()
    {
        string ComandoSQL = "UPDATE pacote SET caminhoimagem = '" + _caminhoimagem + "' ";
        ComandoSQL = ComandoSQL + " WHERE cd_pacote = " + _codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }
    public void AtualizarImagem1()
    {
        string ComandoSQL = "UPDATE pacote SET caminhoimagem1 = '" + _caminhoimagem1 + "' ";
        ComandoSQL = ComandoSQL + " WHERE cd_pacote = " + _codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }
    public void Excluir()
    {
        string ComandoSQL = "DELETE FROM pacote WHERE cd_pacote = " + Codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }

    public bool Carregar(int Codigo)
    {
        string ComandoSQL = "SELECT * FROM pacote WHERE cd_pacote = " + Codigo.ToString();
        System.Data.DataTable dt = BancoDados.Consultar(ComandoSQL);
        if (dt.Rows.Count == 0)
        {
            _codigo = 0;
            _resumo = "";
            _titulo = "";
            _detalhe = "";
            _caminhoimagem = "";
            _caminhoimagem1 = "";
            _tipo = "";
            return false;
        }
        int.TryParse(dt.Rows[0]["cd_pacote"].ToString(), out _codigo);
        _resumo = dt.Rows[0]["resumo"].ToString();
        _titulo = dt.Rows[0]["titulo"].ToString();
        _detalhe = dt.Rows[0]["detalhe"].ToString();
        _caminhoimagem = dt.Rows[0]["caminhoimagem"].ToString();
        _caminhoimagem1 = dt.Rows[0]["caminhoimagem1"].ToString();
        _tipo = dt.Rows[0]["tipo"].ToString();
        return true;
    }

    public static System.Data.DataTable Listar()
    {
        string comandoSQL = "SELECT * FROM pacote";
        return BancoDados.Consultar(comandoSQL);
    }

   
    public static System.Data.DataTable ListarPorTipo(string sTipo)
    {
        string comandoSQL = "SELECT * FROM pacote where tipo = '"+sTipo+"'  order by cd_pacote desc";
        return BancoDados.Consultar(comandoSQL);
    }

    public static System.Data.DataTable ListarPorCodigo(int sCodigo)
    {
        string comandoSQL = "SELECT * FROM pacote where cd_pacote = '" + sCodigo.ToString() + "' ";
        return BancoDados.Consultar(comandoSQL);
    }

    public static System.Data.DataTable ListarTudo(string sPesquisa, string sTipo, string opcao)
    {
        string comandoSQL = "";
        if (opcao == "Código")
        {
            comandoSQL = "SELECT * FROM pacote where titulo like '%" + sPesquisa.ToString() + "%' and tipo = '" + sTipo + "' order by resumo";
        }
        else if (opcao == "Descrição")
        {
            comandoSQL = "SELECT * FROM pacote where resumo like '%" + sPesquisa.ToString() + "%' and tipo = '" + sTipo + "' order by resumo";
        }
        return BancoDados.Consultar(comandoSQL);
    }
}