<%@ Page EnableEventValidation="true" Language="C#" AutoEventWireup="true" CodeBehind="VistaLogin.aspx.cs" Inherits="Agapea.VistaLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="Bootstrap/css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="contenedor">
            <table style="width: 100%;">
                <tr>
                    <td>
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/cabecera.png" />
                    </td>
                </tr>
            </table>

            <div class="container col-lg-push-4 col-xs-4">
                <form class="form-signin">
                    <h2 class="form-signin-heading">Login</h2>
                    <label for="inputID" class="sr-only">EmailAdress</label>
                    <asp:TextBox ID="inputID" runat="server" CssClass="form-control" placeholder="ID User"></asp:TextBox><span class="form-inline"><asp:RequiredFieldValidator ID="RequiredFieldValidatorID" runat="server" ErrorMessage="Faltan campos" Font-Bold="True" ControlToValidate="inputID" ForeColor="#CC0000"></asp:RequiredFieldValidator></span>
                    <label for="inputPassword" class="sr-only">Password</label>
                    <br />
                    <asp:TextBox ID="inputPass" runat="server" TextMode="Password" CssClass="form-control" placeholder="Password"></asp:TextBox><span class="form-inline"><asp:RequiredFieldValidator ID="RequiredFieldValidatorPass" runat="server" ErrorMessage="Faltan campos" Font-Bold="True" BackColor="White" BorderColor="White" ControlToValidate="inputPass" ForeColor="#CC0000"></asp:RequiredFieldValidator></span>
                    <div class="checkbox">
                        <label>
                            <input type="checkbox" value="Recordar">Recuerdame</input>
                        </label>
                    </div>
                    <asp:Button ID="botonEntrar" runat="server" Text="Identificame" CssClass="btn btn-lg btn-primary btn-block" OnClick="botonEntrar_Click" />
                    <asp:Button ID="btonRegistro" runat="server" Text="Registrame" CssClass="btn btn-lg btn-primary btn-block" OnClick="btonRegistro_Click" />
                </form>
            </div>
            <span>
                <asp:Label ID="labelError" runat="server" Text="Label" ForeColor="#CC0000"></asp:Label>
            </span>

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

    </form>
</body>
</html>
