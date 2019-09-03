<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="AdminRoteiroImagens.aspx.cs" Inherits="Admin_AdminRoteiroImagens" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table style="width:100%;">
    
        <tr>
            <td>
                Título do Roteiro<td colspan="2">
                <asp:Label ID="lblTitulo" runat="server" Text="Titulo do roteiro"></asp:Label>
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
               <asp:ImageButton ID="btnExcluiImagem" runat="server" ImageUrl="~/img/icones_120.png" onclick="btnExcluiImagem_Click" Visible="False" />
                &nbsp;<asp:Label ID="lblcaminhodaimagem" runat="server" Text="Caminho da Imagem"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style1">
                Imagem da
                <br />
                Página de Roteiro<br />
                <br />
                Tamanho: (684x350px)</td>
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
                <asp:Label ID="lblMensagem" runat="server" Font-Bold="True" ForeColor="Red" Visible="False"></asp:Label>
            </td>
            <td class="style1">
                &nbsp;</td>
        </tr>
    </table>


</asp:Content>

