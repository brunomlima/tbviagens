<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" 
    enableEventValidation="false" AutoEventWireup="true" CodeFile="AdminEmailMarketing.aspx.cs" Inherits="Admin_AdminEmailMarketing" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Manutenção de Email Marketing</h1>

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
                    Nome:</td>
                <td>
                    <asp:TextBox ID="txtNome" runat="server" Width="440px"></asp:TextBox>
                </td>
            </tr>
                                        <tr>
                                            <td>
                                                E-mail:</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" Width="440px"></asp:TextBox>
                </td>
            </tr>
                                        <tr>
                                            <td colspan="2" style="text-align: center">
                                                <asp:Button ID="btnNovo" runat="server" 
                                                    onclick="btnNovo_Click" Text="Novo" />
                                                    &nbsp;&nbsp;
                                                <asp:Button ID="btnGravar" runat="server" 
                                                    onclick="btnGravar_Click" Text="Gravar" />
                                                <asp:Label ID="lblResultado" runat="server" Font-Bold="True" Font-Size="Medium" 
                                                    ForeColor="Red"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                        <td>Pesquisar por e-mail</td>
                                        <td>   
                    <asp:TextBox ID="txtPesquisa" runat="server" Width="330px"></asp:TextBox>
                                                <asp:Button ID="btnPesquisar" runat="server" 
                                                    Text="Pesquisar" onclick="btnPesquisar_Click" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2" style="text-align: center">
         <asp:GridView ID="gridEmailMkt" runat="server" BackColor="White" 
                                                    BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                                                    GridLines="Vertical" AutoGenerateColumns="False" HorizontalAlign="Center" 
                                                    Width="100%" onpageindexchanging="gridEmailMkt_PageIndexChanging" 
                                                    AllowPaging="True" PageSize="50">
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
                        CommandArgument='<%#Eval("CD_EMAIL")%>' ImageUrl="~/img/icones_101.png" 
                        onclick="btnAlterar_Click" />                   
                </ItemTemplate>
                
                <HeaderStyle HorizontalAlign="center" />
                <ItemStyle HorizontalAlign="center" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Excluir">
                <ItemTemplate>
                    <div style="text-align: center">
                        <asp:ImageButton ID="btnExcluir" runat="server" 
                            CommandArgument='<%#Eval("CD_EMAIL")%>' ImageUrl="~/img/icones_120.png" 
                            onclick="btnExcluir_Click" />
                    </div>
                    <br />
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField> 
    
            
            <asp:TemplateField HeaderText="NOME">
                <ItemTemplate>
                 <%#Eval("NOME")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="EMAIL">
                <ItemTemplate>
                 <%#Eval("EMAIL")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:TemplateField>

            
                                                    </Columns>
                                                </asp:GridView>   
                                            </td>
            </tr>
        </table>


                                                                                     
                                                
                                                </p>
</asp:Content>

