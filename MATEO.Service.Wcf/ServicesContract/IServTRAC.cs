using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using MATEO.Bussines.Logic.TRAC;
using MATEO.Bussines.Entity.TRAC;
using System.Web.Script.Services;

namespace MATEO.Service.Wcf.ServicesContract
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServTRAC" en el código y en el archivo de configuración a la vez.
    [ServiceContract]    
    public interface IServTRAC
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
         [WebGet(UriTemplate = "/ListarTracking?CO_EMPR={CO_EMPR}&CO_TERM={CO_TERM}&TI_FILT={TI_FILT}&FILVAL={FILVAL}&MANIINI={MANIINI}",
              BodyStyle = WebMessageBodyStyle.WrappedRequest,
              RequestFormat = WebMessageFormat.Json,
              ResponseFormat = WebMessageFormat.Json
            )]
        [ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        List<BE_TRACKING_CARGA> ListarTracking(string CO_EMPR, string CO_TERM, string TI_FILT, string FILVAL, string MANIINI);
     
    }
}
