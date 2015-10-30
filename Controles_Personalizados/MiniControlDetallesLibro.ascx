<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MiniControlDetallesLibro.ascx.cs" Inherits="Agapea.Controles_Personalizados.MiniControlDetallesLibro" %>
<style type="text/css">
    .auto-style1 {
        width: 84%;
    }
    .auto-style2 {
        width: 184px;
    }
    .auto-style3 {
        width: 401px;
    }
</style>

<table style="width:auto;">
    <tr>
        <td class="auto-style2" rowspan="7">
            <asp:Image ID="Image1" runat="server" Height="238px" ImageAlign="Middle" ImageUrl="~/imagenes/libroDetalles.png" Width="227px" />
        </td>
        <td class="auto-style3"><asp:Label ID="labelTitulo" runat="server" Font-Bold="False" Font-Names="Segoe UI" Font-Size="XX-Large"></asp:Label>
        </td>
        <td colspan="2">
            <asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/camion.png" />
        </td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Label ID="labelAutor" runat="server" Text="Label" Font-Names="Segoe UI"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Label ID="labelED" runat="server" Text="Label" Font-Names="Segoe UI"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Label ID="labelNumPag" runat="server" Font-Names="Segoe UI" Text="Label"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Label ID="labelResum" runat="server" Font-Names="Segoe UI" Text="Label"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
            ISBN: <asp:Label ID="labelISBN10" runat="server" Text="Label"></asp:Label>
            &nbsp;&nbsp;&nbsp; ISBN-13:
            <asp:Label ID="labelISBN13" runat="server" Text="Label" Font-Bold="True"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Label ID="labelPrecio" runat="server" Text="Label"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Image ID="Image3" runat="server" ImageUrl="~/imagenes/recomendar.png" />
        </td>
        <td colspan="2">
            <asp:ImageButton ID="comprarLibro" runat="server" Height="41px" ImageUrl="~/imagenes/btnCompraGrande.png" Width="179px" />
        </td>
    </tr>
</table>

