/*
Agregando Controles Dinamicos para cargar la paguina 
*/
var $body = $('body');

(function () {
    var _StyleLoading = '<style>' +
                     '.af_document_splash-screen-message {' +
                         'font-family: Tahoma, Verdana, Helvetica, sans-serif;' +
                         'font-size: 14px;' +
                         'font-weight: bold;' +
                         'padding-left: 15px;' +
                         'color: #779EC7;' +
                     '}' +
                     '.af_document_splash-screen-content {' +
                         'display: table;' +
                         'margin-left: auto;' +
                         'margin-right: auto;' +
                         'white-space: nowrap;' +
                     '}' +
                     '.af_document_splash-screen-cell {' +
                         'display: table-cell;' +
                         'vertical-align: middle;' +
                         'text-align: center;' +
                     '}' +
                     '.af_document_splash-screen {' +
                         'display: table;' +
                         'position: fixed;' +
                         'top: 0px;' +
                         'left: 0px;' +
                         'width: 100%;' +
                         'height: 100%;' +
                         'background-color:  rgba(255, 255, 255, 0.96);;' +
                         'color: black;' +
                         'z-index: 3201;' +
                     '}' +
                     '</style>';
    $body.append(_StyleLoading);

    var _BodyLoading = '<div id="Loading_Page" class="af_document_splash-screen">' +
                           '<div class="af_document_splash-screen-cell">' +
                               '<span class="af_document_splash-screen-content">' +
                                   '<img src="../../Recursos/Mateo/Style/General/image/ss.gif" width="43" height="48" border="0" style="vertical-align:middle" alt="">' +
                                   '<span class="af_document_splash-screen-message">Loading...</span>' +
                               '</span>' +
                           '</div>' +
                       '</div>';


    $body.append(_BodyLoading);


})();


//Cargando
function ShowLoadingPage() {
    $("#Loading_Page").css("display", "table");
}
function HideLoadingPage() {
    var Loading = $("#Loading_Page");
    Loading.hide();
}