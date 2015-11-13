<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VistaCesta.aspx.cs" Inherits="Agapea.VistaCesta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Cesta</title>
    <link href="Bootstrap/css/bootstrap.min.css" rel="stylesheet" />

    <style>
        #content {
            position: relative;
            top: 120px;
        }

        .auto-style1 {
            float: left;
            width: 889px;
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
        #info{
            float:right;
        }
    </style>
</head>
<body style="max-width: 100%; overflow-x: hidden;">
    <div id="container" class="container">
        <nav class="navbar navbar-default navbar-fixed-top">
            <div id="cabecera" class="navbar-collapse collapse">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/cabecera.png" />
            </div>
        </nav>
        <form id="form1" runat="server">

            <div class="container">
                <div class="row row-offcanvas row-offcanvas-right">
                    <div class="col-xs-12 col-sm-10">
                        <div id="content" class="jumbotron">
                            <h2>Items cesta</h2>
                            <asp:Table ID="tablaItems" runat="server" CssClass="table table-hover"></asp:Table>
                            <div>
                                <span id="subtotal" class="col-xs-12 col-sm-10">
                                    <h2>Subtotal: </h2>
                                </span>
                                <span id="precioFinal">
                                    <h2>
                                        <asp:Label ID="labelSubtotal" runat="server" Text="Label"></asp:Label></h2>
                                </span>


                            </div>
                        </div>
                        <div id="info"></div>
                    </div>

                </div>

            </div>


        </form>
        <footer class="footer">
            <div id="pie">
                <asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/pie.png" />
            </div>
        </footer>
    </div>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
