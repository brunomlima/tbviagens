<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" enableEventValidation="false" CodeFile="AdminNoivos.aspx.cs" Inherits="Admin_AdminNoivos" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script type="text/javascript">
    function countMsgNoivos(clientId) {
        var txtInput = document.getElementById(clientId);
        var spanDisplay = document.getElementById('spanDisplayMsgNoivos');
        spanDisplay.innerHTML = txtInput.value.length;
    }
</script>


<h1>Manutenção de Noivos</h1>
            
           </tr>  <table style="width: 100%">
            <tr>
                <td>
                    Código</td>
                <td>
                    <asp:Label ID="lblCodigo" runat="server" Text="-"></asp:Label>
                </td>
            </tr>
            <tr>
                                            <td>
                                                Nome dos Noivos:</td>
                <td>
                    <asp:TextBox ID="txtNomedosNoivos" runat="server" Width="440px" MaxLength="50"></asp:TextBox>
                </td>
           </tr>
                       <tr>
                                            <td>
                                                DataData do Casamento:</td>
                <td>
                    <asp:TextBox ID="txtDtCasamento" runat="server" Width="100px" MaxLength="50" 
                        ontextchanged="txtDtCasamento_TextChanged"></asp:TextBox>
                    <asp:CalendarExtender ID="txtDtCasamento_CalendarExtender" runat="server" 
                        Enabled="True" Format="dd/MM/yyyy" TargetControlID="txtDtCasamento">
                    </asp:CalendarExtender>
                    <br />
                    <asp:ScriptManager ID="ScriptManager2" runat="server">
                    </asp:ScriptManager>
                </td>
           </tr>            <tr>
                                            <td>
                                                Banco:>
                <td>
                    <asp:TextBox ID="txtBanco" runat="server" Width="440px" MaxLength="50"></asp:TextBox>
                </td>
           </tr>
                       <tr>
                                            <td>
                                                Agência:</td>
                <td>
                    <asp:TextBox ID="txtAgencia" runat="server" Width="440px" MaxLength="50"></asp:TextBox>
                </td>
           </tr>
                       <tr>
                                            <td>
                                                Conta Corrente:</td>
                <td>
                    <asp:TextBox ID="txtContaCorrente" runat="server" Width="440px" MaxLength="50"></asp:TextBox>
                </td>
           </tr>
                       <tr>
                                            <td>
                                                Favorecido:</td>
                <td>
                    <asp:TextBox ID="txtFavorecido" runat="server" Width="440px" MaxLength="50"></asp:TextBox>
                </td>
           </tr>
                       <tr>
                                            <td>
                                                CPF:</td>
                <td>
                    <asp:TextBox ID="txtCPF" runat="server" Width="440px" MaxLength="50"></asp:TextBox>
                </td>
           </tr>
                       <tr>
                                            <td>
                                                E-mail Noiva:</td>
                <td>
                    <asp:TextBox ID="txtEmailNoiva" runat="server" Width="440px" MaxLength="50"></asp:TextBox>
                </td>
           </tr>
                       <tr>
                                            <td>
                                                E-mail Noivo:</td>
                <td>
                    <asp:TextBox ID="txtEmailNoivo" runat="server" Width="440px" MaxLength="50"></asp:TextBox>
                </td>
           

           <tr>
                <td>
                    Mensagem dos Noivos:</td>
                                            <td>
                                                <asp:TextBox ID="txtMsgNoivos" runat="server" Width="440px" MaxLength="500" 
                                                    TextMode="MultiLine" Height="196px"></asp:TextBox>

                                                                    <br />

                                                                    Caracteres digitados: <span id="spanDisplayMsgNoivos"></span>

                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="txtMsgNoivos" ErrorMessage="a quantidade máxima é de 500 caracteres" 
                    ValidationExpression="^[\s\S]{0,500}$"></asp:RegularExpressionValidator>
                                            </td>
                                        </tr>

                                        </tr>

           </tr>
           <tr>
                                            <td>
                                                Código do Pacote:</td>
                <td>
                    <asp:TextBox ID="txtCdPacote" runat="server" Width="40px" MaxLength="3"></asp:TextBox>    </td>
           </tr>
           <tr>
                                            <td>
                                                Tipo de Cota:</td>
                <td>
                    <asp:TextBox ID="txtTipoCota" runat="server" Width="40px" MaxLength="1"></asp:TextBox>    &nbsp;&nbsp;    F = Flores P = Pedras
                </td>
           </tr>
           <tr>
                <td>Valor da Primeira Cota:</td>
                <td>
                    <asp:TextBox ID="txtValor1" runat="server" Width="70px" MaxLength="20" Text="R$ 50,00"></asp:TextBox>
                </td>
           </tr>
           <tr>
                <td>Valor da Segunda Cota:</td>
                <td>
                    <asp:TextBox ID="txtValor2" runat="server" Width="70px" MaxLength="20" Text="R$ 100,00"></asp:TextBox>
                </td>
           </tr>
           <tr>
                <td>Valor da Terceira Cota:</td>
                <td>
                    <asp:TextBox ID="txtValor3" runat="server" Width="70px" MaxLength="20" Text="R$ 150,00"></asp:TextBox>
                </td>
           </tr>  
           <tr>
                <td>Valor da Quarta Cota:</td>
                <td>
                    <asp:TextBox ID="txtValor4" runat="server" Width="70px" MaxLength="20" Text="R$ 200,00"></asp:TextBox>
                </td>
           <tr>
                <td>Valor da Quinta Cota:</td>
                <td>
                    <asp:TextBox ID="txtValor5" runat="server" Width="70px" MaxLength="20" Text="R$ 250,00"></asp:TextBox>
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
                                         <asp:GridView ID="gridNoivo" runat="server" BackColor="White" 
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
                                    <asp:TemplateField HeaderText="Foto dos Noivos" ItemStyle-Width="3%">
                <ItemTemplate>                                        
                    <asp:ImageButton ID="btnImagemNoivo" runat="server" 
                        CommandArgument='<%#Eval("CD_NOIVO")%>' ImageUrl="~/img/icones_63.png" 
                       onclick="btnImagemNoivo_Click"  />                   
                </ItemTemplate>

               
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>      
            
            <asp:TemplateField HeaderText="Convidados" ItemStyle-Width="3%">
                       <ItemTemplate>                      
                <div style="text-align: center">                  
                    <asp:ImageButton ID="btnConvidados" runat="server" 
                        CommandArgument='<%#Eval("CD_NOIVO")%>' ImageUrl="~/img/icones_137.png" 
                        onclick="btnConvidados_Click" />                   
                        </div>
                </ItemTemplate>
                
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>          
                     
            <asp:TemplateField HeaderText="Alt " ItemStyle-Width="3%">
                       <ItemTemplate>                      
                <div style="text-align: center">                  
                    <asp:ImageButton ID="btnAlterar" runat="server" 
                        CommandArgument='<%#Eval("CD_NOIVO")%>' ImageUrl="~/img/icones_101.png" 
                        onclick="btnAlterar_Click"/>                   
                        </div>
                </ItemTemplate>
                
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Excluir" ItemStyle-Width="3%">
                <ItemTemplate>
                    <div style="text-align: center">
                        <asp:ImageButton ID="btnExcluir" runat="server" 
                            CommandArgument='<%#Eval("CD_NOIVO")%>' ImageUrl="~/img/icones_120.png" 
                            onclick="btnExcluir_Click" style="text-align: center; " />
                    </div>
                    <br />
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>          
            
            <asp:TemplateField HeaderText="NOME DOS NOIVOS" ItemStyle-Width="10%">
                <ItemTemplate>
                 <%#Eval("NOME_NOIVOS")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="DATA DO CASAMENTO" ItemStyle-Width="5%">
                <ItemTemplate>
                 <%#Eval("DATA_CASAMENTO", "{0:dd/MM/yyyy}")%>
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

