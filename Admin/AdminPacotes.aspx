<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="AdminPacotes.aspx.cs" Inherits="Admin_AdminPacotes"  enableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<h1>Manutenção de Pacotes</h1>
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
                                                Titulo:</td>
                <td>
                    <asp:TextBox ID="txtTitulo" runat="server" Width="440px" MaxLength="50"></asp:TextBox>
                </td>
           </tr>
           <tr>
                <td>
                    Resumo:</td>
                                            <td>
                                                <asp:TextBox ID="txtResmo" runat="server" Width="440px" MaxLength="100" 
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
                                         <asp:GridView ID="gridPacote" runat="server" BackColor="White" 
                                                    BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                                                    GridLines="Vertical" AutoGenerateColumns="False" HorizontalAlign="Center" 
                                                    Width="100%" onselectedindexchanged="gridUsuario_SelectedIndexChanged">
                                                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                                                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                                                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                                                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                                                    <AlternatingRowStyle BackColor="#DCDCDC" />
                                                    <Columns>
                                                                <asp:TemplateField HeaderText="Codigo" ItemStyle-Width="1%">
                <ItemTemplate>
                 <%#Eval("CD_PACOTE")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Detalhes do Pacote" ItemStyle-Width="3%">
                <ItemTemplate>                                        
                    <asp:ImageButton ID="btnDetalhePacote" runat="server" 
                        CommandArgument='<%#Eval("CD_PACOTE")%>' ImageUrl="~/img/icones_32.png" 
                        onclick="btnDetalhePacote_Click"  />                   
                </ItemTemplate>

               
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>


            <asp:TemplateField HeaderText="Imagem do Pacote" ItemStyle-Width="3%">
                <ItemTemplate>                                        
                    <asp:ImageButton ID="btnImagemPacote" runat="server" 
                        CommandArgument='<%#Eval("CD_PACOTE")%>' ImageUrl="~/img/icones_63.png" 
                        onclick="btnImagemPacote_Click"  />                   
                </ItemTemplate>

               
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Imagem do Pacote 1" ItemStyle-Width="3%">
                <ItemTemplate>                                        
                    <asp:ImageButton ID="btnImagemPacote1" runat="server" 
                        CommandArgument='<%#Eval("CD_PACOTE")%>' ImageUrl="~/img/icones_63.png" onclick="btnImagemPacote_Click1" 
                        />                   
                </ItemTemplate>

               
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Visualiza E-mail Marketing" ItemStyle-Width="3%">
                <ItemTemplate>                                        
                    <asp:ImageButton ID="btnEmailMarketing" runat="server" 
                        CommandArgument='<%#Eval("CD_PACOTE")%>' ImageUrl="~/img/icones_91.png" 
                        onclick="btnEmailMarketing_Click" />                   
                </ItemTemplate>

               
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Visualiza Pacote Especial" ItemStyle-Width="3%">
                <ItemTemplate>                                        
                    <asp:ImageButton ID="btnVisualizaPacoteEspecial" runat="server" 
                        CommandArgument='<%#Eval("CD_PACOTE")%>' ImageUrl="~/img/icones_280.png" 
                        onclick="btnVisualizaPacoteEspecial_Click" />                   
                </ItemTemplate>

               
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Envia E-mail Marketing" ItemStyle-Width="3%">
                <ItemTemplate>                                        
                    <asp:ImageButton ID="btnEnviaEmailMarketing" runat="server" 
                        CommandArgument='<%#Eval("CD_PACOTE")%>' ImageUrl="~/img/icones_26.png" 
                        onclick="btnEnviaEmailMarketing_Click" />                   
                </ItemTemplate>

               
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Alt " ItemStyle-Width="3%">
                <ItemTemplate>                                        
                    <asp:ImageButton ID="btnAlterar" runat="server" 
                        CommandArgument='<%#Eval("CD_PACOTE")%>' ImageUrl="~/img/icones_101.png" 
                        onclick="btnAlterar_Click" />                   
                </ItemTemplate>
                
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Excluir" ItemStyle-Width="3%">
                <ItemTemplate>
                    <div style="text-align: center">
                        <asp:ImageButton ID="btnExcluir" runat="server" 
                            CommandArgument='<%#Eval("CD_PACOTE")%>' ImageUrl="~/img/icones_120.png" 
                            onclick="btnExcluir_Click" style="text-align: center; " />
                    </div>
                    <br />
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>          
   
            <asp:TemplateField HeaderText="TIPO" ItemStyle-Width="2%">
                <ItemTemplate>
                 <%#Eval("TIPO")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:TemplateField>
                        
            <asp:TemplateField HeaderText="TITULO" ItemStyle-Width="10%">
                <ItemTemplate>
                 <%#Eval("TITULO")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:TemplateField>
               
            <asp:TemplateField HeaderText="RESUMO" ItemStyle-Width="15%">
                <ItemTemplate>
                 <%#Eval("RESUMO")%>
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

