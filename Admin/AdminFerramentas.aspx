<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="AdminFerramentas.aspx.cs" Inherits="Admin_AdminFerramentas" enableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Manutenção de Ferramentas</h1>

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
                                                Descrição:</td>
                <td>
                    <asp:TextBox ID="txtDescricao" runat="server" Width="440px" MaxLength="100"></asp:TextBox>
                </td>
           </tr>
           <tr>
                <td>
                    URL:</td>
                                            <td>
                                                <asp:TextBox ID="txtUrl" runat="server" Width="440px" MaxLength="200" 
                                                    ></asp:TextBox>
                                            </td>
                                        </tr>
           <tr>
                <td>
                    Tipo:</td>
                                            <td>
                                                 <asp:TextBox ID="txtTipo" runat="server" Width="100px" MaxLength="1" 
                                                    ></asp:TextBox>
                                            P = Parceiros | I = Informações | D = Documentações
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
                                              
                                              <asp:GridView ID="gridFerramenta" runat="server" BackColor="White" 
                                                    BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                                                    GridLines="Vertical" AutoGenerateColumns="False" HorizontalAlign="Center" 
                                                    Width="100%" 
                                             onselectedindexchanged="gridFerramenta_SelectedIndexChanged">
                                                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                                                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                                                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                                                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                                                    <AlternatingRowStyle BackColor="#DCDCDC" />
                                                    <Columns>

                                                         <asp:TemplateField HeaderText="Alt ">

                <ItemTemplate>
                <div style="text-align: center">
         
                                                
                    <asp:ImageButton ID="btnAlterar" runat="server" 
                        CommandArgument='<%#Eval("CD_FERRAMENTA")%>' ImageUrl="~/img/icones_101.png" 
                        onclick="btnAlterar_Click" />   
                </div>               
                </ItemTemplate>
 
                
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Excluir">
                <ItemTemplate>
                    <div style="text-align: center">
                        <asp:ImageButton ID="btnExcluir" runat="server" 
                            CommandArgument='<%#Eval("CD_FERRAMENTA")%>' ImageUrl="~/img/icones_120.png" 
                            onclick="btnExcluir_Click" style="text-align: center; " />
                    </div>
                    <br />
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>          
            
            <asp:TemplateField HeaderText="Descrição">
                <ItemTemplate>
                 <%#Eval("descricao")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="URL">
                <ItemTemplate>
                 <%#Eval("url")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:TemplateField>

                        <asp:TemplateField HeaderText="tipo">
                <ItemTemplate>
                 <%#Eval("tipo")%>
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

