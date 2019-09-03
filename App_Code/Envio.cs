using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Envio
{

    private string _qtd_enviada;
    private string _qtd_Nao_enviada;

    public string QtdEnviada { get { return _qtd_enviada; } set { _qtd_enviada = value; } }
    public string QtdNAOEnviada { get { return _qtd_Nao_enviada; } set { _qtd_Nao_enviada = value; } }


	public Envio()
	{
	}

    public bool Carregar(string cd_pacote)
    {
        string ComandoSQL = "select  count(1) as QtdEnviadas";
        ComandoSQL = ComandoSQL + " from envio, email_mkt , pacote";
        ComandoSQL = ComandoSQL + " where envio.cd_email = email_mkt.cd_email and";
        ComandoSQL = ComandoSQL + " envio.cd_pacote = pacote.cd_pacote and";
        ComandoSQL = ComandoSQL + " pacote.cd_pacote = " + cd_pacote;
        System.Data.DataTable dt = BancoDados.Consultar(ComandoSQL);
        if (dt.Rows.Count == 0)
        {
            _qtd_enviada = "";
            return false;
        }
        _qtd_enviada = dt.Rows[0]["QtdEnviadas"].ToString();

        ComandoSQL = "select count(1) as QtdNaoEnviadas from email_mkt where cd_email not in (select cd_email from envio where cd_pacote = " + cd_pacote + ")";
        System.Data.DataTable dts = BancoDados.Consultar(ComandoSQL);
        if (dts.Rows.Count == 0)
        {
            _qtd_Nao_enviada = "";
            return false;
        }
        _qtd_Nao_enviada = dts.Rows[0]["QtdNaoEnviadas"].ToString();

        return true;
    }
    public static System.Data.DataTable ListarEnviados(string cd_pacote)
    {
        string comandoSQL = "select email_mkt.cd_email,email_mkt.nome, email_mkt.email"; 
        comandoSQL = comandoSQL + " from envio, email_mkt , pacote";
        comandoSQL = comandoSQL + " where envio.cd_email = email_mkt.cd_email and";
        comandoSQL = comandoSQL + " envio.cd_pacote = pacote.cd_pacote and";
        comandoSQL = comandoSQL + " pacote.cd_pacote = " + cd_pacote + " order by email_mkt.nome desc";

        return BancoDados.Consultar(comandoSQL);
    }

    public static System.Data.DataTable ListarNaoEnviados(string cd_pacote)
    {
        string comandoSQL = "select email_mkt.cd_email,email_mkt.nome, email_mkt.email from email_mkt where cd_email not in (select cd_email from envio where cd_pacote = " + cd_pacote + ")" + " order by email_mkt.nome";
        
        return BancoDados.Consultar(comandoSQL);
    }


    public void Reenvia(string cd_email, string cd_pacote)
    {
        string ComandoSQL = "DELETE FROM envio WHERE cd_email = " + cd_email + " and cd_pacote = " + cd_pacote;
        BancoDados.Executar(ComandoSQL);
    }

    public void Envia(string cd_email, string cd_pacote, string cd_agendador)
    {
        string comandoSQL = "INSERT INTO envio ( cd_email,  cd_pacote, cd_agendador , dt_envio ) VALUES ";
        comandoSQL = comandoSQL + "(  '" + cd_email + "', '" + cd_pacote + "', '" + cd_agendador + "', Now())";
        BancoDados.Executar(comandoSQL);
    }
       public void Envia(string cd_email, string cd_pacote)
    {
        string comandoSQL = "INSERT INTO envio ( cd_email, cd_pacote, dt_envio ) VALUES ";
        comandoSQL = comandoSQL + "(  '" + cd_email + "', '" + cd_pacote + "', Now())";
        BancoDados.Executar(comandoSQL);
    }
}