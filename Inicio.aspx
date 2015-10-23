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
        .auto-style4 {
            height: 38px;
        }
        .auto-style5 {
            margin-left: 0px;
        }
        .auto-style7 {
            width: 179px;
        }
        .auto-style8 {
            margin-left: 0px;
            margin-right: 0px;
        }
        .auto-style9 {
            height: 358px;
            width: 255px;
        }
        .auto-style10 {
            width: 100%;
        }
        .auto-style11 {
            width: 143px;
        }
        .auto-style12 {
            width: 110px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="cabecera">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/cabecera.png" />
    </div>
     <div id="busqueda">
                             <table class="auto-style10">
                        <tr>
                            <td class="auto-style12">
                            </td>
                            
                            <td class="auto-style7">
                                <asp:TextBox ID="inputBusqueda" runat="server" Height="24px" Width="480px" CssClass="auto-style5"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button ID="botonBusqueda" runat="server" CssClass="auto-style5" Height="32px" Text="Buscar" Width="158px" />
                            </td>
                        </tr>
                        <tr>
                            
                            <td class="auto-style11">
                            </td>
                            <td>
                                <asp:RadioButton ID="radioButtonTitulo" runat="server" />
                                <asp:Label ID="Label1" runat="server" Text="Titulo"></asp:Label>
                                <asp:RadioButton ID="radioButtonAutor" runat="server" />
                                <asp:Label ID="Label2" runat="server" Text="Autor"></asp:Label>
                                <asp:RadioButton ID="radioButtonIsbn" runat="server" />
                                <asp:Label ID="Label3" runat="server" Text="ISBN"></asp:Label>
                            </td>
                            <td class="auto-style7">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>

                    </table>

     </div>

    <div id="treeview" style="float:left;width:20%">
                            <asp:TreeView ID="myTreeView" runat="server" Height="347px" Width="199px" BorderStyle="Ridge" Font-Names="Arial" Font-Size="Large" Font-Strikeout="False" Font-Underline="True" ForeColor="Black" ImageSet="BulletedList" ShowExpandCollapse="False">
                        <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
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
                        <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                        <ParentNodeStyle Font-Bold="False" />
                        <RootNodeStyle BackColor="#6666FF" />
                        <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
                    </asp:TreeView>

    </div>
    <div id="tablaLibrosASP" style="float:right;width:80%">
        <asp:Table ID="tablaLibros" runat="server" Height="299px" Width="656px" CssClass="auto-style8"></asp:Table>
    </div>
     
     <div id="piePagina">
                     <asp:TextBox ID="TextBox1" runat="server" Height="221px" TextMode="MultiLine" Width="545px" EnableViewState="False"></asp:TextBox>
                    <asp:Button ID="ButtonCompra" runat="server" Text="Comprar" />
                    <asp:Label ID="LabelUser" runat="server"></asp:Label>
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/pie.png" />
     </div>




    </form>
</body>
</html>