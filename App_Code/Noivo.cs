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
using System.Globalization;

public class Noivo
{
    private int _codigo;
    private int _cd_pacote;
    private string _nome_noivos;
    private string _mensagem;
    private string _tipo_cota;
    private string _caminhoimagem;
    private string _banco;
    private string _agencia;
    private string _conta_corrente;
    private string _favorecido;
    private string _cpf;
    private string _email_noiva;
    private string _email_noivo;
    private DateTime _dt_casamento;
    private string _valor1;
    private string _valor2;
    private string _valor3;
    private string _valor4;
    private string _valor5;

    public Noivo()	{}

        public int Codigo { get { return _codigo; } set { _codigo = value; } }
        public int CdPacote { get { return _cd_pacote; } set { _cd_pacote = value; } }
        public string Nome_Noivos{ get { return _nome_noivos; } set { _nome_noivos = value; } }
        public string Mensagem { get { return _mensagem; } set { _mensagem = value; } }
        public string TipoCota { get { return _tipo_cota; } set { _tipo_cota = value; } }
        public string CaminhoImagem { get { return _caminhoimagem; } set { _caminhoimagem = value; } }
        public string Banco { get { return _banco; } set { _banco = value; } }
        public string Agencia { get { return _agencia; } set { _agencia = value; } }
        public string ContaCorrente { get { return _conta_corrente; } set { _conta_corrente = value; } }
        public string Favorecido { get { return _favorecido; } set { _favorecido = value; } }
        public string Cpf { get { return _cpf; } set { _cpf = value; } }
        public string EmaiNoiva { get { return _email_noiva; } set { _email_noiva = value; } }
        public string EmailNoivo { get { return _email_noivo; } set { _email_noivo = value; } }
        public DateTime DtCasamento { get { return _dt_casamento; } set { _dt_casamento = value; } }
        public string Valor1 { get { return _valor1; } set { _valor1 = value; } }
        public string Valor2 { get { return _valor2; } set { _valor2 = value; } }
        public string Valor3 { get { return _valor3; } set { _valor3 = value; } }
        public string Valor4 { get { return _valor4; } set { _valor4 = value; } }
        public string Valor5 { get { return _valor5; } set { _valor5 = value; } }

    public static System.Data.DataTable Listar(string cd_noivo)
    {
        string comandoSQL = "SELECT * FROM noivo where cd_noivo = " + cd_noivo + " order by data_casamento";
        return BancoDados.Consultar(comandoSQL);
    }
    public void Inserir()
    {
        string comandoSQL = "INSERT INTO noivo (nome_noivos,data_casamento,banco,agencia,conta_corrente,favorecido,cpf,email_noivo,email_noiva,foto,mensagem,cd_pacote, tipo_cota, valor1,valor2,valor3,valor4,valor5) VALUES ";
        comandoSQL = comandoSQL + "(  '" + _nome_noivos + "', '" + _dt_casamento.ToString("yyyy/MM/dd") + "', '" + _banco + "', '" + _agencia + "', '" + _conta_corrente + "', '" + _favorecido + "', '" + _cpf + "', '" + _email_noivo + "', '" + _email_noiva + "', '" + _caminhoimagem + "', '" + _mensagem + "', '" + _cd_pacote + "', '" + _tipo_cota.ToUpper() + "', '" + _valor1 + "', '" + _valor2 + "', '" + _valor3 + "', '" + _valor4 + "', '" + _valor5 + "')";
        BancoDados.Executar(comandoSQL);
        comandoSQL = "SELECT max(cd_noivo) from noivo";
        this.Codigo = int.Parse(BancoDados.Consultar(comandoSQL).Rows[0][0].ToString());
    }

    public void Atualizar()
    {
        string ComandoSQL = "UPDATE noivo SET mensagem = '" + _mensagem + "', ";
        ComandoSQL = ComandoSQL + " nome_noivos = '" + _nome_noivos + "',";
        ComandoSQL = ComandoSQL + " tipo_cota = '" + _tipo_cota.ToUpper() + "',";
        ComandoSQL = ComandoSQL + " banco = '" + _banco + "',";
        ComandoSQL = ComandoSQL + " agencia = '" + _agencia + "',";
        ComandoSQL = ComandoSQL + " conta_corrente = '" + _conta_corrente + "',";
        ComandoSQL = ComandoSQL + " favorecido = '" + _favorecido + "',";
        ComandoSQL = ComandoSQL + " cpf = '" + _cpf + "',";
        ComandoSQL = ComandoSQL + " email_noivo = '" + _email_noivo + "',";
        ComandoSQL = ComandoSQL + " email_noiva = '" + _email_noiva + "',";
        ComandoSQL = ComandoSQL + " valor1 = '" + _valor1 + "',";
        ComandoSQL = ComandoSQL + " valor2 = '" + _valor2 + "',";
        ComandoSQL = ComandoSQL + " valor3 = '" + _valor3 + "',";
        ComandoSQL = ComandoSQL + " valor4 = '" + _valor4 + "',";
        ComandoSQL = ComandoSQL + " valor5 = '" + _valor5 + "',";
        ComandoSQL = ComandoSQL + " cd_pacote = '" + _cd_pacote + "',";
        ComandoSQL = ComandoSQL + " data_casamento = '" + _dt_casamento.ToString("yyyy/MM/dd") + "'";
        ComandoSQL = ComandoSQL + " WHERE cd_noivo = " + _codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }

    public void AtualizarImagem()
    {
        string ComandoSQL = "UPDATE noivo SET foto = '" + _caminhoimagem + "' ";
        ComandoSQL = ComandoSQL + " WHERE cd_noivo = " + _codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }
    public void Excluir()
    {
        string ComandoSQL = "DELETE FROM noivo WHERE cd_noivo = " + Codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }

    public bool Carregar(int Codigo)
    {
        string ComandoSQL = "SELECT * FROM noivo WHERE cd_noivo = " + Codigo.ToString();
        System.Data.DataTable dt = BancoDados.Consultar(ComandoSQL);
        if (dt.Rows.Count == 0)
        {
            _codigo = 0;
            _mensagem = "";
            _nome_noivos = "";
            _caminhoimagem = "";
            _tipo_cota = "";
            _banco = "";
            _agencia = "";
            _conta_corrente = "";
            _cpf = "";
            _dt_casamento = DateTime.Now;
            _email_noiva = "";
            _cd_pacote = 0;
            _valor1 = "";
            _valor2 = "";
            _valor3 = "";
            _valor4 = "";
            _valor5 = "";            
            return false;
        }
        int.TryParse(dt.Rows[0]["cd_noivo"].ToString(), out _codigo);
        _mensagem = dt.Rows[0]["mensagem"].ToString();
        _nome_noivos = dt.Rows[0]["nome_noivos"].ToString();
        _email_noiva = dt.Rows[0]["email_noiva"].ToString();
        _email_noivo = dt.Rows[0]["email_noivo"].ToString();
        _tipo_cota = dt.Rows[0]["tipo_cota"].ToString();
        _caminhoimagem = dt.Rows[0]["foto"].ToString();
        _banco = dt.Rows[0]["banco"].ToString();
        _agencia = dt.Rows[0]["agencia"].ToString();
        _conta_corrente = dt.Rows[0]["conta_corrente"].ToString();
        _favorecido = dt.Rows[0]["favorecido"].ToString();
        _cpf = dt.Rows[0]["cpf"].ToString();
        _dt_casamento = DateTime.Parse(dt.Rows[0]["data_casamento"].ToString());
        _cd_pacote = int.Parse(dt.Rows[0]["cd_pacote"].ToString());
        _valor1 = dt.Rows[0]["valor1"].ToString();
        _valor2 = dt.Rows[0]["valor2"].ToString();
        _valor3 = dt.Rows[0]["valor3"].ToString();
        _valor4 = dt.Rows[0]["valor4"].ToString();
        _valor5 = dt.Rows[0]["valor5"].ToString();
        return true;
    }

    public static System.Data.DataTable Listar()
    {
        string comandoSQL = "SELECT * FROM noivo order by data_casamento desc";
        return BancoDados.Consultar(comandoSQL);
    }

    public static System.Data.DataTable ListarConvidados(string Codigo)
    {
        string comandoSQL = "SELECT convidado.nome,convidado.mensagem, convidado.dt_msg FROM noivo, convidado where noivo.cd_noivo = convidado.cd_noivo  and noivo.cd_noivo = "+Codigo+" order by dt_msg desc";
        return BancoDados.Consultar(comandoSQL);
    }
}