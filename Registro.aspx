<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Agapea.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="max-width:100%; overflow-x:hidden;">
<head runat="server">
    <title>Registro</title>
    <style type="text/css">
        .auto-style1 {
            width: 825px;
            height: 227px;
            margin-left: 158px;
        }
        .auto-style2 {
            width: 100%;
            margin-left: 109px;
        }
        .auto-style10 {
            width: 81%;
            margin-left: 352px;
            height: 36px;
        }
        .auto-style11 {
            width: 94%;
            height: 183px;
            margin-left: 353px;
        }
        .auto-style14 {
            width: 198px;
        }
        .auto-style17 {
            width: 154px;
        }
        .auto-style18 {
            width: 154px;
            height: 62px;
        }
        .auto-style19 {
            width: 198px;
            height: 62px;
        }
        .auto-style20 {
            height: 62px;
        }
        .auto-style21 {
            width: 209px;
        }
        .auto-style22 {
            width: 209px;
            height: 62px;
        }
        .auto-style23 {
            width: 167%;
            height: 81px;
        }
        .auto-style24 {
            width: 174px;
        }
        .auto-style25 {
            width: 83%;
            height: 42px;
        }
    </style>
</head>
<body style="max-width:100%; overflow-x:hidden;">
    <form id="form1" runat="server">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/cabecera.png" />
    <table class="auto-style2">
        <tr>
            <td>
                <img class="auto-style1" longdesc="http://localhost:3295/imagenes/cabecera_form.png" src="imagenes/cabecera_form.png" /></td>
            
        </tr>
       
    </table>
        <table class="auto-style11">
            <tr>
                <td class="auto-style21">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="Large" Text="Usuario"></asp:Label>
                </td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style14">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="False" Font-Names="Calibri" Font-Size="Large" Text="Correo"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style21">
                    <asp:TextBox ID="inputUsuario" runat="server" Font-Names="Calibri" Font-Size="Large" Height="20px" Width="190px"></asp:TextBox>
                </td>
                <td class="auto-style17">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="inputUsuario" ErrorMessage="Campo necesario" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style14">
                    <asp:TextBox ID="inputCorreo" runat="server" Font-Names="Calibri" Font-Size="Large" Height="20px" Width="190px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="inputCorreo" ErrorMessage="Campo necesario" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style21">&nbsp;</td>
                
            </tr>
             <tr>
                <td class="auto-style21">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="Large" Text="Contraseña"></asp:Label>
                 </td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style14">
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="Large" Text="Repite contraseña"></asp:Label>
                 </td>
                <td>&nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style21">
                    <asp:TextBox ID="inputPasswd" runat="server" Font-Names="Calibri" Font-Size="Large" Height="20px" TextMode="Password" Width="190px"></asp:TextBox>
                 </td>
                <td class="auto-style17">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="inputPasswd2" ControlToValidate="inputPasswd" ErrorMessage="No coinciden" ForeColor="Red"></asp:CompareValidator>
                 </td>
                <td class="auto-style14">
                    <asp:TextBox ID="inputPasswd2" runat="server" Font-Names="Calibri" Font-Size="Large" Height="20px" TextMode="Password" Width="190px"></asp:TextBox>
                 </td>
                <td>
                    <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="inputPasswd" ControlToValidate="inputPasswd2" ErrorMessage="No coinciden" ForeColor="Red"></asp:CompareValidator>
                 </td>
            </tr>
            <tr>
                <td class="auto-style21"></td>
                
            </tr>
            <tr>
                <td class="auto-style22">
                    <asp:Label ID="Label5" runat="server" Text="Datos personales" Font-Bold="True" Font-Names="Calibri" Font-Size="X-Large"></asp:Label>
                </td>
                <td class="auto-style18"></td>
                <td class="auto-style19"></td>
                <td class="auto-style20"></td>
                <td class="auto-style20"></td>
            </tr>
            <tr>
                <td class="auto-style21"></td>
                
            </tr>
            <tr>
                <td class="auto-style21">
                    <asp:Label ID="Label6" runat="server" Text="Nombre" Font-Bold="True" Font-Names="Calibri" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style17"></td>
                <td class="auto-style14">
                    <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="Large" Text="Apellidos"></asp:Label>
                </td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style21">
                    <asp:TextBox ID="inputNombre" runat="server" Font-Names="Calibri" Font-Size="Large" Height="20px" Width="190px"></asp:TextBox>
                </td>
                <td class="auto-style17">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="inputNombre" ErrorMessage="Campo necesario" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style14">
                    <asp:TextBox ID="inputApellidos" runat="server" Height="20px" Width="190px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="inputApellidos" ErrorMessage="Campo necesario" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style21"></td>
                
            </tr>
        </table>
    <p>
        <table class="auto-style10">
            <tr>
                <td>
                    <asp:ImageButton ID="registerButton" runat="server" ImageUrl="~/imagenes/btnRegister.png" OnClick="registerButton_Click" />
                    <table class="auto-style25">
                        <tr>
                            <td class="auto-style24">&nbsp;</td>
                            <td>
                                <asp:Label ID="labelConfirm" runat="server" Enabled="False" ViewStateMode="Disabled"></asp:Label>
                            </td>
                        </tr>
                        
                    </table>
                </td>
                
            </tr>
            
        </table>
    </p>
    
    <table class="auto-style23">
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/pie.png" />
            </td>
        </tr>
       
    </table>
        
    </form>
        
    </body>
</html>
