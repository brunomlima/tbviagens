<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="AdminMensagem.aspx.cs" Inherits="Admin_AdminMensagem" enableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h1>Manutenção de Mensagem</h1>
            <table style="width: 100%">
            <tr>
                <td>
                    Código</td>
                <td>
                    <asp:Label ID="lblCodigo" runat="server" Text="-"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    Autor:</td>
                <td>
                    <asp:TextBox ID="txtAutor" runat="server" Width="440px"></asp:TextBox>
                </td>
            </tr>
                                        <tr>
                                            <td>
                                                Conteudo:</td>
                <td>
                    <asp:TextBox ID="txtConteudo" runat="server" Height="163px" 
                        TextMode="MultiLine" Width="440px"></asp:TextBox>
                </td>
            </tr>
                                        <tr>
                                            <td colspan="2" style="text-align: center">
                                                <asp:Button ID="btnNovo" runat="server" 
                                                    onclick="btnNovo_Click" Text="Novo" />
                                                    &nbsp;&nbsp;
                                                <asp:Button ID="btnGravar" runat="server" 
                                                    onclick="btnGravar_Click" Text="Gravar" />
                                            </td>
            </tr>
                                        <tr>
                                            <td colspan="2" style="text-align: center">
                                                <asp:GridView ID="gridMensagens" runat="server" BackColor="White" 
                                                    BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                                                    GridLines="Vertical" AutoGenerateColumns="False" HorizontalAlign="Center" 
                                                    Width="100%" AllowPaging="True" 
                                                    onpageindexchanging="gridMensagens_PageIndexChanging">
                                                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                                                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                                                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                                                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                                                    <AlternatingRowStyle BackColor="#DCDCDC" />
                                                    <Columns>
                                                    <asp:TemplateField HeaderText="Alt ">
                <ItemTemplate>                                        
                    <asp:ImageButton ID="btnAlterar" runat="server" 
                        CommandArgument='<%#Eval("CD_MENSAGEM")%>' ImageUrl="~/img/icones_101.png" 
                        onclick="btnAlterar_Click" />                   
                </ItemTemplate>
                
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Excluir">
                <ItemTemplate>
                    <div style="text-align: center">
                        <asp:ImageButton ID="btnExcluir" runat="server" 
                            CommandArgument='<%#Eval("CD_MENSAGEM")%>' ImageUrl="~/img/icones_120.png" 
                            onclick="btnExcluir_Click" />
                    </div>
                    <br />
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>          
            
            <asp:TemplateField HeaderText="AUTOR">
                <ItemTemplate>
                 <%#Eval("AUTOR")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="CONTEUDO">
                <ItemTemplate>
                 <%#Eval("CONTEUDO")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:TemplateField>
            
                                                    </Columns>
                                                </asp:GridView>
                                            </td>
            </tr>
        </table>
    

</asp:Content>

