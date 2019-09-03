<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" 
    enableEventValidation="false" AutoEventWireup="true" CodeFile="AdminEnvio.aspx.cs" Inherits="Admin_AdminEnvio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            font-size: medium;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h1>
        <table style="width:100%;">
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: center">
                    E-mail Marketing do Pacote : <%#Eval("NOME")%> 
        <asp:Label ID="lblResumo" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align: center">
           
            <asp:Image ID="imgPacote" runat="server" Height="300px" Width="500px" itemprop='image'/>
                </td>
            </tr>
        </table>
    </h1>
    <table style="width: 100%">
        <tr>
            <td style="text-align: center;" colspan="3">
                <strong><span class="style1">
                <hr />
                <br />
                Enviar e-mails em lotes de </span></strong>
                <br />
                <br />
                <asp:TextBox ID="txtQtdLote" runat="server" MaxLength="3" Width="45px">50</asp:TextBox>
                <br />
                <br />
                <asp:Button ID="BtnEnviarEmLote" runat="server" onclick="BtnEnviarEmLote_Click" 
                    Text="Enviar" />
                <br />
                <br />
                <hr />
            </td>
        </tr>
        <tr>
            <td style="width: 50%">
                E-mail Enviado - (
                <asp:Label ID="lblQtdEnviado" runat="server" Text="0"></asp:Label>
&nbsp;) </td>
            <td>
                &nbsp;</td>
            <td>
                E-mail NÃO Enviado (
                <asp:Label ID="lblQtdNAOenviado" runat="server" Text="0"></asp:Label>
&nbsp;)</td>
        </tr>
        <tr>
            <td style="width: 50%">
                <asp:GridView ID="gridEmailEnviado" runat="server" 
                    AutoGenerateColumns="False" Width="100%" BackColor="White" 
                    BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                    GridLines="Vertical" AllowPaging="True" 
                    onpageindexchanging="gridEmailEnviado_PageIndexChanging" PageSize="50">
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <Columns>
                        <asp:TemplateField HeaderText="Enviado">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <asp:ImageButton ID="btnReenvia" runat="server" 
                            CommandArgument='<%#Eval("CD_EMAIL")%>' ImageUrl="~/img/icones_124.png" 
                            style="text-align: center" onclick="btnReenvia_Click" />
                                </div>
                                <br />
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Nome">
                            <ItemTemplate>
                                <%#Eval("NOME")%>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" />
                            <ItemStyle HorizontalAlign="Left" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="E-mail">
                            <ItemTemplate>
                                <%#Eval("EMAIL")%>
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
                <asp:GridView ID="gridEmailNaoEnviado" runat="server" 
                    AutoGenerateColumns="False" Width="100%" BackColor="White" 
                    BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                    GridLines="Vertical" AllowPaging="True" 
                    onpageindexchanging="gridEmailNaoEnviado_PageIndexChanging" PageSize="50">
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <Columns>
                        <asp:TemplateField HeaderText="Não Enviado">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <asp:ImageButton ID="btnEnvia" runat="server" 
                            CommandArgument='<%#Eval("CD_EMAIL")%>' ImageUrl="~/img/icones_125.png" 
                            style="text-align: center" onclick="btnEnvia_Click" />
                                </div>
                                <br />
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Nome">
                            <ItemTemplate>
                                <%#Eval("NOME")%>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" />
                            <ItemStyle HorizontalAlign="Left" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="E-mail">
                            <ItemTemplate>
                                <%#Eval("EMAIL")%>
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

