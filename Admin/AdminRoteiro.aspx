<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="AdminRoteiro.aspx.cs" Inherits="Admin_AdminRoteiro"  enableEventValidation="false" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script type="text/javascript">
    function countMsgNoivos(clientId) {
        var txtInput = document.getElementById(clientId);
        var spanDisplay = document.getElementById('spanDisplayDetalhe');
        spanDisplay.innerHTML = txtInput.value.length;
    }
</script>

<h1>Manutenção de Roteiros</h1>
            
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
                                                Nome:</td>
                <td>
                    <asp:TextBox ID="txtNome" runat="server" Width="440px" MaxLength="50"></asp:TextBox>
                </td>
           </tr>
                       <tr>
                                            <td>
                                                Data</td>
                <td>
                    <asp:TextBox ID="txtDtRoteiro" runat="server" Format="dd/MM/yyyy" Width="100px" MaxLength="50" OnTextChanged="txtDtRoteiro_TextChanged"></asp:TextBox>
                    <asp:CalendarExtender ID="txtDtRoteiro_CalendarExtender" runat="server" Enabled="True" TargetControlID="txtDtRoteiro" Format="dd/MM/yyyy">
                    </asp:CalendarExtender>
                    <br />
                    <asp:ScriptManager ID="ScriptManager" runat="server">
                    </asp:ScriptManager>
                </td>
           </tr>            <tr>
                                            <td class="auto-style1">
                                                Horario<td class="auto-style1">
                                                <asp:TextBox ID="txtHorario" runat="server"></asp:TextBox>
                </td>
           </tr>
            <tr>
                                            <td class="auto-style1">
                                                Destino:<td class="auto-style1">
                    <asp:TextBox ID="txtDestino" runat="server" Width="440px" MaxLength="50"></asp:TextBox>
                </td>
           </tr>
                       <tr>
                                            <td>
                                                Mapa:</td>
                <td>
                    <asp:TextBox ID="txtMapa" runat="server" Width="440px" MaxLength="50"></asp:TextBox>
                </td>
           </tr>
                       <tr>
                                            <td>
                                                Endereço:</td>
                <td>
                    <asp:TextBox ID="txtEndereco" runat="server" Width="440px" MaxLength="50"></asp:TextBox>
                </td>
           </tr>
           

           <tr>
                <td>
                    Detalhe:</td>
                                            <td>
                                                <asp:TextBox ID="txtDetalhe" runat="server" Width="440px" MaxLength="500" 
                                                    TextMode="MultiLine" Height="196px"></asp:TextBox>

                                                                    <br />

                                                                    Caracteres digitados: <span id="spanDisplayDetalhe"></span>

                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="txtDetalhe" ErrorMessage="a quantidade máxima é de 1000 caracteres" 
                    ValidationExpression="^[\s\S]{0,1000}$"></asp:RegularExpressionValidator>
                                            </td>
                                        </tr>

                                        </tr>

           </tr>
           <tr>
                                            <td>
                                                &nbsp;</td>
                <td>
                    <asp:Label ID="lblimagem" runat="server" Text=""></asp:Label>  </td>
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
                                         <asp:GridView ID="gridRoteiro" runat="server" BackColor="White" 
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
                                    <asp:TemplateField HeaderText="Foto" ItemStyle-Width="3%">
                <ItemTemplate>                                        
                    <asp:ImageButton ID="btnImagem" runat="server" 
                        CommandArgument='<%#Eval("CD_ROTEIRO")%>' ImageUrl="~/img/icones_63.png" OnClick="btnImagem_Click" />                   
                </ItemTemplate>

               
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>      
       
                     
            <asp:TemplateField HeaderText="Alt " ItemStyle-Width="3%">
                       <ItemTemplate>                      
                <div style="text-align: center">                  
                    <asp:ImageButton ID="btnAlterar" runat="server" 
                        CommandArgument='<%#Eval("CD_ROTEIRO")%>' ImageUrl="~/img/icones_101.png" 
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
                            CommandArgument='<%#Eval("CD_ROTEIRO")%>' ImageUrl="~/img/icones_120.png" 
                            onclick="btnExcluir_Click" style="text-align: center; " />
                    </div>
                    <br />
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>          
            
            <asp:TemplateField HeaderText="Nome do Roteiro" ItemStyle-Width="10%">
                <ItemTemplate>
                 <%#Eval("NOME")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Ponto Turístico" ItemStyle-Width="10%">
                <ItemTemplate>
                 <%#Eval("DESTINO")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Data" ItemStyle-Width="5%">
                <ItemTemplate>
                 <%#Eval("DATA", "{0:dd/MM/yyyy}")%>
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

