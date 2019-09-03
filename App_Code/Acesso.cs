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

public class Acesso
{
	public Acesso()
	{
	}
    public static System.Data.DataTable ListarLiberados(string cd_usuario)
    {
        string comandoSQL = "select m.cd_modulo,m.nome nome_modulo ";
        comandoSQL = comandoSQL + "from usuario u, acessos a, modulo m ";
        comandoSQL = comandoSQL + "where u.cd_usuario = a.cd_usuario and ";
        comandoSQL = comandoSQL + "a.cd_modulo = m.cd_modulo and ";
        comandoSQL = comandoSQL + "u.cd_usuario = " + cd_usuario;
        return BancoDados.Consultar(comandoSQL);
    }
    public static System.Data.DataTable ListarBloqueados(string cd_usuario)
    {
        string comandoSQL = "select cd_modulo, nome nome_modulo from modulo where cd_modulo not in (select cd_modulo from acessos where cd_usuario = " + cd_usuario + " )";
        return BancoDados.Consultar(comandoSQL);
    }
    
    public void Revogar(string cd_usuario, string cd_modulo)
    {
        string ComandoSQL = "DELETE FROM acessos WHERE cd_usuario = " + cd_usuario + " and cd_modulo = " + cd_modulo;
        BancoDados.Executar(ComandoSQL);
    }   
    public void Conceder(string cd_usuario, string cd_modulo)
    {
        string comandoSQL = "INSERT INTO acessos ( cd_usuario, cd_modulo ) VALUES ";
        comandoSQL = comandoSQL + "(  '" + cd_usuario + "', '" + cd_modulo + "')";
        BancoDados.Executar(comandoSQL);
    }
}
