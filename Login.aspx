<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Agapea.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log In</title>
    <style>
        #mydiv {
            position: fixed;
            top: 50%;
            left: 50%;
            width: 30em;
            height: 18em;
            margin-top: -9em; /*set to a negative number 1/2 of your height*/
            margin-left: -15em; /*set to a negative number 1/2 of your width*/
            border: 1px solid #ccc;
            background-color: #f3f3f3;
        }

        #pie {
            position: absolute bottom:30px;
            width: 100%;
        }
        #contenedor {
            position:relative;
            width:auto;
        }

        .auto-style1 {
            width: 100%;
            height: 285px;
        }

        .auto-style2 {
            width: 70px;
        }

        .auto-style3 {
            width: 234px;
        }

        .auto-style5 {
            font-size: large;
            color: #CC0000;
            font-weight: bold;
        }
    </style>
    <link href="Bootstrap/css/bootstrap.css" rel="stylesheet"/>
</head>

<body>

    <div id="contenedor">
        <table style="width: 100%;">
            <tr>
                <td>
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/cabecera.png" />
                </td>
            </tr>
        </table>
        <div id="mydiv">

            <form id="form1" runat="server">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Segoe UI" Font-Size="X-Large" ForeColor="#202020" Text="Login"></asp:Label>
                        </td>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:TextBox ID="inputLogin" runat="server" Height="20px" Width="185px"></asp:TextBox>
                        </td>
                        <td colspan="2">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo necesario" Font-Bold="True" ForeColor="#CC0000" ControlToValidate="inputLogin"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:TextBox ID="inputPass" runat="server" Height="21px" Width="183px" MaxLength="20" TextMode="Password"></asp:TextBox>
                        </td>
                        <td colspan="2">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campo necesario" Font-Bold="True" ForeColor="#CC0000" ControlToValidate="inputPass"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="auto-style2">
                            <asp:Button ID="btnRegistro" runat="server" Text="Registrar" CssClass="btn btn-primary"/>
                        </td>
                        <td>
                            <asp:Button ID="btnEntrar" runat="server" Text="Identificar" CssClass="btn btn-primary"/>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3" class="auto-style5">
                            <asp:Label ID="labelError" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                </table>
            </form>
        </div>
        <div id="pie">
            <table>
                <tr>
                    <td>
                        <asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/pie.png" />
                    </td>
                </tr>
            </table>
        </div>

    </div>





</body>
</html>
