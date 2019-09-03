<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" enableEventValidation="false"
    CodeFile="AdminConvidados.aspx.cs" Inherits="Admin_AdminConvidados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table style="width: 100%;">
        <tr>
            <td colspan="2">
                <%   
                    Noivo nv = new Noivo();
                    nv.Carregar(int.Parse(Session["CD_NOIVO"].ToString()));
                    Response.Write(" <span style='font-size: x-large'>Casal: <b>" + nv.Nome_Noivos.ToString() + "</span></b><br/>");
                    Response.Write(" <span style='font-size: x-large'>Data do Casamento: <b>" + nv.DtCasamento.ToString("dd/MM/yyyy") + "</span></b><br/>");         
                %>
                <asp:Label ID="lblResultado" runat="server"></asp:Label>
                <hr />
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="gridConvidados" runat="server" BackColor="White" BorderColor="#999999"
                    BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" AutoGenerateColumns="False"
                    HorizontalAlign="Center" Width="100%">
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <Columns>
                        <asp:TemplateField HeaderText="Enviar e-mail" ItemStyle-Width="2%">
                            <ItemTemplate>
                                <div style="text-align: center">
                                <asp:ImageButton ID="btnReenviarEmail" runat="server" CommandArgument='<%#Eval("CD_CONVIDADO")%>'
                                    ImageUrl="~/img/icones_26.png" 
                                    onclick="btnReenviarEmail_Click" />
                                    </div>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Excluir" ItemStyle-Width="1%">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <asp:ImageButton ID="btnExcluir" runat="server" CommandArgument='<%#Eval("CD_CONVIDADO")%>'
                                        ImageUrl="~/img/icones_120.png" OnClick="btnExcluir_Click" Style="text-align: center;" />
                                </div>
                                <br />
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="NOME DOS CONVIDADOS" ItemStyle-Width="10%">
                            <ItemTemplate>
                                <%#Eval("NOME")%>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" />
                            <ItemStyle HorizontalAlign="Left" />
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
        </tr>
                <tr>
            <td colspan="2">
                <hr />
        </tr>
    </table>
</asp:Content>
