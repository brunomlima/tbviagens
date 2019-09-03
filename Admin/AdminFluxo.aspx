<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="AdminFluxo.aspx.cs" Inherits="Admin_AdminFluxo" enableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h1>Manutenção de Fluxo de Emails</h1>
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
                    <asp:TextBox ID="txtTitulo" runat="server" Width="440px" MaxLength="200"></asp:TextBox>
                </td>
           </tr>
           <tr>
                <td>
                    Sequencia:</td>
                                            <td>
                                                <asp:TextBox ID="txtSequencia" runat="server" Width="440px" MaxLength="3"></asp:TextBox>
                                            </td>
                                        </tr>
           <tr>
                <td>
                    Dias:</td>
                                            <td>
                                                <asp:TextBox ID="txtDias" runat="server" Width="440px" MaxLength="3"></asp:TextBox>
                                            </td>
                                        </tr>
           <tr>
                <td>
                    Pacote:</td>
                                            <td>
                                                <asp:TextBox ID="txtPacote" runat="server" Width="440px" MaxLength="4"></asp:TextBox>
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
            <td>
                    Filtrar Pacote:</td>
                                            <td>
                                                <asp:TextBox ID="txtFiltra" runat="server" Width="350px" MaxLength="4"></asp:TextBox>
                                                <asp:Button ID="bntFiltrar" runat="server" onclick="bntFiltrar_Click" 
                                                    Text="Filtrar" />
                </td>
                                        <tr>
                                            <td colspan="2" style="text-align: center">
                                         <asp:GridView ID="gridFluxo" runat="server" BackColor="White" 
                                                    BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                                                    GridLines="Vertical" AutoGenerateColumns="False" HorizontalAlign="Center" 
                                                    Width="100%" onpageindexchanging="gridFluxo_PageIndexChanging">
                                                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                                                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                                                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                                                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                                                    <AlternatingRowStyle BackColor="#DCDCDC" />
                                                    <Columns>
                                                                <asp:TemplateField HeaderText="Codigo" ItemStyle-Width="1%">
                <ItemTemplate>
                 <%#Eval("CD_FLUXO_EMAILS")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Corpo do e-mail" ItemStyle-Width="3%">
                <ItemTemplate>                                        
                    <asp:ImageButton ID="btnCorpoEmail" runat="server" 
                        CommandArgument='<%#Eval("CD_FLUXO_EMAILS")%>' ImageUrl="~/img/icones_32.png" 
                        onclick="btnCorpoEmailPacote_Click"  />                   
                </ItemTemplate>

               
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>


            <asp:TemplateField HeaderText="Imagem do Email" ItemStyle-Width="3%">
                <ItemTemplate>                                        
                    <asp:ImageButton ID="btnImagemEmail" runat="server" 
                        CommandArgument='<%#Eval("CD_FLUXO_EMAILS")%>' ImageUrl="~/img/icones_63.png" 
                        onclick="btnImagemEmailPacote_Click"  />                   
                </ItemTemplate>

               
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Anexo" ItemStyle-Width="3%">
                <ItemTemplate>                                        
                    <asp:ImageButton ID="btnAnexo" runat="server" 
                        CommandArgument='<%#Eval("CD_FLUXO_EMAILS")%>' ImageUrl="~/img/bt-anuncie1.png" onclick="btnAnexoPacote_Click1" 
                        />                   
                </ItemTemplate>

               
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Alt " ItemStyle-Width="3%">
                <ItemTemplate>                                        
                    <asp:ImageButton ID="btnAlterar" runat="server" 
                        CommandArgument='<%#Eval("CD_FLUXO_EMAILS")%>' ImageUrl="~/img/icones_101.png" 
                        onclick="btnAlterar_Click" />                   
                </ItemTemplate>
                
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Excluir" ItemStyle-Width="3%">
                <ItemTemplate>
                    <div style="text-align: center">
                        <asp:ImageButton ID="btnExcluir" runat="server" 
                            CommandArgument='<%#Eval("CD_FLUXO_EMAILS")%>' ImageUrl="~/img/icones_120.png" 
                            onclick="btnExcluir_Click" style="text-align: center; " />
                    </div>
                    <br />
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>          
   
            <asp:TemplateField HeaderText="Título" ItemStyle-Width="10%">
                <ItemTemplate>
                 <%#Eval("TITULO_EMAIL")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Sequência" ItemStyle-Width="3%">
                <ItemTemplate>
                 <%#Eval("SEQUENCIA")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Dias" ItemStyle-Width="3%">
                <ItemTemplate>
                 <%#Eval("TEMPO_PROXIMO_ENVIO")%>
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

