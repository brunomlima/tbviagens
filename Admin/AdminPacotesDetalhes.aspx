<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="AdminPacotesDetalhes.aspx.cs" Inherits="Admin_AdminPacotesDetalhes" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit.HTMLEditor" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            height: 28px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>

    <asp:Label ID="lblTitulo" runat="server" CssClass="content1-pagetitle"></asp:Label>

 
    <asp:Label ID="lblCodigo" runat="server" CssClass="content1-pagetitle" Visible="False"></asp:Label>


    <cc1:Editor ID="Editor1" runat="server" 
        Height="900px" Width="100%" />
          <table style="width: 100%">               
                             <td class="style1">
                             Tipo:
                             <asp:TextBox ID="txtTipo" runat="server" Width="20px" MaxLength="1"></asp:TextBox>
                                 P = Pacote | E = E-mail</td>
           </table> 


    <asp:Button ID="btbGravar" runat="server" Text="Gravar" onclick="btbGravar_Click" />


    <asp:Button ID="btnVisualizar" runat="server" onclick="btnVisualizar_Click" 
        Text="Visualizar" />


</asp:Content>

