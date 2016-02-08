using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace MATEO.Bussines.Entity.ULDS
{
   [DataContract]
    public  class BE_ULDS_EXCE
    {
        [DataMember]
        public string CO_EMPR { get; set; }
        [DataMember]
        public string CO_TERM { get; set; }
        [DataMember]
        public string NU_MANI { get; set; }
        [DataMember]
        public string TI_ENTI_LINE { get; set; }
        [DataMember]
        public string CO_ENTI_LINE {get;set;}
        [DataMember]
        public string DE_ENTI_LINE {get;set;}
        [DataMember]
        public string NU_VUEL {get;set;}
        [DataMember]
        public string FE_LLEG_VUEL {get;set;}
        [DataMember]
        public string FE_LLEG_ALMA {get;set;}
        [DataMember]
        public string NU_ULD {get;set;}
        [DataMember]
        public string ST_ULDS {get;set;}
        [DataMember]
        public string NU_GUIA_MAGA { get; set; }
        [DataMember]
        public string DE_OBSE_0001 { get; set; }
        [DataMember]
        public string DE_OBSE_0002{get;set;}
        [DataMember]
        public string ES_AERO { get; set; }


    }
}
