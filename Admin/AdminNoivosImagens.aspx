<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="AdminNoivosImagens.aspx.cs" Inherits="Admin_AdminNoivosImagens" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width:100%;">
    
        <tr>
            <td>
                Nome dos Noivos<td colspan="2">
                <asp:Label ID="lblNomeNoivos" runat="server" Text="Nome dos Noivos"></asp:Label>
            </td>
        </tr>
    
        <tr>
            <td>
                Selecione a Imagem</td>
            <td colspan="2">
                <asp:FileUpload ID="FileUploadImagem" runat="server" Width="400px" />
            </td>
        </tr>
        <tr>
            <td>
                Nome da Imagem</td>
            <td colspan="2">
                <asp:Label ID="lblcaminhodaimagem" runat="server" Text="Caminho da Imagem"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style1">
                Imagem</td>
            <td class="style1">
                <asp:Image ID="ImgPacote" runat="server" Height="135px" 
                     Width="244px" />
            </td>
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

