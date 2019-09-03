using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Data;

public static class BancoDados
{
    public static DataTable Consultar(string ComandoSQL)
    {
        Database conexao = DatabaseFactory.CreateDatabase("conexaoMySql");
        return conexao.ExecuteDataSet(CommandType.Text, ComandoSQL).Tables[0];
    }

    public static DataSet ConsultarDataSet(string ComandoSQL)
    {
        Database conexao = DatabaseFactory.CreateDatabase("conexaoMySql");
        DataSet retorno = conexao.ExecuteDataSet(CommandType.Text, ComandoSQL);
        retorno.Tables[0].TableName = "tresult";
        return retorno;
    }

    public static bool Executar(string ComandoSQL)
    {
        bool retorno = true;
        Database conexao = DatabaseFactory.CreateDatabase("conexaoMySql");
        //        try
        //        {
            conexao.ExecuteNonQuery(CommandType.Text, ComandoSQL);
        //}
        //        catch (Exception ex)
        //{
        //retorno = false;
        //}
        return retorno;
    }

    public static void LerCampo(DataRow Linha, string NomeCampo, ref int objeto)
    {
        object tmp = objeto;
        LerCampo(Linha, NomeCampo, ref tmp);
        objeto = int.Parse(tmp.ToString());
    }
    public static void LerCampo(DataRow Linha, string NomeCampo, ref string objeto)
    {
        object tmp = objeto;
        LerCampo(Linha, NomeCampo, ref tmp);
        objeto = tmp.ToString();
    }
    public static void LerCampo(DataRow Linha, string NomeCampo, ref DateTime objeto)
    {
        object tmp = objeto;
        LerCampo(Linha, NomeCampo, ref tmp);
        objeto = DateTime.Parse(tmp.ToString());
    }

    public static void LerCampo(DataRow Linha, string NomeCampo, ref object objeto)
    {
        if (objeto is string)
        {
            objeto = Linha[NomeCampo].ToString();
        }
        else if (objeto is int)
        {
            int tmp = 0;
            int.TryParse(Linha[NomeCampo].ToString(), out tmp);
            objeto = tmp;
        }
        else if (objeto is DateTime)
        {
            DateTime tmp = new DateTime();
            DateTime.TryParse(Linha[NomeCampo].ToString(), out tmp);
            objeto = tmp;
        }
    }
}
