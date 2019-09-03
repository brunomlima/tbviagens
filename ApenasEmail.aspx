<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ApenasEmail.aspx.cs" Inherits="ApenasEmail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="txtLimpo">
    
        <asp:LinkButton ID="LinkButton1" runat="server" 
            PostBackUrl="https://word2cleanhtml.com/">Exemplo</asp:LinkButton>
        <br />
    
        <asp:TextBox ID="TextBox1" runat="server" Height="387px" TextMode="MultiLine" 
            Width="741px">TextBox1.Text</asp:TextBox>
    
        <br />
        </div>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Limpa string" 
        Height="45px" Width="752px" />
    <br />
        <asp:TextBox ID="TextBox2" runat="server" Height="387px" 
             TextMode="MultiLine" Width="742px"></asp:TextBox>
    
    </form>
</body>
</html>
