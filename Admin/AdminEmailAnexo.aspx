<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" 
    enableEventValidation="false"
    AutoEventWireup="true" CodeFile="AdminEmailAnexo.aspx.cs" Inherits="Admin_AdminEmailAnexo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width:100%;">
    <h1>Anexo do e-mail</h1>
        <tr>
            <td>
                Título do Email<td colspan="2">
                <asp:Label ID="lblTitulo" runat="server" Text="Titulo do email"></asp:Label>
            </td>
        </tr>
    
        <tr>
            <td>
                Selecione o arquivo pdf</td>
            <td colspan="2">
                <asp:FileUpload ID="FileUploadImagem" runat="server" Width="400px" />
            </td>
        </tr>
        <tr>
            <td>
                Nome do arquivo</td>
            <td colspan="2">
                <asp:Label ID="lblcaminhodaimagem" runat="server" Text="Caminho do arquivo"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style1">
                <asp:Button ID="btnEnviar" runat="server" Text="Enviar" 
                    onclick="btnEnviar_Click" />
            </td>
            <td class="style1">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

