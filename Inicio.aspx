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
            width: 120px;
        }
        .auto-style4 {
            height: 38px;
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
                    <asp:TreeView ID="myTreeView" runat="server" Height="254px" ImageSet="BulletedList" Width="199px" ShowExpandCollapse="False">
                        <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                        <Nodes>
                            <asp:TreeNode Text="Categorias" Value="Categorias">
                                <asp:TreeNode Text="Aventuras" Value="Aventuras"></asp:TreeNode>
                                <asp:TreeNode Text="Thriller" Value="Thriller"></asp:TreeNode>
                                <asp:TreeNode Text="Academico" Value="Academico"></asp:TreeNode>
                                <asp:TreeNode Text="Historia" Value="Historia"></asp:TreeNode>
                                <asp:TreeNode Text="Autoayuda" Value="Autoayuda"></asp:TreeNode>
                            </asp:TreeNode>
                        </Nodes>
                        <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                        <ParentNodeStyle Font-Bold="False" />
                        <RootNodeStyle BackColor="#6666FF" />
                        <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
                    </asp:TreeView>
                </td>
                <td class="auto-style2">
                    <asp:Table ID="tablaLibros" runat="server" Height="299px" Width="607px">
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