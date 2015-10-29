<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MiniControlLibro.ascx.cs" Inherits="Agapea.App_Code.Controles_Personalizados.MiniControlLibro" %>
<style type="text/css">
    .auto-style1 {
        width: 377px;
        height: 164px;
    }
    .auto-style2 {
        width: 104px;
    }
    .auto-style3 {
        height: 35px;
    }
</style>

<table class="auto-style1">
    <tr>
        <td rowspan="4" class="auto-style2">
            <asp:Image ID="imagenLibro" runat="server" Height="101px" ImageAlign="Middle" Width="90px" ImageUrl="~/imagenes/iconLibro.png" />
        </td>
        <td style="width=auto" colspan="3">
            <asp:LinkButton ID="linkButtonTitulo" runat="server" Font-Size="Large" BackColor="White" Font-Bold="True" ForeColor="#FF702B">aqui..va..el...titulo</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:Label ID="labelAutor" runat="server" ForeColor="Black" Text="nombreAutor"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Label ID="nombreEditorial" runat="server" ForeColor="#333333" Text="editorial..."></asp:Label>
        </td>
        <td class="auto-style3" colspan="2">
            <asp:Label ID="labelISBN" runat="server" ForeColor="#663300" Text="ISBN"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="labelPrecio" runat="server" ForeColor="Black" Text="elprecio" Font-Bold="True" Font-Size="Large"></asp:Label>
        </td>
        <td>
            <asp:ImageButton ID="ImageButton1" runat="server" Height="31px" ImageUrl="~/imagenes/btnComprar.png" Width="101px" />
        </td>
    </tr>
</table>

