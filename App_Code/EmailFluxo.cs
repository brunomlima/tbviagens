using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class EmailFluxo
{
    private int _codigo;
    private string _email;
    private string _nome;
    private int _cd_pacote;
    private int _cd_email;
    private string _titulo_email;
    private string _corpo_email;
    private string _anexo;
    private string _imagem;


	public EmailFluxo()	{}

    public int Codigo { get { return _codigo; } set { _codigo = value; } }
    public string Email { get { return _email; } set { _email = value; } }
    public string Nome { get { return _nome; } set { _nome = value; } }
    public int Cd_Pacote { get { return _cd_pacote; } set { _cd_pacote = value; } }
    public int Cd_Email { get { return _cd_email; } set { _cd_email = value; } }
    public string Titulo_Email { get { return _titulo_email; } set { _titulo_email = value; } }
    public string Corpo_Email { get { return _corpo_email; } set { _corpo_email = value; } }
    public string Anexo { get { return _anexo; } set { _anexo = value; } }
    public string Imagem { get { return _imagem; } set { _imagem = value; } }

    
    public static System.Data.DataTable Listar(string cd_agendador)
    {
        string comandoSQL = "SELECT * FROM agendador where cd_agendador = " + cd_agendador + " order by nome";
        return BancoDados.Consultar(comandoSQL);
    }

    public void InserirNoAgendador()
    {
    string comandoSQL = "INSERT INTO agendador ( cd_pacote , cd_email , cd_fluxo_emails , data_envio , status ) ";
           comandoSQL = comandoSQL + "select pacote.cd_pacote,email_mkt.cd_email,fluxo_emails.cd_fluxo_emails,date(ADDDATE( now(), INTERVAL fluxo_emails.tempo_proximo_envio DAY)) AS DT_ENVIO, 'N' as status ";
           comandoSQL = comandoSQL + " from email_mkt , pacote, fluxo_emails ";
           comandoSQL = comandoSQL + " where pacote.cd_pacote = fluxo_emails.cd_pacote and ";
           comandoSQL = comandoSQL + " pacote.cd_pacote = "+ _cd_pacote +" and "; 
           comandoSQL = comandoSQL + " email_mkt.cd_email = " + _cd_email;
           comandoSQL = comandoSQL + " order by fluxo_emails.sequencia";
        BancoDados.Executar(comandoSQL);
        comandoSQL = "select cd_agendador from agendador where data_envio = date(now()) and status = 'N' ";
        this.Codigo = int.Parse(BancoDados.Consultar(comandoSQL).Rows[0][0].ToString());
    }

    public bool Carregar()
    {
        string ComandoSQL = "select agendador.cd_agendador,agendador.cd_pacote,agendador.cd_email,fluxo_emails.titulo_email,fluxo_emails.corpo_email, fluxo_emails.anexo, fluxo_emails.imagem, ";
               ComandoSQL = ComandoSQL + "email_mkt.email, email_mkt.nome ";
               ComandoSQL = ComandoSQL + "from agendador, email_mkt, fluxo_emails ";
               ComandoSQL = ComandoSQL + "where agendador.cd_fluxo_emails = fluxo_emails.cd_fluxo_emails and ";
               ComandoSQL = ComandoSQL + "agendador.cd_email = email_mkt.cd_email and ";
               ComandoSQL = ComandoSQL + "agendador.data_envio = date(now()) and status = 'N' and ";
               ComandoSQL = ComandoSQL + "agendador.cd_agendador = " + Codigo.ToString();
        
        System.Data.DataTable dt = BancoDados.Consultar(ComandoSQL);
        if (dt.Rows.Count == 0)
        {
            _codigo = 0;
            _email = "";
            _nome = "";
            return false;
        }
        int.TryParse(dt.Rows[0]["cd_agendador"].ToString(), out _codigo);
        _email = dt.Rows[0]["email"].ToString();
        _nome = dt.Rows[0]["nome"].ToString();
        int.TryParse(dt.Rows[0]["cd_pacote"].ToString(), out _cd_pacote);
        int.TryParse(dt.Rows[0]["cd_email"].ToString(), out _cd_email);
        _titulo_email = dt.Rows[0]["titulo_email"].ToString();
        _corpo_email = dt.Rows[0]["corpo_email"].ToString();
        _anexo = dt.Rows[0]["anexo"].ToString();
        _imagem = dt.Rows[0]["imagem"].ToString();
        return true;
    }

    public void AtualizarStatusEmailEnviado(string Status,string codigo)
    {
        string ComandoSQL = "UPDATE agendador SET status = '"+ Status +"' ";
               ComandoSQL = ComandoSQL + " WHERE cd_agendador = " + codigo;
        BancoDados.Executar(ComandoSQL);
    }

    public bool Valida()
    {
        string ComandoSQL = "SELECT * FROM agendador WHERE cd_email = '" + _cd_email + "' AND cd_pacote = '" + _cd_pacote + "'";
        System.Data.DataTable dt = BancoDados.Consultar(ComandoSQL);
        if (dt.Rows.Count == 0)
        {
            return false;
        }
        int.TryParse(dt.Rows[0]["cd_agendador"].ToString(), out _codigo);
        return true;
    }

    public static System.Data.DataTable Listar()
    {
        string ComandoSQL = "select agendador.cd_agendador, agendador.cd_pacote, agendador.cd_email, fluxo_emails.titulo_email, fluxo_emails.corpo_email, fluxo_emails.anexo, fluxo_emails.imagem, ";
        ComandoSQL = ComandoSQL + "email_mkt.email, email_mkt.nome ";
        ComandoSQL = ComandoSQL + "from agendador, email_mkt, fluxo_emails  ";
        ComandoSQL = ComandoSQL + "where agendador.cd_fluxo_emails = fluxo_emails.cd_fluxo_emails and ";
        ComandoSQL = ComandoSQL + "agendador.cd_email = email_mkt.cd_email and ";
        ComandoSQL = ComandoSQL + "agendador.data_envio <= date(now()) and status = 'N'";
        System.Data.DataTable dt = BancoDados.Consultar(ComandoSQL);
        return BancoDados.Consultar(ComandoSQL);
    }

}