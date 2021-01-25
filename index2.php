<!DOCTYPE html>
<html lang="es">

<head>

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

    <?php
        $conn_array = array (
            "UID" => "adminmynfo",
            "PWD" => "4dmiNFC*Atx2020",
            "Database" => "Mynfo",
        );
        $conn = sqlsrv_connect('serverappmynfo', $conn_array);
        if ($conn){
            echo "connected";
            if(($result = sqlsrv_query($conn,"SELECT * FROM routines")) !== false){
                while( $obj = sqlsrv_fetch_object( $result )) {
                      echo $obj->colName.'<br />';
                }
            }
        }else{
            die(print_r(sqlsrv_errors(), true));
        }
    ?>

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

                        <h4 class="card-header"><img src="Images\perfil-de-buyer-persona-750x480.jpg" style="height: 49px; border-radius: 50%;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Harumi Sosa</h4>
                        <div class="card-body">
                            <div style="display:inline-block;">
                                <a href="#"><img src="Image social/Whats_icono.png" style="height: 84px; padding: 5px;"></a>
                            </div>
                            <div style="display:inline-block;">
                                <a href="#"><img src="Image social/Mail_icono.png" style="height: 84px; padding: 5px;"></a>
                            </div>
                            <div style="display:inline-block;">
                                <a href="#"><img src="Image social/Tel_icono.png" style="height: 84px; padding: 5px;"></a>
                            </div>
                            <div style="display:inline-block;">
                                <a href="#"><img src="Image social/instagram_icono.png" style="height: 84px; padding: 5px;"></a>
                            </div>
                            <div style="display:inline-block;">
                                <a href="#"><img src="Image social/Spoty_icono.png" style="height: 84px; padding: 5px;"></a>
                            </div>
                            <div style="display:inline-block;">
                                <a href="#"><img src="Image social/Twitterlogo_icono.png" style="height: 84px; padding: 5px;"></a>
                            </div>
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

</body>

</html>