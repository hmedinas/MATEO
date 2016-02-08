using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using BE = MATEO.Bussines.Entity.ULDS;




namespace MATEO.Service.Wcf.ServicesContract
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServULDS" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServULDS
    {
      
        [OperationContract]
        [WebGet(UriTemplate = "/GetTableULD?CO_EMPR={strCO_EMPR}&CO_TERM={strCO_TERM}&NU_MANI={strNU_MANI}",
             BodyStyle = WebMessageBodyStyle.Wrapped,
             RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json
           )]
        BE.BE_ULDS GetTableULD(string strCO_EMPR, string strCO_TERM, string strNU_MANI);

        [OperationContract]
        [WebGet(UriTemplate = "/GetInventarioULDS?CO_EMPR={strCO_EMPR}&CO_TERM={strCO_TERM}&CO_ENTI_LINE={strCO_ENTI_LINE}",
             BodyStyle = WebMessageBodyStyle.Wrapped,
             RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json
           )]
        List<BE.BE_ULDS_EXCE> GetInventarioULDS(string strCO_EMPR, string strCO_TERM, string strCO_ENTI_LINE);

    }
}
