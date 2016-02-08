using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace MATEO.Bussines.Entity.VOLA
{
    [DataContract]
    public class BE_TDVOLA_UBIC
    {
        [DataMember]
        public String CO_EMPR{get;set;}
        [DataMember]
        public String CO_TERM{get;set;}
        [DataMember]
        public String NU_MANI{get;set;}
        [DataMember]
        public String NU_GUIA{get;set;}
        [DataMember]
        public String NU_VOLA{get;set;}
        [DataMember]
        public String TI_ALMA { get; set; }
        [DataMember]
        public Int32 NU_SECU { get; set; }
        [DataMember]
        public String NU_BULT_RECI { get; set; }
        [DataMember]
        public String KG_RECI { get; set; }
        [DataMember]
        public String CO_UBIC_0001 { get; set; }
        [DataMember]
        public String CO_USUA_MODI { get; set; }
        [DataMember]
        public String FE_USUA_MODI { get; set; }
        [DataMember]
        public String CO_UBIC_H001 { get; set; }
        [DataMember]
        public String CO_USUA_H001 { get; set; }
        [DataMember]
        public String FE_USUA_H001 { get; set; }
        [DataMember]
        public String CK_RETO { get; set; }
        [DataMember]
        public String ST_EMBA { get; set; }
        [DataMember]
        public String CO_HIR { get; set; }
        [DataMember]
        public String CO_PARIH { get; set; }
        [DataMember]
        public String FE_EMIS { get; set; }



    }
}
