<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" 
    enableEventValidation="false" AutoEventWireup="true" CodeFile="AdminEnvioEmailsFluxo.aspx.cs" Inherits="Admin_AdminEnvioEmailsFluxo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<h1>Envio de e-mails para os fluxos</h1>  

    <div>

        <br />
        <br />
                                         <asp:GridView ID="gridFluxo" runat="server" BackColor="White" 
                                                    BorderColor="#999999" 
            BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                                                    GridLines="Vertical" 
            AutoGenerateColumns="False" HorizontalAlign="Center" 
                                                    Width="100%" 
            EmptyDataText="Nenhum e-mail no fluxo para ser enviado">
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


            <asp:TemplateField HeaderText="Título do E-mail" ItemStyle-Width="15%">
                <ItemTemplate>
                 <%#Eval("TITULO_EMAIL")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:TemplateField>   
   
            <asp:TemplateField HeaderText="Nome" ItemStyle-Width="15%">
                <ItemTemplate>
                 <%#Eval("NOME")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Email" ItemStyle-Width="15%">
                <ItemTemplate>
                 <%#Eval("EMAIL")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:TemplateField>

                     
                                                    </Columns>
                                                </asp:GridView>                                                
                                                
    </div>
    <asp:Button ID="BtnEnviaEmails" runat="server" onclick="BtnEnviaEmails_Click" 
        Text="Enviar" />
        <asp:Label ID="lblResultado" runat="server"></asp:Label>


</asp:Content>

