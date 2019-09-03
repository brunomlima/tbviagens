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


public class FluxoEmails
{
    private int _codigo;
    private string _titulo;
    private string _corpo;
    private string _sequencia;
    private string _tempo_proximo_envio;
    private string _imagem;
    private string _anexo;
    private string _cd_pacote;


	public FluxoEmails(){}

    public int Codigo { get { return _codigo; } set { _codigo = value; } }
    public string Titulo { get { return _titulo; } set { _titulo = value; } }
    public string Corpo { get { return _corpo; } set { _corpo = value; } }
    public string Sequencia { get { return _sequencia; } set { _sequencia = value; } }
    public string Tempo_Proximo_Envio { get { return _tempo_proximo_envio; } set { _tempo_proximo_envio = value; } }
    public string Imagem { get { return _imagem; } set { _imagem = value; } }
    public string Anexo { get { return _anexo; } set { _anexo = value; } }
    public string Cd_Pacote { get { return _cd_pacote; } set { _cd_pacote = value; } }

    public static System.Data.DataTable Listar(string cd_fluxo_emails)
    {
        string comandoSQL = "SELECT * FROM fluxo_emails where cd_fluxo_emails = " + cd_fluxo_emails;
        return BancoDados.Consultar(comandoSQL);
    }
    public void Inserir()
    {
        string comandoSQL = "INSERT INTO fluxo_emails ( cd_pacote, sequencia, titulo_email, corpo_email, tempo_proximo_envio, imagem,anexo) VALUES ";
        comandoSQL = comandoSQL + "(  '" + _cd_pacote + "', '" + _sequencia + "', '" + _titulo + "', '" + _corpo + "', '" + _tempo_proximo_envio + "', '" + _imagem +"','" + _anexo + "')";
        BancoDados.Executar(comandoSQL);
        comandoSQL = "SELECT max(cd_fluxo_emails) from fluxo_emails";
        this.Codigo = int.Parse(BancoDados.Consultar(comandoSQL).Rows[0][0].ToString());
    }

    public void Atualizar()
    {
        string ComandoSQL = "UPDATE fluxo_emails SET cd_pacote = '" + _cd_pacote + "', ";
        ComandoSQL = ComandoSQL + " sequencia = '" + _sequencia + "',";
        ComandoSQL = ComandoSQL + " titulo_email = '" + _titulo + "',";
        ComandoSQL = ComandoSQL + " corpo_email = '" + _corpo + "',";
        ComandoSQL = ComandoSQL + " tempo_proximo_envio = '" + _tempo_proximo_envio + "',";
        ComandoSQL = ComandoSQL + " imagem = '" + _imagem + "',";
        ComandoSQL = ComandoSQL + " anexo = '" + _anexo + "'";
        ComandoSQL = ComandoSQL + " WHERE cd_fluxo_emails = " + _codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }

    public void AtualizarEmail()
    {
        string ComandoSQL = "UPDATE fluxo_emails SET ";
        ComandoSQL = ComandoSQL + " sequencia = '" + _sequencia + "',";
        ComandoSQL = ComandoSQL + " titulo_email = '" + _titulo + "',";
        ComandoSQL = ComandoSQL + " corpo_email = '" + _corpo + "',";
        ComandoSQL = ComandoSQL + " tempo_proximo_envio = '" + _tempo_proximo_envio + "'";
        ComandoSQL = ComandoSQL + " WHERE cd_fluxo_emails = " + _codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }  

    public void AtualizarImagem()
    {
        string ComandoSQL = "UPDATE fluxo_emails SET imagem = '" + _imagem + "' ";
        ComandoSQL = ComandoSQL + " WHERE cd_fluxo_emails = " + _codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }
    public void AtualizarAnexo()
    {
        string ComandoSQL = "UPDATE fluxo_emails SET anexo = '" + _anexo + "' ";
        ComandoSQL = ComandoSQL + " WHERE cd_fluxo_emails = " + _codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }
    public void Excluir()
    {
        string ComandoSQL = "DELETE FROM fluxo_emails WHERE cd_fluxo_emails = " + Codigo.ToString();
        BancoDados.Executar(ComandoSQL);
    }

    public bool Carregar(int Codigo)
    {
        string ComandoSQL = "SELECT * FROM fluxo_emails WHERE cd_fluxo_emails = " + Codigo.ToString();
        System.Data.DataTable dt = BancoDados.Consultar(ComandoSQL);
        if (dt.Rows.Count == 0)
        {
            _codigo = 0;
            _titulo = "";
            _corpo = "";
            _sequencia = "";
            _tempo_proximo_envio = "";
            _imagem = "";
            _anexo = "";
            _cd_pacote = "";
            return false;
        }
        int.TryParse(dt.Rows[0]["cd_fluxo_emails"].ToString(), out _codigo);
        _titulo = dt.Rows[0]["titulo_email"].ToString();
        _corpo = dt.Rows[0]["corpo_email"].ToString();
        _sequencia = dt.Rows[0]["sequencia"].ToString();
        _tempo_proximo_envio = dt.Rows[0]["tempo_proximo_envio"].ToString();
        _imagem = dt.Rows[0]["imagem"].ToString();
        _anexo = dt.Rows[0]["anexo"].ToString();
        _cd_pacote = dt.Rows[0]["cd_pacote"].ToString();
        return true;
    }

    public static System.Data.DataTable Listar()
    {
        string comandoSQL = "SELECT * FROM fluxo_emails order by cd_pacote, sequencia";
        return BancoDados.Consultar(comandoSQL);
    }
    public static System.Data.DataTable ListarPacote(string cd_pacote)
    {
        string comandoSQL = "SELECT * FROM fluxo_emails where cd_pacote = '"+ cd_pacote +"' order by cd_pacote, sequencia";
        return BancoDados.Consultar(comandoSQL);
    }
}