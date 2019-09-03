<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="AdminFluxoEmails.aspx.cs" Inherits="Admin_AdminFluxoEmails" enableEventValidation="false" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            height: 28px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h1>Corpo do e-mail</h1>

              <table style="width: 100%">               
                             <td class="style1">
                             Título do E-mail:<br />
&nbsp;<asp:TextBox ID="txtTitulo" runat="server" Width="800px" MaxLength="1"></asp:TextBox>
                                 <br />
                                 <asp:ScriptManager ID="ScriptManager1" runat="server">
                                 </asp:ScriptManager>
                             Conteúdo do E-mail:<br />
&nbsp;<asp:TextBox ID="txtEditorHTML" runat="server" Width="800px" MaxLength="1" Height="400px" 
                                     TextMode="MultiLine"></asp:TextBox>

                                 </td>
           </table> 

                     <table style="width: 100%">               
                             <td class="style1">
                             Dias:<br />
&nbsp;<asp:TextBox ID="txtDias" runat="server" Width="100px" MaxLength="1"></asp:TextBox>
                                 </td>
           </table> 
                     <table style="width: 100%">               
                             <td class="style1">
                             Sequencia:<br />
&nbsp;<asp:TextBox ID="txtSequencia" runat="server" Width="100px" MaxLength="1"></asp:TextBox>
                                 </td>
           </table> 

    <asp:Button ID="btbGravar" runat="server" Text="Gravar" onclick="btbGravar_Click" />


    </asp:Content>

