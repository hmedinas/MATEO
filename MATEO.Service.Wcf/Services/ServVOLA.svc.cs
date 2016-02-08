using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using BE = MATEO.Bussines.Entity.VOLA;
using BL = MATEO.Bussines.Logic.VOLA;

namespace MATEO.Service.Wcf.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServVOLA" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServVOLA.svc o ServVOLA.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServVOLA : MATEO.Service.Wcf.ServicesContract.IServVOLA
    {

        public BE.BE_VOLA GetConsultGuia(string CO_EMPR, string CO_TERM, string TP_NEGO, string TP_FILT, string VL_FILT)
        {
            BE.BE_VOLA _Result = new BE.BE_VOLA();
            BL.BL_VOLA _Eject = new BL.BL_VOLA();
            _Result = _Eject.GetConsultGuia(CO_EMPR, CO_TERM, TP_NEGO, TP_FILT,  VL_FILT);
            return _Result;
        }
    }
}
