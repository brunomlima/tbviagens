using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UltimoCaptcha : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["EMAIL"])) ctl00_lblUserName.Text = Request.QueryString["EMAIL"].ToString();
        if (!string.IsNullOrEmpty(Request.QueryString["CODIGO"])) ctl00_lblIdCittadino.Text = Request.QueryString["CODIGO"].ToString();
        if (!string.IsNullOrEmpty(Request.QueryString["DATA"])) ctl00_ContentPlaceHolder1_lblDataSelezionata.Text = Request.QueryString["DATA"].ToString();
    }
}