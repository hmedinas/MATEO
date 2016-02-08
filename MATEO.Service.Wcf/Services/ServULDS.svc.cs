using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;
using BE=MATEO.Bussines.Entity.ULDS;
using BL=MATEO.Bussines.Logic.ULDS;
 

namespace MATEO.Service.Wcf.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServULDS" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServULDS.svc o ServULDS.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServULDS : MATEO.Service.Wcf.ServicesContract.IServULDS
    {
     
        public BE.BE_ULDS GetTableULD(string strCO_EMPR, string strCO_TERM, string strNU_MANI)
        {
            BE.BE_ULDS _Result=new BE.BE_ULDS();
            BL.BL_ULDS _Eject = new BL.BL_ULDS();
            _Result= _Eject.GetTableULD(strCO_EMPR,strCO_TERM,strNU_MANI);
            return _Result;
        }
        public List<BE.BE_ULDS_EXCE> GetInventarioULDS(string strCO_EMPR, string strCO_TERM, string strCO_ENTI_LINE)
        {
            List<BE.BE_ULDS_EXCE> _Result = new List<BE.BE_ULDS_EXCE>();
            BL.BL_ULDS _Eject = new BL.BL_ULDS();
            _Result = _Eject.GetInventarioULDS(strCO_EMPR, strCO_TERM, strCO_ENTI_LINE);
            return _Result;
        }
    }
}
