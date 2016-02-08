//Variables de navegacion 
var _URL_New;
var _URL_Back;
//variables de almcen
var _CO_EMPR;
var _CO_TERM='0001';
//datos de usuario
var _ID_USUA;
var _DE_USUA;

var HostService="http://192.168.102.241/SERVICE/srvMATEO/Services/";

var ConsultaGuia = HostService+ServVOLA + "";
var ConsultaRevalidacion = HostService + ServREVA + "";

var ServVOLA = "ServVOLA.svc/";//consulta de GUIAS y VOlante
var ServREVA = "ServULDS.svc/";//Consultas de REVALIDACION
var ServSIMU = "ServSIMU.svc/";//Consulta la simulaicon 
var ServEMAIL = "ServEmail.svc/";// envio de correo y adjuntos
