using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MATEO.Bussines.Logic.TRAC;
using MATEO.Bussines.Entity.TRAC;
using System.ServiceModel.Activation;

namespace MATEO.Service.Wcf.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServTRAC" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServTRAC.svc o ServTRAC.svc.cs en el Explorador de soluciones e inicie la depuración.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class ServTRAC : MATEO.Service.Wcf.ServicesContract.IServTRAC
    {
        public void DoWork()
        {
        }

        public List<BE_TRACKING_CARGA> ListarTracking(string CO_EMPR, string CO_TERM, string TI_FILT, string FILVAL, string MANIINI)
        {
            List<BE_TRACKING_CARGA> _Result=new List<BE_TRACKING_CARGA>();
            try
            {
                string prmVal = string.Format("{0}{1}", FILVAL, MANIINI);
                if (string.IsNullOrEmpty(TI_FILT))
                    return new List<BE_TRACKING_CARGA>();
                  _Result= new BL_TRACK_CARGA().ListarTracking(CO_EMPR, CO_TERM, prmVal, prmVal, Convert.ToInt32(TI_FILT));
            }
            catch (Exception ex)
            {
                throw new Exception("ERR:SYS");               
            }
            return _Result;
        }
    }
}
