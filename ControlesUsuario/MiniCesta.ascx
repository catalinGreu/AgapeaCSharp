<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MiniCesta.ascx.cs" Inherits="Agapea.ControlesUsuario.MiniCesta" %>
<style type="text/css">
    
    .auto-style2 {
        width: 12px;
    }

    .auto-style5 {
        width: 73px;
    }
    .auto-style6 {
        width: 43px;
    }
    .auto-style8 {
        width: 241px;
        height: 60px;
    }
</style>
 <link href="Bootstrap/css/bootstrap.css" rel="stylesheet"/>
<div>
    <table style="border-style: solid; "auto" class="auto-style8">
        <tr>
            <td class="auto-style2">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/iconCarrito.png" />
            </td>
            <td class="auto-style6" align="center">
                <asp:Label ID="labelItems" runat="server" Font-Bold="True" Font-Names="Segoe UI Symbol" Font-Size="X-Large" ForeColor="#CC0000" Text="0"></asp:Label>
            </td>
            <td align:"center" class="auto-style5">
                <asp:Button ID="botonVerCesta" runat="server" Text="Ver cesta" Width="84px" />
            </td>
        </tr>

    </table>
</div>
