<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1> Para acessar a área restrita efetue o login </h1>
    
    <table width="100%" border="1" cellspacing="1" cellpadding="1" align="center">
  <tr>
    <td align=center>


    <br />
    <table style="width: 700" >
        <tr>
            <td style="width: 49px">
                CPF:</td>
            <td>
    <asp:TextBox ID="txtLogin" runat="server" CssClass="button"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 49px">
                Senha:</td>
            <td class="button">
    <asp:TextBox ID="txtSenha" runat="server" TextMode="Password" CssClass="button"></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />
    <asp:Button ID="btnLogin" runat="server" Text="Entrar" 
    onclick="btnLogin_Click" />
    <br />    
    <br />
<asp:Label ID="lblResultado" runat="server"></asp:Label>
    <br />
    <br />
    Esqueceu a senha <a href="RecuperandoLogin.aspx">clique aqui</a> para recuperar.<br />

        </td>
  </tr>
</table>

</asp:Content>

