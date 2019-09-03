<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VisualizaEmailMarketing.aspx.cs" Inherits="VisualizaEmailMarketing" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html dir="ltr">
<head>

    <style type="text/css">
        .style1
        {
            font-family: Arial, Helvetica, sans-serif;
        }
        .style2
        {
            font-size: small;
        }
      
        .style4
        {
            width: 623px;
        }
        .style5
        {
            width: 646px;
        }
      
    </style>
    

</head>


<body bgcolor="#DCDCDC" marginwidth="0" marginheight="0" spellcheck="false" 
    topmargin="0" leftmargin="0" >


    <form id="form1" runat="server">


<table cellspacing="0" cellpadding="0" border="0" width="100%" >
<tr><td style="text-align: center">
    <asp:TextBox ID="txtEmail" runat="server" Width="300px"></asp:TextBox>
    <asp:Button ID="btnEnviar" runat="server" Text="Enviar e-mail" 
        onclick="btnEnviar_Click" />
</td></tr>
<tr><td align="center"><font size="1" face="Verdana">
Problemas para visualizar a mensagem? 
<% Response.Write("<a href='http://www.tbviagens.com.br/VisualizaEmailMarketing.aspx?cd_pacote=" + Request.QueryString["CD_PACOTE"].ToString());
    Response.Write(" ''>Acesse este link.</a>" ); %>
</td></tr>  
</table>
<table cellspacing="0" cellpadding="0" border="0" width="100%">
<tr align="center"><td align="center"><font size="1" face="Verdana">
</td></tr>
</table>
<center>
<table width="700" cellspacing="0" cellpadding="0" border="1" id="Table_2">

<tr align="center">
  <td bgcolor="White" class="style4"><img src='http://www.tbviagens.com.br/img/logo_tbviagens.png' 
          width='300' height='50' style="float: left"><br />
      <span class="style2"><a href="http://www.tbviagens.com.br">www.tbviagens.com.br</a></span><br>
      <span class="style1"><strong>(11) 2305-3530</strong></span></td>
</tr>
</table>
<table width="700" cellspacing="0" cellpadding="0" border="1" id="Table_01">
<tbody>
<tr>
<td bgcolor="#84C225" align="center" class="style5">
 <asp:Label ID="lblTitulo" runat="server" Font-Size="X-Large" ForeColor="White"></asp:Label>



</td>
<tr align="center" bgcolor="#FFFFFF">
<td bgcolor="White" align="center" class="style5">
 <asp:Label ID="lblResumo" runat="server" Font-Size="X-Large" ForeColor="Black"></asp:Label>



</td>

</tr>

<tr align="center" bgcolor="#FFFFFF">
  <td class="style5">
  
      <br />
    <asp:Image ID="imgPacote" runat="server" Height="300px" Width="500px" />
      <br />
    <br>
</td>
</tr>

<tr align="left">
  <td bgcolor="White" class="style5">     <%   
    Pacote pc = new Pacote();
    pc.Carregar(int.Parse(Request.QueryString["CD_PACOTE"].ToString()));
    lblTitulo.Text = pc.Titulo.ToString();
    lblResumo.Text = pc.Resumo.ToString();           
    Response.Write(pc.Detalhe);
    
  %> </td>
</tr>

</tbody>
</table>
</center>

<br>
<table cellspacing="0" cellpadding="0" border="0" width="100%">
<tr><td height="20" align="center"><font size="1" face="Verdana">
Não deseja mais receber nossas mensagens? <a href="http://www.tbviagens.com.br/CancelamentoEmailMarketing.aspx">Acesse este link.</a>
</td></tr>
</table>
    </form>
</body>
</html>
