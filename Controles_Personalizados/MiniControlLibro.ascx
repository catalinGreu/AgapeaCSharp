<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MiniControlLibro.ascx.cs" Inherits="Agapea.App_Code.Controles_Personalizados.MiniControlLibro" %>
<style type="text/css">
    .auto-style1 {
        width: 369px;
        height: 129px;
    }
</style>

<table class="auto-style1">
    <tr>
        <td style="width:auto" rowspan="3">
            <asp:Image ID="imagenLibro" runat="server" Height="81px" ImageAlign="Middle" Width="90px" ImageUrl="~/imagenes/btnRegister.png" />
        </td>
        <td style="width=auto" colspan="3">
            <asp:LinkButton ID="linkButtonTitulo" runat="server" Font-Size="Large">aqui..va..el...titulo</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td style="width:auto" colspan="2">
            <asp:Label ID="labelAutor" runat="server" ForeColor="#009900" Text="nombreAutor"></asp:Label>
        </td>
        <td>
            <asp:Label ID="nombreEditorial" runat="server" ForeColor="Red" Text="editorial..."></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width:auto">
            <asp:Label ID="labelPrecio" runat="server" ForeColor="#333300" Text="elprecio"></asp:Label>
        </td>
        <td style="width:auto">
            <asp:Label ID="labelISBN" runat="server" ForeColor="#FF0066" Text="ISBN"></asp:Label>
        </td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Comprar" />
        </td>
    </tr>
</table>

