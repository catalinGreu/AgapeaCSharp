<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Agapea.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 497px;
        }
        .auto-style2 {
            height: 358px;
        }
        .auto-style3 {
            height: 358px;
            width: 1px;
        }
        .auto-style4 {
            height: 38px;
        }
        .auto-style5 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style4" colspan="2">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/cabecera.png" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:TreeView ID="myTreeView" runat="server" Height="337px" Width="199px" BorderStyle="Ridge" Font-Names="Arial" Font-Size="Large" Font-Strikeout="False" Font-Underline="True" ForeColor="Black">
                        <Nodes>
                            <asp:TreeNode Text="Categorias" Value="Categorias">
                                <asp:TreeNode Text="Aventuras" Value="Aventuras"></asp:TreeNode>
                                <asp:TreeNode Text="Thriller" Value="Thriller"></asp:TreeNode>
                                <asp:TreeNode Text="Academico" Value="Academico"></asp:TreeNode>
                                <asp:TreeNode Text="Historia" Value="Historia"></asp:TreeNode>
                                <asp:TreeNode Text="Autoayuda" Value="Autoayuda"></asp:TreeNode>
                                <asp:TreeNode Text="Todos" Value="Todos"></asp:TreeNode>
                            </asp:TreeNode>
                        </Nodes>
                        <RootNodeStyle BackColor="#6666FF" />
                    </asp:TreeView>
                </td>
                <td class="auto-style2">
                    <asp:Table ID="tablaLibros" runat="server" Height="299px" Width="607px" CssClass="auto-style5">
                    </asp:Table>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:TextBox ID="TextBox1" runat="server" Height="214px" TextMode="MultiLine" Width="303px" EnableViewState="False"></asp:TextBox>
                    <asp:Button ID="ButtonCompra" runat="server" Text="Comprar" />
                    <asp:Label ID="LabelUser" runat="server"></asp:Label>
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/pie.png" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>