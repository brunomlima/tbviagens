<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master"  enableEventValidation="false" AutoEventWireup="true" CodeFile="AdminTestemunho.aspx.cs" Inherits="Admin_AdminTestemunho" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<h1>Manutenção de Testemunho</h1>
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
                    <asp:TextBox ID="txtNome" runat="server" Width="440px" MaxLength="50"></asp:TextBox>
                </td>
           </tr>
           <tr>
                <td>
                    Testemunho:</td>
                                            <td>
                                                <asp:TextBox ID="txtTestemunho" runat="server" Width="440px" MaxLength="100" 
                                                    TextMode="MultiLine"></asp:TextBox>
                                            </td>
                                        </tr>
                       
                                        
                                        <tr>
                                            <td colspan="2" style="text-align: center">
                                            &nbsp;
                                                <asp:Button ID="btnNovo" runat="server" 
                                                    onclick="btnNovo_Click" Text="Novo" />
                                                    &nbsp;&nbsp;
                                                <asp:Button ID="btnGravar" runat="server" 
                                                    onclick="btnGravar_Click" Text="Gravar" />
                                                <asp:Label ID="lblResultado" runat="server"></asp:Label>
                                            </td>
            </tr>
                                        <tr>
                                            <td colspan="2" style="text-align: center">
                                         <asp:GridView ID="gridTestemunho" runat="server" BackColor="White" 
                                                    BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                                                    GridLines="Vertical" AutoGenerateColumns="False" HorizontalAlign="Center" 
                                                    Width="100%" onselectedindexchanged="gridTestmunho_SelectedIndexChanged">
                                                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                                                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                                                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                                                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                                                    <AlternatingRowStyle BackColor="#DCDCDC" />
                                                    <Columns>
                                                                <asp:TemplateField HeaderText="Codigo" ItemStyle-Width="1%">
                                                                    <ItemTemplate>
                                                                     <%#Eval("CD_TESTEMUNHO")%>
                                                                    </ItemTemplate>
                                                                    <HeaderStyle HorizontalAlign="Center" />
                                                                    <ItemStyle HorizontalAlign="Center" />
                                                                </asp:TemplateField>


                                                                <asp:TemplateField HeaderText="Imagem da Pessoa" ItemStyle-Width="3%">
                                                                    <ItemTemplate>                                        
                                                                        <asp:ImageButton ID="btnImagemdaPessoa" runat="server" 
                                                                            CommandArgument='<%#Eval("CD_TESTEMUNHO")%>' ImageUrl="~/img/icones_63.png" 
                                                                            onclick="btnImagemdaPessoa_Click"  />                   
                                                                    </ItemTemplate>

               
                                                                    <HeaderStyle HorizontalAlign="Center" />
                                                                    <ItemStyle HorizontalAlign="Center" />
                                                                </asp:TemplateField>

                                                                <asp:TemplateField HeaderText="Imagem Grande" ItemStyle-Width="3%">
                                                                    <ItemTemplate>                                        
                                                                        <asp:ImageButton ID="btnImagemGrande" runat="server" 
                                                                            CommandArgument='<%#Eval("CD_TESTEMUNHO")%>' ImageUrl="~/img/icones_63.png" 
                                                                            onclick="btnImagemGrande_Click"  />                   
                                                                    </ItemTemplate>

               
                                                                    <HeaderStyle HorizontalAlign="Center" />
                                                                    <ItemStyle HorizontalAlign="Center" />
                                                                </asp:TemplateField>            

                                                                <asp:TemplateField HeaderText="Alt " ItemStyle-Width="3%">
                                                                    <ItemTemplate>                                        
                                                                        <asp:ImageButton ID="btnAlterar" runat="server" 
                                                                            CommandArgument='<%#Eval("CD_TESTEMUNHO")%>' ImageUrl="~/img/icones_101.png" 
                                                                            onclick="btnAlterar_Click" />                   
                                                                    </ItemTemplate>
                
                                                                    <HeaderStyle HorizontalAlign="Center" />
                                                                    <ItemStyle HorizontalAlign="Center" />
                                                                </asp:TemplateField>
                                                                <asp:TemplateField HeaderText="Excluir" ItemStyle-Width="3%">
                                                                    <ItemTemplate>
                                                                        <div style="text-align: center">
                                                                            <asp:ImageButton ID="btnExcluir" runat="server" 
                                                                                CommandArgument='<%#Eval("CD_TESTEMUNHO")%>' ImageUrl="~/img/icones_120.png" 
                                                                                onclick="btnExcluir_Click" style="text-align: center; " />
                                                                        </div>
                                                                        <br />
                                                                    </ItemTemplate>
                                                                    <HeaderStyle HorizontalAlign="Center" />
                                                                    <ItemStyle HorizontalAlign="Center" />
                                                                </asp:TemplateField>          
            
                                                                <asp:TemplateField HeaderText="Nome" ItemStyle-Width="10%">
                                                                    <ItemTemplate>
                                                                     <%#Eval("NOME")%>
                                                                    </ItemTemplate>
                                                                    <HeaderStyle HorizontalAlign="Left" />
                                                                    <ItemStyle HorizontalAlign="Left" />
                                                                </asp:TemplateField>
            
                                                                <asp:TemplateField HeaderText="Testemunho" ItemStyle-Width="15%">
                                                                    <ItemTemplate>
                                                                     <%#Eval("TESTEMUNHO")%>
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

