<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master"
    enableEventValidation="false" AutoEventWireup="true" CodeFile="AdminEmailImagens.aspx.cs" Inherits="Admin_AdminEmailImagens" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Imagem do E-mail</h1>
  <table style="width:100%;">
    
        <tr>
            <td>
                Título do Email<td colspan="2">
                <asp:Label ID="lblTitulo" runat="server" Text="Titulo do email"></asp:Label>
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
                Imagem do Email<br />
                <br />
                Tamanho: (600x400px)<br />
                <br />
                Obs.: Incluir o parâmetro
                <br />
                *|PIMAGEM|* no corpo do<br />
                email</td>
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

