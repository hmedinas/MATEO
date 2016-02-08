var $body = $('body');
var _Header='<header class="header">'+
       '<section class="header_back">'+
            '<div class="header_left">'+
               '<img src="../../Recursos/Image/Logo.png" alt="Logo" class="header_rigth-img" />'+
           '</div>'+
           '<div class="triangulo_top_left">'+
'</div>' +
'<div data-title="HEADER" class="header_rigth">' +
    '' +
'</div>' +
'</section>' +
'</header>';
function SetHeaderTitle(titulo)
{
    var HEADER = $("[data-title='HEADER']");
    HEADER.text(titulo);
}

(function () {
    $body.append(_Header);
})();