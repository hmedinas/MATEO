using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using BE = MATEO.Bussines.Entity.VOLA;

namespace MATEO.Service.Wcf.ServicesContract
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServVOLA" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServVOLA
    {
        [OperationContract]
        [WebGet(UriTemplate = "/GetConsultaGuia?CO_EMPR={CO_EMPR}&CO_TERM={CO_TERM}&TP_NEGO={TP_NEGO}&TP_FILT={TP_FILT}&VL_FILT={VL_FILT}",
             BodyStyle = WebMessageBodyStyle.Wrapped,
             RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json
           )]
        BE.BE_VOLA GetConsultGuia(string CO_EMPR, string CO_TERM, string TP_NEGO, string TP_FILT, string VL_FILT);



    }
}
