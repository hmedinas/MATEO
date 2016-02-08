<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmBoarULDs.aspx.cs" Inherits="MATEO.Web.ULD.frmBoarULDs" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>.:: ULD ::.</title>
    <link type="image/x-icon" href="favicon.ico" rel="icon" />
    <link type="image/x-icon" href="favicon.ico" rel="shortcut icon" /> 

    <script language="javascript" type="text/javascript">
      
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
            display: flex;
        }

        .header_left
        {
            display: table-cell;
            width: 400px;
            background-color: #000079;
            height: 55px;
            box-shadow: 7px 7px 7px rgba(126, 197, 118, 0.76);
            box-shadow: 5px 7px 20px rgba(118, 137, 197, 0.76);
            display: inline-block;
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
            display: inline-block;
        }

        .header_rigth-img
        {
            position: absolute;
            padding: 5px 0px 5px 70px;
            width: 200px;
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
            display: inline-block;
        }
    </style>

    <!-- loading -->
    <style type="text/css">
        .Loading
        {
            height: 100%;
            width: 100%;
            background: rgba(255, 255, 255, 0.90);
            position: absolute;
            z-index: 10;
            text-align: center;
        }

            .Loading img
            {
            }

        .mensaje
        {
            height: 100%;
            width: 100%;
            background: rgba(144, 139, 139, 0.87);
            /* width: 500px; */
            position: absolute;
            z-index: 11;
            text-align: center;
            padding: 15% 0% 0 35%;
        }

        .mensaje_div
        {
            background-color: white;
            position: absolute;
            width: 400px;
            height: 150px;
            box-shadow: 7px 7px 7px rgba(48, 48, 48, 0.76);
            border-radius: 10px 10px 10px 10px;
        }

        .CloseButton
        {
            /* display: inline-block; */ /* overflow: hidden; */ /* vertical-align: middle; */
            background-color: rgba(198, 202, 201, 0.82);
            color: white;
            width: 60px;
            height: 30px;
            text-align: center;
            padding-top: 5px;
            display: table-cell;
            border-radius: 10px;
            overflow: hidden;
            vertical-align: middle; /* display: block; */
            position: absolute; /* margin-right: 10px; */
            margin-left: 93%;
            margin-top: 0px;
            box-shadow: 4px 4px 4px rgba(126, 197, 118, 0.76);
            /*border-color: rgb(210, 215, 206);
            border-width: 1px;
            border-style: solid;*/
            border-radius: 10em;
            background-color: #0A57AD;
            background: linear-gradient(180deg, #0B66CC 0%, #0A57AD 70%);
            z-index: 9;
        }

      

        .update
        {
            position: absolute;
            border: solid 0px Red;
            margin: 0px;
            margin-left: 80%;
            margin-top: 0px;
            float: right;
            vertical-align: top;
            text-align: center;
            z-index: 9;
        }

        .timeMessage
        {
            border: solid 0px Red;
            display: inline-block;
            position: absolute;
            color: White;
            font-size: 10px;
            margin-top: 2px;
            margin-left: 8px;
            text-align: center;
            width: 90%;
        }
        .PanelFlotante
        {
            position: absolute;
            margin-left: 1%;
            margin-top: 100px;
            z-index: 9;
        }
        .DescargaExcel
        {
           background-color: rgba(198, 202, 201, 0.82);
          color: white;
          width: 60px;
          height: 30px;
          text-align: center;
          padding-top: 10px;
          display: table-cell;
          border-radius: 10px;
          overflow: hidden;
          vertical-align: middle;
          display: block;
          box-shadow: 4px 4px 4px rgba(126, 197, 118, 0.76);
          border-radius: 10em;
          background-color: #59C043;
          /*background: linear-gradient(180deg, #54804F 0%, #59AD20 70%);*/
          background: linear-gradient(180deg, rgba(84, 128, 79, 0) 0%, #538134 70%);
          margin-top: 20px;
          z-index: 9;
        }
         .linkDescarga
        {
          cursor: pointer;
          height: 50px;
          display: inline-block;
          width: 35px !important;
          background: url('../Recursos/ULD_Recursos/Image/Excel.png') no-repeat 2px -3px;
        }
        .linkUpdate
        {
          cursor: pointer;
          height: 50px;
          display: inline-block;
          width: 35px !important;
          background: url('../Recursos/ULD_Recursos/Image/update_32.png') no-repeat 2px -1px;
        }
        .linkClose
        {/*
            width: 25px;
            cursor: pointer;
            vertical-align: middle;
            height: 21px;
            opacity: 0.8;
            height: 18px;
            text-decoration: none;
            display: inline-block;
            width: 25px !important;
            background: url('../Recursos/Style/Reva/Recurse/trak-carga.png') no-repeat -3px -198px;
             */
            cursor: pointer;
            height: 50px;
            display: inline-block;
            width: 35px !important;
            background: url('../Recursos/ULD_Recursos/Image/home_32.png') no-repeat 2px -2px;
        }
    </style>
    <!-- BODY -->
    <link href="../Recursos/ULD_Recursos/Style/ULD.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
      
        <div id="Loading" class="Loading">
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <img src="../Recursos/ULD_Recursos/Image/loading.gif" />
            <br />
            Cargando...
            <br />
            <input type="button" value="Ocultar" onclick="Ocultar()" style="display: none" />
        </div>

        <div id="update" class="update">
            <div id="divTimeText" class="timeMessage">
                Se actualizara en..
            </div>
            <img src="../Recursos/ULD_Recursos/Image/AlertTime.png" />

        </div>
        <div class="PanelFlotante">
           
            <div class="DescargaExcel">
                <a id="a1" class="linkClose" href="../Page/frmManifiesto.aspx" title="Regresar al manifiestos">&nbsp;</a>
            </div>
            <div class="DescargaExcel">
                <a id="a2" class="linkUpdate" title="Actualizar Informacion" onclick="updateTablero();">&nbsp;</a>
            </div>
            <div class="DescargaExcel">
                <a id="a3" class="linkDescarga" title="Descargar inventario" onclick="GetDataExcel();">&nbsp;</a>
            </div>
        </div>
        
        <div id="Menssaje" class="mensaje" style="display: none">
            <div class="mensaje_div">
                <div style="border-bottom-style: solid; height: 25px; color: white; background-color: #00AA00; border-top-right-radius: 10px; border-top-left-radius: 10px; text-align: left; padding-left: 25px;">
                    Mensaje
                </div>
                <div class="Mesaje-texto">
                    <a data-mensaje>No Existen registros.</a>
                    <br />
                    <br />


                    <input type="button" value="Salir" onclick="Salir();"
                        style="background-color: white; border-radius: 10px; height: 35px; width: 150px; text-transform: uppercase; font-weight: bold; box-shadow: 4px 4px 4px rgba(143, 152, 141, 0.76); cursor: pointer" />
                </div>


            </div>

        </div>
        <div>

            <div class="header">
                <div class="header_back">
                    <div class="header_left">
                        <img src="../Recursos/ULD_Recursos/Image/Logo_TALMANET.png" alt="Logo" class="header_rigth-img" />
                    </div>
                    <div class="triangulo_top_left">
                    </div>
                    <div data-header class="header_rigth">
                        CONSULTA DE ULD's                   
                    </div>
                </div>
            </div>
            <div class="contenedor">
                <table style="width: 100%; border-spacing: 0px;">
                    <tr>
                        <td style="width: 48%">
                            <div class="panel_left">
                                <div class="panel_left--header_top">
                                    <div class="panel_left--header_top-title">
                                        Datos del Vuelo
                                    </div>
                                    <div class="panel_left--header_top-triangulo">
                                    </div>
                                </div>
                                <div class="panel_left--header">
                                    <div class="panel_left--header_body">
                                        <div data-mani="NU_VUEL" class="panel_left--header_body-vuelo">
                                        </div>
                                        <div class="panel_left--header_body-logo">

                                            <img data-mani="LG_LINEA" src="" height="30px" />
                                        </div>
                                        <div data-mani="ST_VUEL" class="panel_left--header_body-estado">
                                        </div>
                                    </div>

                                    <div class="panel_left--header_body-descrip">
                                        <div class="iv-body">
                                            <div class="iv-desc">
                                                <div class="iv-text">
                                                    F. Llegada :
                                                <label data-mani="FE_LLEG_VUEL" class="iv-text-label">
                                                </label>
                                                </div>
                                                <div class="iv-img">
                                                    <img src="../Recursos/ULD_Recursos/Image/salida.png" />

                                                </div>
                                                <div class="iv-text_img">
                                                    <div>
                                                        <div class="Origen">
                                                            Origen :
                                                        </div>
                                                        <div data-mani="DE_ORIG" class="Ciudad">
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="iv-spacing">
                                                &nbsp;
                                            </div>
                                            <div class="iv-desc">
                                                <div class="iv-text">
                                                    Manifiesto :
                                                <label data-mani="NU_MANI" class="iv-text-label">
                                                </label>
                                                </div>
                                                <div class="iv-img">
                                                    <img src="../Recursos/ULD_Recursos/Image/llegada.png" />
                                                </div>
                                                <div class="iv-text_img">
                                                    <div>
                                                        <div class="Origen">
                                                            Destino :
                                                        </div>
                                                        <div data-mani="DE_DEST" class="Ciudad">
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                </div>
                                <div class="panel_left--header_botton">
                                    <div style="width: 100%; height: 10px">
                                    </div>
                                    <div style="display: table; width: 100%;">
                                        <div class="iv-desc" style="width: 70px; padding: 0px !important; text-align: center;">
                                            0 %
                                        </div>
                                        <div class="iv-desc" style="width: auto; padding: 0px; text-align: center">
                                            <div class="baner">
                                                <div class="baner-select">
                                                </div>
                                                <a data-mani="PC_ESTI">Estimado 0%</a>

                                            </div>
                                        </div>

                                        <div class="iv-desc" style="width: 70px; padding: 0px !important; text-align: center;">
                                            100 %
                                        </div>
                                    </div>
                                    <div style="width: 100%; height: 5px;">
                                    </div>
                                    <div style="display: table; width: 100%;">
                                        <div data-mani="CT_ULDS_ACTU" style="display: table-cell; text-align: left; padding-left: 10px">
                                            Actual : 0 ULD's
                                        </div>
                                        <div data-mani="CT_ULDS_FINA" style="display: table-cell; text-align: right; padding-right: 10px">
                                            final : 0 ULD's
                                        </div>
                                    </div>
                                </div>
                                <div style="width: 100%; height: 30px"></div>
                                <div class="panel_left--body_top">
                                    <div class="panel_left--header_top">
                                        <div class="panel_left--header_top-title">
                                            Lista de ULD's pendientes
                                        </div>
                                        <div class="panel_left--header_top-triangulo">
                                        </div>
                                    </div>
                                    <div class="panel_left--header_botton uld_pendientes">
                                        <table data-listauld class="panel_rigth_arratre-body--tabla table_grid" id="Registros">
                                            <tr class="tr-gray">
                                                <td>Nro Uld
                                                </td>
                                                <td>Aero Mexio
                                                </td>
                                                <td>Observaciones
                                                </td>
                                            </tr>

                                            <template id="template--tr1">
                                                <tr class="tr-1">
                                                    <td data-uld>PGF09570R7
                                                    </td>
                                                    <td data-aero>-
                                                    </td>
                                                    <td data-obse>Ninguna
                                                    </td>
                                                </tr>
                                             </template>
                                            <template id="template--tr2">
                                              <tr class="tr-2">
                                                <td data-uld>PGF09570R7
                                                </td>
                                                <td data-aero>-
                                                </td>
                                                <td data-obse>Ninguna
                                                </td>
                                            </tr>
                                                  </template>

                                        </table>
                                    </div>
                                </div>
                                <div class="panel_left--body_botton">
                                </div>
                            </div>

                        </td>
                        <td style="width: 100PX">
                            <div style="width: 100PX">
                            </div>

                        </td>
                        <td style="width: 48%">
                            <div style="height: 30px; width: 100%">
                            </div>
                            <div class="panel_rigth" id="panel_rigth">
                                <div data-toogle style="width: 100%; height: 550px; overflow: auto;">
                                </div>
                            </div>

                        </td>
                    </tr>
                </table>








            </div>

        </div>


    </form>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>

    <script src="../Recursos/Script/Browser.js"></script>
    <script src="../Recursos/ULD_Recursos/Script/ULDS.js" type="text/javascript"></script>
    <script>
        function runEffect() {
            // get effect type from
            var selectedEffect = "blind";

            // most effect types need no options passed by default
            var options = {};

            // run the effect
            $("#effect").toggle(400);
        };
        function visibleControl(Control) {
            var _btn = $("#button_" + Control).attr('src');
            if (_btn == "../Recursos/ULD_Recursos/Image/Math_32.png")
                $("#button_" + Control).attr('src', '../Recursos/ULD_Recursos/Image/Minus_32.png');

            else
                $("#button_" + Control).attr('src', '../Recursos/ULD_Recursos/Image/Math_32.png');

            $("#effect_" + Control).toggle(400);
        }
        function runEffectID(id) {
            visibleControl(id);
            desacEffectFull(id)

        }
        function desacEffectFull(id) {
            var Panel = $('.effect');
            for (x = 0; x < Panel.length; x++) {
                if (x != id) {
                    var btnSecun = $("#button_" + x).attr('src');
                    if (btnSecun == "../Recursos/ULD_Recursos/Image/Minus_32.png")
                        visibleControl(x);
                }
            }
        }
        function Ocultar() {
            var Loading = $("#Loading");
            Loading.hide();
        }
        function Salir() {
            location.href = "../Page/frmManifiesto.aspx";
        }

    </script>
    <script src="../Recursos/ULD_Recursos/Script/DescargaExcel.js"></script>
</body>
</html>
