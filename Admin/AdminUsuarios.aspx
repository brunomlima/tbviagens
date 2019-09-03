<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" enableEventValidation="false" AutoEventWireup="true" CodeFile="AdminUsuarios.aspx.cs" Inherits="Admin_AdminUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<h1>Manutenção de Usuários</h1>
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
                                                Cargo:</td>
                <td>
                    <asp:TextBox ID="txtCargo" runat="server" Width="440px"></asp:TextBox>
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
                <td>
                    Skype:</td>
                                            <td>
                                                <asp:TextBox ID="txtSkype" runat="server" Width="440px"></asp:TextBox>
                                            </td>
                                        </tr>
                                               <tr>
                <td>
                    Cpf:</td>
                <td>
                    <asp:TextBox ID="txtCpf" runat="server" Width="440px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                 <td>
                                                Senha:</td>
                <td>
                    <asp:TextBox ID="txtSenha" runat="server" Width="440px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                 <td>
                                                Status:</td>
                <td>
                    <asp:TextBox ID="txtStatus" runat="server" Width="50px"></asp:TextBox>
                &nbsp;A = Ativo Funcionário C = Ativo Cliente I = Usuário Inativo</td>
            </tr>
                       
                                        
                                        <tr>
                                            <td colspan="2" style="text-align: center">
                                            &nbsp;
                                                <asp:Button ID="btnNovo" runat="server" 
                                                    onclick="btnNovo_Click" Text="Novo" />
                                                    &nbsp;&nbsp;
                                                <asp:Button ID="btnGravar" runat="server" 
                                                    onclick="btnGravar_Click" Text="Gravar" style="height: 26px" />
                                                <asp:Label ID="lblResultado" runat="server"></asp:Label>
                                            </td>
            </tr>
                                        <tr>
                                            <td colspan="2" style="text-align: center">
                                         <asp:GridView ID="gridUsuario" runat="server" BackColor="White" 
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
                                                    <asp:TemplateField HeaderText="Acessos ">
                <ItemTemplate>                                        
                    <asp:ImageButton ID="btnAcessos" runat="server" 
                        CommandArgument='<%#Eval("CD_USUARIO")%>' ImageUrl="~/img/icones_86.png" 
                        onclick="btnAcessos_Click1"  />                   
                </ItemTemplate>
               
                <HeaderStyle HorizontalAlign="center" />
                <ItemStyle HorizontalAlign="center" />
            </asp:TemplateField>
              <asp:TemplateField HeaderText="Alt ">
                <ItemTemplate>                                        
                    <asp:ImageButton ID="btnAlterar" runat="server" 
                        CommandArgument='<%#Eval("CD_USUARIO")%>' ImageUrl="~/img/icones_101.png" 
                        onclick="btnAlterar_Click" />                   
                </ItemTemplate>
                
                <HeaderStyle HorizontalAlign="center" />
                <ItemStyle HorizontalAlign="center" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Excluir">
                <ItemTemplate>
                    <div style="text-align: center">
                        <asp:ImageButton ID="btnExcluir" runat="server" 
                            CommandArgument='<%#Eval("CD_USUARIO")%>' ImageUrl="~/img/icones_120.png" 
                            onclick="btnExcluir_Click" style="text-align: center; " />
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
            <asp:TemplateField HeaderText="CPF">
                <ItemTemplate>
                 <%#Eval("CPF")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:TemplateField>
                  <asp:TemplateField HeaderText="STATUS">
                <ItemTemplate>
                 <%#Eval("STATUS")%>
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

