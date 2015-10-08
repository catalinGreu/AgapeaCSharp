﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Agapea.Inicio" %>

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
            width: 215px;
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
                <td class="auto-style3"></td>
                <td class="auto-style2">
                    <asp:Table ID="tablaLibros" runat="server" Height="299px" Width="607px">
                    </asp:Table>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="LabelUser" runat="server"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" Height="235px" TextMode="MultiLine" Width="547px" EnableViewState="False"></asp:TextBox>
                    <asp:Button ID="ButtonCompra" runat="server" Text="Comprar" />
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/pie.png" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>