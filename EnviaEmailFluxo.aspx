<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EnviaEmailFluxo.aspx.cs" Inherits="EnviaEmailFluxo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblResultado" runat="server" Text="lblResultado"></asp:Label>

        <br />
        <br />
                                         <asp:GridView ID="gridFluxo" runat="server" BackColor="White" 
                                                    BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                                                    GridLines="Vertical" AutoGenerateColumns="False" HorizontalAlign="Center" 
                                                    Width="100%">
                                                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                                                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                                                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                                                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                                                    <AlternatingRowStyle BackColor="#DCDCDC" />
                                                    <Columns>
                                                                <asp:TemplateField HeaderText="Codigo" ItemStyle-Width="1%">
                <ItemTemplate>
                 <%#Eval("CD_AGENDADOR")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>


            <asp:TemplateField HeaderText="TITULO" ItemStyle-Width="15%">
                <ItemTemplate>
                 <%#Eval("TITULO_EMAIL")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:TemplateField>   
   
            <asp:TemplateField HeaderText="TITULO" ItemStyle-Width="15%">
                <ItemTemplate>
                 <%#Eval("NOME")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:TemplateField>

            <asp:TemplateField HeaderText="TITULO" ItemStyle-Width="15%">
                <ItemTemplate>
                 <%#Eval("EMAIL")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:TemplateField>

            <asp:TemplateField HeaderText="CD_PACOTE" ItemStyle-Width="3%">
                <ItemTemplate>
                 <%#Eval("CD_PACOTE")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:TemplateField>

            <asp:TemplateField HeaderText="CD_EMAIL" ItemStyle-Width="3%">
                <ItemTemplate>
                 <%#Eval("CD_EMAIL")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:TemplateField>
                     
                                                    </Columns>
                                                </asp:GridView>                                                
                                                
    </div>
    <asp:Button ID="BtnEnviaEmails" runat="server" onclick="BtnEnviaEmails_Click" 
        Text="Enviar" />
    </form>
</body>
</html>
