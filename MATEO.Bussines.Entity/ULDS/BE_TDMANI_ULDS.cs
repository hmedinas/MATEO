using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace MATEO.Bussines.Entity.ULDS
{
    [DataContract]
    public class BE_TDMANI_ULDS
    {
        [DataMember]
        public string CO_EMPR{get;set;}
        [DataMember]
        public string CO_TERM{get;set;}
        [DataMember]
        public string NU_MANI {get;set;}
        [DataMember]
        public string CO_GROU_ULD{get;set;}
        [DataMember]
        public string NU_SECU {get;set;}
        [DataMember]
        public string HO_ARRI {get;set;}
        [DataMember]
        public string CT_ULD {get;set;}
        [DataMember]
        public string NU_ULD {get;set;}
        [DataMember]
        public string NU_ARRA {get;set;}
        [DataMember]
        public string HO_AERO_AMEX {get;set;}
        [DataMember]
        public string NU_ULD_AMEX {get;set;}
        [DataMember]
        public string NU_GUIA_MAGA {get;set;}
        [DataMember]
        public string MT_CARR {get;set;}
        [DataMember]
        public string OP_CARR {get;set;}
        [DataMember]
        public string DE_OBSE_0001 {get;set;}
        [DataMember]
        public string DE_OBSE_0002 {get;set;}
        [DataMember]
        public string NU_PLACA {get;set;}
        [DataMember]
        public string NOM_TRANS {get;set;}
        [DataMember]
        public string ST_REGI {get;set;}
        [DataMember]
        public string CO_USER_CREA {get;set;}
        [DataMember]
        public string FE_USER_DATE {get;set;}
        [DataMember]
        public string CO_USER_MODI {get;set;}
        [DataMember]
        public string FE_USER_MODI { get; set; }


        [DataMember]
        public string ES_AERO { get; set; }
        [DataMember]
        public string CO_STAD_ULDS { get; set; }
        [DataMember]
        public string DE_STAD_ULDS { get; set; }
    }
}
