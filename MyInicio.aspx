<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/Paginas_Maestras/MaestraVistasPrincipales.Master" AutoEventWireup="true" CodeBehind="MyInicio.aspx.cs" Inherits="Agapea.MyInicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <style type="text/css">
    .auto-style7 {
        margin-left: 21px;
    }
</style>
    
</asp:Content>

    
        <asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
        
            <asp:TextBox ID="TextBox1" runat="server" Height="167px" TextMode="MultiLine" Width="272px"></asp:TextBox>
            <asp:Table ID="tablaLibros" runat="server" Height="190px" Width="772px" CssClass="auto-style7"></asp:Table>
        
        </asp:Content>
    
        


