using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Obrigado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!string.IsNullOrEmpty(Session["nome_cliente"].ToString())) lblNome.Text = Session["nome_cliente"].ToString();

    }
    protected void btnGravar_Click(object sender, EventArgs e)
    {

    }
}