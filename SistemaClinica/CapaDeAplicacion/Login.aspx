<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="CapaDeAplicacion.Login" %>

<!DOCTYPE html>

<html class="bg-black" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css" rel="stylesheet" type="text/css"/>
    <link href="//cdnjs.cloudflare.com/ayax/libs/font-awesome/4.1.0/css/font-awesome.min.css" rel="stylesheet" type="text/css"/>
    <link href="css/AdminLTE.css" rel="stylesheet"type="text/css"/>

    <title>Acceso al Sistema Clinica</title>
</head>
<body class="bg-black">
    <div class="form-box" id="login-box"> 
        <div class ="header"> Login </div>
        <form id="form1" runat="server">
            <div class="body bg-gray">
                <div class="form-group">
                    <asp:TextBox ID="TxtUsuario" runat="server" CssClass="form-control" placeholder="ingrese usuario"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="TxtPassword" runat="server" CssClass="form-control" placeholder="ingrese clave"></asp:TextBox>
                </div>
            </div>
            <div class="footer">
                <asp:Button ID="btnIngresar" runat="server" Text="Iniciar Sesion" CssClass="btn bg-olive btn-block" />
            </div>
           
         </form>
    </div>
    <script src="//ayax.googleapis.com/ayax/libs/jquery/2.1.1/jquery.min.js"></script>
    <script src="//maxcdn.bootrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js"type="text/javascript"></script>
</body>
</html>
