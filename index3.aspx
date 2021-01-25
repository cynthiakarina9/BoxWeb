<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index3.aspx.cs" Inherits="BoxWeb.index3" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Mynfo</title>

    <!-- Bootstrap core CSS -->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom styles for this template -->
    <link href="css/modern-business.css" rel="stylesheet">

</head>

<body style="background-color: #FF6633;">
    <form id="form2" runat="server">

    <!-- Navigation -->
    <nav class="navbar fixed-top navbar-expand-lg navbar-dark bg-dark fixed-top">
        <div class="container">
            <a class="navbar-brand" href="index.html" style="color: #FF6633;"><b>Mynfo</b></a>
            <a href="#"><img src="Images store/disponible-en-google-play-badge-2.png" style="height: 35px;"></a>
            <a href="#"><img src="Images store/Publicar-una-App-en-el-App-Store.png" style="height: 35px;"></a>
    </nav>

    <!-- Page Content -->
    <div class="container" style="padding: 30px; padding-bottom: 50px; padding-top: 50px; border-radius: 50%;">

        <!-- Marketing Icons Section -->
        <center>
            <div class="row">
                <div class="col-lg-4 mb-4" style="margin-left: auto; margin-right:auto;">
                    <div class="card h-100" style="border-radius: 30px;">

                        
                        <h4 class="card-header">  <asp:Image ID="Image1" runat="server" style="height: 49px; border-radius: 50%;"></asp:Image>&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label runat="server" ID="Label_name" Text=""></asp:Label> </h4>
                        <div class="card-body">                                                                                                                                                             
                            <div id="div1" runat="server"></div>
                        </div>
                    </div>
                </div>
            </div>
        </center>

        <center>
            <a href="#" class="btn btn-primary" style="color: #000; border-radius: 30px;"><b>Conoce mas de Mynfo</b></a>

        </center>
        <!-- /.row -->
        <hr>
    </div>
    <!-- Footer -->
    <footer class="py-5 bg-dark">
        <div class="container">
            <p class="m-0 text-center" style="color: #FF6633;">Copyright &copy; Mynfo 2021</p>
        </div>
        <!-- /.container -->
    </footer>

    <!-- Bootstrap core JavaScript -->
    <script src="vendor/jquery/jquery.min.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    </form>
</body>

</html>
