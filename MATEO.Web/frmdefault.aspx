<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmdefault.aspx.cs" Inherits="MATEO.Web.frmdefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>.:: MATEO ::.</title>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1/jquery.min.js"></script>
    <script src="Recursos/Script/ImageRotator/mb.bgndGallery.js"></script>
    <link href="Recursos/Themes/Green/Frame.css" rel="stylesheet" />
    <style type="text/css">




      
    </style>
    <script type="text/javascript">

        $(function () {

            $.mbBgndGallery.buildGallery({
                // containment:"#wrapper",
                containment: "#video",
                timer: 4000,
                effTimer: 2000,
                controls: "#controls",
                grayScale: false,
                // If your server allow directory listing
                //folderPath:"elements/",
                // else:
                images: [
                            "Recursos/Image/ImageRotator/1.jpg",
                            "Recursos/Image/ImageRotator/2.jpg",
                            "Recursos/Image/ImageRotator/3.jpg",
                            "Recursos/Image/ImageRotator/4.jpg",
                            "Recursos/Image/ImageRotator/5.jpg",
                            "Recursos/Image/ImageRotator/6.jpg",
                            "Recursos/Image/ImageRotator/7.jpg",
                            "Recursos/Image/ImageRotator/8.jpg",
                            "Recursos/Image/ImageRotator/9.jpg",
                            "Recursos/Image/ImageRotator/10.jpg"
                ],
                onStart: function () { $("#controls .play").hide(); $("#controls .pause").show(); },
                onPause: function () { $("#controls .play").show(); $("#controls .pause").hide(); },
                onPlay: function (opt) { $("#controls .play").hide(); $("#controls .pause").show(); },
                onChange: function (idx) { }, //idx=the zero based index of the displayed photo
                onNext: function (opt) { }, //opt=the options relatives to this component instance
                onPrev: function (opt) { } //opt=the options relatives to this component instance
            });
            $(".bw").toggle(
            function () {
                var el = $("#video").get(0);
                el.opt.grayScale = true;
                $(this).addClass("sel");
                el.opt.gallery.find("img:first").greyScale();
            },
            function () {
                var el = $("#video").get(0);
                el.opt.grayScale = false;
                $(this).removeClass("sel");
                el.opt.gallery.find("img:first").attr("src", el.opt.images[el.opt.imageCounter]);
            }
            )
        });
    </script>
    <!-- HEADER -->
    <style type="text/css">
        body
        {
            display: block;
            margin: 0px;
            background-color: rgb(237, 241, 255);
        }

        .header
        {
            /* border: none; */
            /* font-family: Arial; */
            /* font-size: 14px; */
            width: 100%;
            background-color: transparent;
            height: 60px;
        }

        .header_back
        {
            width: 100%;
            height: 35px;
            background-color: #00AA00;
            min-width: 800px;
            position: absolute;
            box-shadow: 7px 7px 7px rgba(126, 197, 118, 0.76);
        }

        .header_left
        {
            display: table-cell;
            width: 400px;
            background-color: #000079;
            height: 55px;
            box-shadow: 7px 7px 7px rgba(126, 197, 118, 0.76);
            box-shadow: 5px 7px 20px rgba(118, 137, 197, 0.76);
        }

        .header_rigth
        {
            display: table-cell;
            color: white;
            width: 65%;
            text-align: center;
            font-size: 20px;
            font-family: Arial;
            /* font: 20px Arial bold; */
            font-weight: bold;
            font-style: oblique;
            padding-top: 5px;
        }

        .header_rigth-img
        {
            position: absolute;
            padding: 5px 0px 5px 70px;
            width: 250px;
        }

        .header_rigth-text
        {
            display: table-row;
            color: white;
            width: 80%;
            text-align: center;
            font-size: 20px;
            font-family: Arial;
            /* font: 20px Arial bold; */
            font-weight: bold;
            font-style: oblique;
            padding-top: 5px;
        }

        .triangulo_top_left
        {
            display: table-cell;
            border-top: 55px solid #000079;
            border-right: 35px solid transparent;
        }
    </style>
    <!-- BODY -->
    <style type="text/css">
        .contenedor
        {
            width: 1160px;
            margin: 0 auto;
        }

        .menu
        {
            padding: 20px 20px 0px 20px;
            width: 100%;
        }

        .menu_left
        {
            display: table-cell;
            width: 50%;
        }

        .menu_left-video
        {
            height: 350px;
            width: 600px;
            border-radius: 10px;
            box-shadow: 7px 7px 7px rgba(126, 197, 118, 0.76);
            border-color: rgb(210, 215, 206);
            border-width: 1px;
            border-style: solid;
        }

        .menu_left-text
        {
            padding-top: 20px;
            padding-left: 20px;
            padding-right: 40px;
        }

            .menu_left-text a
            {
                font-family: Arial;
                font-size: 19px;
                font-style: oblique;
                color: #000091;
                font-weight: bold;
            }

            .menu_left-text p
            {
                font-family: Arial;
                font-size: 15px;
                font-style: oblique;
                color: black;
            }

        .menu_rigth
        {
            display: table-cell;
            width: 50%;
        }

        .menu_rigth-option
        {
            text-align: center;
            padding-left: 50px;
        }

        .menu_rigth-option--button
        {
            border: none;
            background-color: transparent;
            background-image: url("Recursos/Image/menu_option.png");
            background-repeat: no-repeat;
            /* background-position: 5px; */
            width: 295px;
            height: 90px;
            padding-top: 10px;
            /*padding-left: 90px;*/
            color: white;
            font-size: 21px;
            font-family: Arial;
            font-style: oblique;
            font-weight: normal;
        }

        .factura
        {
            background-image: url("Recursos/Image/Charts.png");
            background-repeat: no-repeat;
            background-position: 5px;
        }
        .icon-factura
        {
            background-image: url("Recursos/Image/Charts.png");
            background-repeat: no-repeat;
            /* background-position: 14px; */
            background-position-y: -800%;
            background-position-x: 14px;
            padding-top: 5px;
            padding-left: 90px;
            height: 60px;
            font-family: monospace;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div class="header">
                <div class="header_back">
                    <div class="header_left">
                        <img src="Recursos/Image/Logo.png" alt="Logo" class="header_rigth-img" />
                    </div>
                    <div class="triangulo_top_left">
                    </div>
                    <div class="header_rigth">
                        MENU DE IMPORTACIONES                      
                    </div>
                </div>
            </div>
            <div class="contenedor">
                <table class="menu">
                    <tr>
                        <td style="width: 50%">
                            <div class="menu_left">

                                <div class="menu_left-video" id="video">
                                    <div id="controls" style="display: none">
                                        <div class="pause">
                                            Pause
                                        </div>
                                        <div class="play">
                                            Play
                                        </div>
                                        <div class="prev">
                                            Prev
                                        </div>
                                        <div class="next">
                                            Next
                                        </div>
                                        <div class="counter">
                                        </div>
                                        <div class="bw">
                                        </div>
                                    </div>
                                </div>

                                <div class="menu_left-text">
                                    <a>INNOVACION TECNOLOGICA</a><br />
                                    <p>
                                        Utilizamos, desarrollamos y ofrecemos soluciones tecnológicas, 
                        respondiendo con éxito y rapidez a las necesidades de nuestros 
                        clientes. Logramos que la carga aérea de iportación esté
                        a disposición del iportador en un promedio de cuatro 
                        horas luego de arribada la aeronave.

                        Todas nuestras operaciones utilizan adecuados sistemas de 
                        control, que hacen más seguro, rápido y eficiente el 
                        servicio que reciben nuestros clientes:<br />
                                        <b>- TalmaNet -</b> Sistema que permite el tracking de la carga.<br />
                                        <b>- MATEO -</b> Módulo de Atención Electrónica de Operaciones<br />
                                        <b>- SIOP -</b> Sistema Integral de Operaciones.<br />
                                    </p>
                                </div>
                            </div>
                        </td>
                        <td style="width: 50%">
                            <div class="menu_rigth">
                                <div class="menu_rigth-option">

                                    
                                    <button type="button" class="menu_rigth-option--button" onclick="alert('demos')">                                    
                                        <div class="icon-factura">
                                             Descargar <br /> Facturas
                                        </div>                                       
                                    </button>                                    
                                    <br />
                                    <br />
                                      <button type="button" class="menu_rigth-option--button">                                    
                                        <div class="icon-factura">
                                             Consulta de <br /> Revalidación
                                        </div>                                       
                                    </button>      
                                    <br />
                                    <br />
                                      <button type="button" class="menu_rigth-option--button">                                    
                                        <div class="icon-factura">
                                             Consulta de <br /> Volantes
                                        </div>                                       
                                    </button>      
                                    <br />
                                    <br />
                                      <button type="button" class="menu_rigth-option--button">                                    
                                        <div class="icon-factura">
                                             Simulacion de <br /> Factura
                                        </div>                                       
                                    </button>      
                                    <br />
                                    <br />
                                      <button type="button" class="menu_rigth-option--button">                                    
                                        <div class="icon-factura">
                                             Estadisticas <br /> De Carga
                                        </div>                                       
                                    </button>      
                                    <br />
                                    <br />
                                </div>
                            </div>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
</body>
</html>

