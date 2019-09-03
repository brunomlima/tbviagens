<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NomeEmail.aspx.cs" Inherits="NomeEmail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1
        {
            height: 385px;
            width: 422px;
        }
        #Text2
        {
            width: 422px;
            height: 383px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="txtLimpo">
    
        <asp:LinkButton ID="LinkButton1" runat="server" 
            PostBackUrl="https://www.cremesp.org.br/?siteAcao=GuiaMedico&amp;pesquisa=proc">Conselho Regional de Medicina do Estado de São Paulo</asp:LinkButton>
        <br />
    
        <asp:TextBox ID="TextBox1" runat="server" Height="387px" TextMode="MultiLine" 
            Width="741px"></asp:TextBox>
    
        <br />
        </div>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Copiar Apenas Nome e E-mail" 
        Height="45px" Width="752px" />
    <br />
        <asp:TextBox ID="TextBox2" runat="server" Height="387px" 
             TextMode="MultiLine" Width="742px"></asp:TextBox>
    
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
