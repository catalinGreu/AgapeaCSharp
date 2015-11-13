<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VistaCesta.aspx.cs" Inherits="Agapea.VistaCesta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Cesta</title>
    <link href="Bootstrap/css/bootstrap.min.css" rel="stylesheet" />

    <style>
        #content {
            position: relative;
            top: 120px;
        }

        #precioFinal {
            float: right;
            display: inline;
        }

        #subtotal {
            display: inline;
        }

        #pie {
            position: absolute bottom:30px;
            width: 100%;
        }

        #info, #detalles {
            position: relative;
            float: right;
        }

        .auto-style1 {
            width: 40%;
            height: 96px;
        }
    </style>
</head>
<body style="max-width: 100%; overflow-x: hidden;">
    <div id="contenedorGrande" class="container" style="position:">
    <div id="container" class="container">
        <nav class="navbar navbar-default navbar-fixed-top">
            <div id="cabecera" class="navbar-collapse collapse">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/cabecera.png" />
            </div>
        </nav>
        <form id="form1" runat="server">

            <div class="container">
                <div class="row row-offcanvas row-offcanvas-right">
                    <div class="col-lg-9 col-xs-pull-1">
                        <div id="content" class="jumbotron">
                            <h2>Items cesta</h2>
                            <asp:Table ID="tablaItems" runat="server" CssClass="table table-hover"></asp:Table>
                            <div>

                                <h2 style="display: inline;">Subtotal: </h2>
                                <label style="float: right; display:inline;">
                                    <h2><asp:Label ID="labelSubtotal" runat="server" Text="Label"></asp:Label></h2>

                                </label>



                            </div>
                        </div>
                        <div id="info"></div>
                    </div>

                </div>
            </div>
            <div id="detalles" runat="server" class="col-lg-9 col-lg-push-5">
                <div class="jumbotron">
                    <h4 style="display: inline;">Gastos de envío: </h4>
                    <label class="label-warning">5 euros</label>
                    <h2>Total: <span>
                        <asp:Label ID="labelTotalCompra" runat="server" Text="Label"></asp:Label></span> </h2>
                    <asp:Button ID="btnVolver" runat="server" Text="Seguir comprando" CssClass="btn btn-lg btn-primary" />
                    <label></label>
                    <asp:Button ID="btnFinalizar" runat="server" Text="Finalizar compra" CssClass="btn btn-lg btn-primary" />
                </div>
            </div>

        </form>
    </div>
    </div>


    <footer class="footer">
        <div id="pie">
            <asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/pie.png" />
        </div>
    </footer>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
