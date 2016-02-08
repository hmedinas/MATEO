
function ShowLoading()
{
    $("#Loading").css("display", "block");
}
function HideLoading()
{
    var Loading = $("#Loading");
    Loading.hide();
}
//Mensajes
function ShowMesaje(TipMessage,Message)
{
    if (TipMessage == "ERROR")
    {

    }
    if(TipMessage == "OK")
    {

    }
}
//redirect Page
function redirect(_URLPage)
{

    _URL_New = _URLPage;
    _URL_Back = location.href;
    location.href=_URLPage;
}
function redirect_Back()
{
    _URL_New = _URL_Back;
    _URL_Back = location.href;
    location.href = _URL_New;
}


/*===========================================================================*/
/*===========================================================================*/
/*=============                 FUNCIONES VARIAS               ==============*/
/*===========================================================================*/
/*===========================================================================*/



function CompletarIzq(Evalu, leng, Texto) {
    if (Evalu.length != 0) {
        var lPad = Evalu;
        if (Evalu.length == leng) {
            return Evalu;
        }
        if (Evalu.length < leng) {
            var i = Evalu.length;
            for (i; i < leng; i++) {
                lPad = Texto + lPad;
            }
            return lPad;
        }
    }

}
