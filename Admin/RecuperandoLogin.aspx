<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="RecuperandoLogin.aspx.cs" Inherits="Admin_RecuperandoLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h1> Informe seu CPF para receber um e-mail com sua senha. </h1>
    <br />
    <table style="width: 100%">
        <tr>
            <td style="width: 49px">
                CPF:</td>
            <td>
    <asp:TextBox ID="txtLogin" runat="server" CssClass="button"></asp:TextBox>
            </td>
        </tr>
        </table>
    <br />
    <asp:Button ID="btnEnviarEmail" runat="server" Text="Enviar" 
        onclick="btnEnviarEmail_Click" />
    <br />    
    <br />
<asp:Label ID="lblResultado" runat="server"></asp:Label>
<br />
</asp:Content>

