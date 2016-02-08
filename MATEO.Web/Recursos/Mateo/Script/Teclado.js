var $body = $('body');

var _StyleKeyboard = '<style>' +
                      '.teclado-screen' +
                      '{' +
                      '    display: table;' +
                      '    position: fixed;' +
                      '    top: 0px;' +
                      '    left: 0px;' +
                      '    width: 100%;' +
                      '    height: 100%;' +
                      '    background-color: rgba(255, 255, 255, 0.96);' +
                      '    color: black;' +
                      '    z-index: 3201;' +
                      '}'+
                      '.teclado-screen-cell' +
                      '{' +
                      '    display: table-cell;' +
                      '    vertical-align: middle;' +
                      '    text-align: center;' +
                      '}'+
                      '.teclado-screen-content' +
                      '{' +
                      '    display: table;' +
                      '    margin-left: auto;' +
                      '    margin-right: auto;' +
                      '    white-space: nowrap;' +                   
                      '    border-style: solid;' +
                      '    border-color: silver;' +
                      '    border-width: 2px;' +
                      '    border-radius: 7px;' +
                      '    padding-top: 5px;' +
                      '    padding-bottom: 5px;' +
                      '    padding-left: 10px;' +
                      '    padding-right: 10px;' +
                      '    box-shadow: 7px 7px 7px rgba(126, 197, 118, 0.76);' +
                      '    border: 2px solid #033d7d;' +
                      '}' +
                      '.teclado-screen-number' +
                      '{' +
                      '    font-family: Tahoma, Verdana, Helvetica, sans-serif;' +
                      '    font-size: 14px;' +
                      '    font-weight: bold;' +
                      '    padding-left: 15px;' +
                      '    color: #779EC7;' +
                      '}' +
                      '.teclado-newRow' +
                      '{' +
                      '    margin-top: 5px;' +
                      '}' +
                      '.teclado-button' +
                      '{' +
                      '    font-family: monospace;' +
                      '    font-size: 30px;' +
                      '    background-color: #233271;' +
                      '    cursor: pointer;' +
                      '    border-color: red;' +
                      '    border: 0px;' +
                      '    border-radius: 9px;' +
                      '    width: 50px;' +
                      '    height: 50px;' +
                      '    color: white;' +
                      '    transition: all 0.2s ease-in-out;' +
                      '    box-shadow: 2px 2px 2px rgba(170, 171, 170, 0.76);' +
                      '    border-style: solid;' +
                      '    border-width: 1px;' +
                      '    margin: 3px;'+
                      '}' +
                      '.teclado-input' +
                      '{' +
                      '    background: linear-gradient(180deg, rgba(187, 185, 187,0.8) 0%, rgba(0, 0, 0,.5) 100%);' +
                      '    height: 50px;' +
                      '    border-radius: 7px;' +
                      '}' +
                      '	.teclado-input input' +
                      ' 	{' +
                      '        width: 99%;' +
                      '        height: 45px;' +
                      '        margin-top: 1px;' +
                      '        font-size: 2em !important;' +
                      '        text-align: center;' +
                      '        border-style: none;' +
                      '        border-radius: 7px;' +
                      '        background-color: rgba(255, 255, 255, 0.79);' +
                      '        text-transform: uppercase;' +
                      '    }' +
                      '.esc' +
                      '{' +
                      '    font-size: 25px;' +
                      '    background-color: #C8213A;' +
                      '    width: 50px;' +
                      '    height: 50px;' +
                      '    border-style: none;' +
                      '}' +
                      '.back' +
                      '{' +
                      '    background-color: #2CAB41;' +
                      '    width: 100px;' +
                      '    height: 50px;' +
                      '    transition: all 0.2s ease-in-out;' +
                      '    background-image: url("../../Recursos/Mateo/Style/Teclado/image/kb-keys.png") !important;' +
                      '    background-repeat: no-repeat !important;' +
                      '    background-position: center .4em !important;' +
                      '    border-style: none;' +
                      '}' +
                      '.enter' +
                      '{' +
                      '    background-color: #2CAB41;' +
                      '    width: 50px;' +
                      '    height: 100px;' +
                      '    font-size: 15px;' +
                      '    padding-top: 45px;' +
                      '    transition: all 0.2s ease-in-out;' +
                      '    background-image: url("../../Recursos/Mateo/Style/Teclado/image/kb-keys.png") !important;' +
                      '    background-repeat: no-repeat !important;' +
                      '    background-position: center -2.4em !important;' +
                      '    border-style: none;' +
                      '}' +
                      '.espac' +
                      '{' +
                      '    background-color: #2CAB41;' +
                      '    width: 210px;' +
                      '    height: 50px;' +
                      '    transition: all 0.2s ease-in-out;' +
                      '    background-image: url("../../Recursos/Mateo/Style/Teclado/image/kb-keys.png") !important;' +
                      '    background-repeat: no-repeat !important;' +
                      '    background-position: center -16.0em !important;' +
                      '    border-style: none;' +
                      '}' +
                      '.left' +
                      '{' +
                      '    background-color: #2CAB41;' +
                      '    width: 50px;' +
                      '    height: 50px;' +
                      '    transition: all 0.2s ease-in-out;' +
                      '    background-image: url("../../Recursos/Mateo/Style/Teclado/image/kb-keys.png") !important;' +
                      '    background-repeat: no-repeat !important;' +
                      '    background-position: center -4.0em !important;' +
                      '    border-style: none;' +
                      '}' +
                      '.rigth' +
                      '{' +
                      '    background-color: #2CAB41;' +
                      '    width: 50px;' +
                      '    height: 50px;' +
                      '    transition: all 0.2s ease-in-out;' +
                      '    background-image: url("../../Recursos/Mateo/Style/Teclado/image/kb-keys.png") !important;' +
                      '    background-repeat: no-repeat !important;' +
                      '    background-position: center -6.0em !important;' +
                      '    border-style: none;' +
                      '}'+
                      '</style>';

var _BodyKeyboard = '<div id="id_teclado_Email" class="teclado-screen" style="display: none">' +
                    '<div class="teclado-screen-cell">' +
                        '<div class="teclado-screen-content">' +
                            '<table>' +
                                '<tr>' +
                                    '<td>' +
                                        '<button class="teclado-button esc" onclick=" hideTecladoEmail();">Esc</button>' +
                                    '</td>' +
                                    '<td colspan="7">' +
                                        '<div class="teclado-input">' +
                                            '<input type="text" data-keyboard="TEXTO-EMAIL"/>' +
                                        '</div>' +
                                    '</td>' +
                                    '<td colspan="2">' +
                                        '<button class="teclado-button back" onclick="keyboardDeleteEmail()"></button>' +
                                    '</td>' +
                                '</tr>' +
                                '<tr>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">1</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">2</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">3</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">4</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">5</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">6</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">7</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">8</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">9</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">0</button>' +
                                    '</td>' +
                                '</tr>' +
                                '<tr>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">Q</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">W</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">E</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">R</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">T</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">Y</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">U</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">I</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">O</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">P</button>' +
                                    '</td>' +
                                '</tr>' +
                                '<tr>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">A</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">S</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">D</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">F</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">G</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">H</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">J</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">K</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">L</button>' +
                                    '</td>' +
                                    '<td rowspan="2">' +
                                        '<button class="teclado-button enter"  onclick="keyboardEnterEmail();" >Enter</button>' +
                                    '</td>' +
                                '</tr>' +
                                '<tr>' +
                                    '<td>' +
                                        '<button class="teclado-button left">@</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">Z</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">X</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">C</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">V</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">B</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">N</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyEmail(this);">M</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button rigth">.</button>' +
                                    '</td>' +
                                '</tr>' +
                            '</table>' +
                        '</div>' +
                    '</div>' +
                    '</div>' +
                    '<div id="id_teclado_Number" class="teclado-screen" style="display: none">' +
                     '<div class="teclado-screen-cell">' +
                         '<div class="teclado-screen-content">' +
                             '<table>' +
                                 '<tr>' +
                                     '<td colspan="4">' +
                                          '<div class="teclado-input" style="width:220px">' +
                                            '<input type="text" data-keyboard="TEXTO-NUMBER"/>' +
                                          '</div>' +
                                     '</td>' +
                                 '</tr>' +
                                 '<tr>' +
                                     '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyNumber(this);">7</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyNumber(this);">8</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyNumber(this);">9</button>' +
                                    '</td>' +
                                    '<td>' +
                                          '<button class="teclado-button esc" onclick="hideTecladoNumber();">Esc</button>' +
                                    '</td>' +
                                 '</tr>' +
                                 '<tr>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyNumber(this);">4</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyNumber(this);">5</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyNumber(this);">6</button>' +
                                    '</td>' +
                                    '<td>' +
                                          '<button class="teclado-button back" onclick="keyboardDeleteNumber()" style="width:50px"></button>' +
                                    '</td>' +
                                 '</tr>' +
                                 '<tr>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyNumber(this);">1</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyNumber(this);">2</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" onclick="keyboardKeyNumber(this);">3</button>' +
                                    '</td>' +
                                    '<td rowspan="2">' +
                                        '<button class="teclado-button enter"  onclick="keyboardEnterNumber();" >Enter</button>' +
                                    '</td>' +
                                 '</tr>' +
                                 '<tr>' +
                                    '<td colspan="2">' +
                                        '<button class="teclado-button" onclick="keyboardKeyNumber(this);" style="width:105px">0</button>' +
                                    '</td>' +
                                    '<td>' +
                                        '<button class="teclado-button" style="font-size: 25px;" onclick="keyboardKeyNumber(this);">CE</button>' +
                                    '</td>' +
                                 '</tr>' +
                             '</table>' +
                         '</div>' +
                     '</div>' +
                    '</div>';


(function () {

    $body.append(_StyleKeyboard);
    $body.append(_BodyKeyboard);
})();

function keyboardKeyEmail(key) {
    var TextTeclado = $("[data-keyboard='TEXTO-EMAIL']");
    var NewText = TextTeclado.val().toUpperCase() + key.innerHTML.toUpperCase()
    TextTeclado.val(NewText);
}
function keyboardEnterEmail() {
    var TextTeclado = $("[data-keyboard='TEXTO-EMAIL']");
    document.getElementById(keyboardControlCall).value = TextTeclado.val().toUpperCase();
    document.getElementById(keyboardControlCall).focus();
    hideTecladoEmail();
}
function keyboardDeleteEmail() {
    var TextTeclado = $("[data-keyboard='TEXTO-EMAIL']");
    TextTeclado.val(TextTeclado.val().substr(0, TextTeclado.val().length - 1))
}
/* TECLADO DE VOLANTE */
function keyboardKeyNumber(key) {
    var TextTeclado = $("[data-keyboard='TEXTO-NUMBER']");
    if (key.innerHTML.toUpperCase() == "CE") {
        TextTeclado.val("");
        return;
    }
    var NewText = TextTeclado.val().toUpperCase() + key.innerHTML.toUpperCase()
    TextTeclado.val(NewText);
}
function keyboardEnterNumber() {
    var TextTeclado = $("[data-keyboard='TEXTO-NUMBER']");
    document.getElementById(keyboardControlCall).value = TextTeclado.val().toUpperCase();
    document.getElementById(keyboardControlCall).focus();
    hideTecladoNumber();
}
function keyboardDeleteNumber() {
    var TextTeclado = $("[data-keyboard='TEXTO-NUMBER']");
    TextTeclado.val(TextTeclado.val().substr(0, TextTeclado.val().length - 1))
}
/*TECLADO ALFANIMERICO*/
function keyboardKeyAlfa(key) {
    var TextTeclado = $("[data-keyboard='TEXTO']");
    var NewText = TextTeclado.val().toUpperCase() + key.innerHTML.toUpperCase()
    TextTeclado.val(NewText);
}
function keyboardEnterAlfa() {
    var TextTeclado = $("[data-keyboard='TEXTO']");
    document.getElementById(keyboardControlCall).value = TextTeclado.val().toUpperCase();
    document.getElementById(keyboardControlCall).focus();
    hideTeclado();
}
function keyboardDeleteAlfa() {
    var TextTeclado = $("[data-keyboard='TEXTO']");
    TextTeclado.val(TextTeclado.val().substr(0, TextTeclado.val().length - 1))
}

function ShowTecladoEmail(ControlCall) {
    keyboardControlCall = ControlCall;
    var TextTeclado = $("[data-keyboard='TEXTO-EMAIL']");
    TextTeclado.val(document.getElementById(keyboardControlCall).value);
    $("#id_teclado_Email").css("display", "table");
}
function hideTecladoEmail() {
    var Loading = $("#id_teclado_Email");
    Loading.hide();
    document.getElementById(keyboardControlCall).focus();
}
/*          TECLADO NUMERICO              */
function ShowTecladoNumber(ControlCall) {
    keyboardControlCall = ControlCall;
    var TextTeclado = $("[data-keyboard='TEXTO-NUMBER']");
    TextTeclado.val(document.getElementById(keyboardControlCall).value);
    $("#id_teclado_Number").css("display", "table");
}
function hideTecladoNumber() {
    var Loading = $("#id_teclado_Number");
    Loading.hide();
    document.getElementById(keyboardControlCall).focus();
}

