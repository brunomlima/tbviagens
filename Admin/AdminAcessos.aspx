<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="AdminAcessos.aspx.cs" Inherits="Admin_AdminAcessos" enableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Acessos do usuário: <% 
                            Usuario us = new Usuario();
                            us.Carregar(int.Parse(Session["cd_usuario"].ToString()));
                            Response.Write(us.Nome.ToString());                            
                            %> </h1>    
    <table style="width: 100%">
        <tr>
            <td style="width: 50%">
                Modulo Liberados</td>
            <td>
                &nbsp;</td>
            <td>
                Modulo Bloqueados</td>
        </tr>
        <tr>
            <td style="width: 50%">
                <asp:GridView ID="gridAcessoLiberado" runat="server" 
                    AutoGenerateColumns="False" Width="100%" BackColor="White" 
                    BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                    GridLines="Vertical">
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <Columns>
                        <asp:TemplateField HeaderText="Revogar">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <asp:ImageButton ID="btnRevogar" runat="server" 
                            CommandArgument='<%#Eval("CD_MODULO")%>' ImageUrl="~/img/icones_124.png" 
                            style="text-align: center" onclick="btnRevogar_Click" />
                                </div>
                                <br />
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="MODULO">
                            <ItemTemplate>
                                <%#Eval("NOME_MODULO")%>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" />
                            <ItemStyle HorizontalAlign="Left" />
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                </asp:GridView>
            </td>
            <td>
                &nbsp;</td>
            <td>
                <asp:GridView ID="gridAcessoBloqueado" runat="server" 
                    AutoGenerateColumns="False" Width="100%" BackColor="White" 
                    BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                    GridLines="Vertical">
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <Columns>
                        <asp:TemplateField HeaderText="Liberar">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <asp:ImageButton ID="btnConceder" runat="server" 
                            CommandArgument='<%#Eval("CD_MODULO")%>' ImageUrl="~/img/icones_125.png" 
                            style="text-align: center" onclick="btnConceder_Click" />
                                </div>
                                <br />
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="MODULO">
                            <ItemTemplate>
                                <%#Eval("NOME_MODULO")%>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" />
                            <ItemStyle HorizontalAlign="Left" />
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                </asp:GridView>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>

