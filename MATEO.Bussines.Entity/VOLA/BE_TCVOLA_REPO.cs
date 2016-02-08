using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace MATEO.Bussines.Entity.VOLA
{
    [DataContract]
    public class BE_TCVOLA_REPO
    {
        [DataMember]
        public String CO_EMPR{get;set;}
        [DataMember]
        public String CO_TERM{get;set;}
        [DataMember]
        public String NU_MANI{get;set;}
        [DataMember]
        public String NU_VUEL{get;set;}
        [DataMember]
        public String CO_ENTI_LINE{get;set;}
        [DataMember]
        public String CO_CIUD_ORIG{get;set;}
        [DataMember]
        public String CO_CIUD_DEST{get;set;}
        [DataMember]
        public String NU_GUIA_MADR{get;set;}
        [DataMember]
        public String NU_GUIA{get;set;}
        [DataMember]
        public String CO_ENTI_AGRE{get;set;}
        [DataMember]
        public String DE_ENTI_AGRE{get;set;}
        [DataMember]
        public String CO_ENTI_AGEM{get;set;}
        [DataMember]
        public String DE_ENTI_AGEM{get;set;}
        [DataMember]
        public String NU_BULT_RECI{get;set;}
        [DataMember]
        public String KG_RECI{get;set;}
        [DataMember]
        public String CO_ENTI_CONS{get;set;}
        [DataMember]
        public String NO_CONS{get;set;}
        [DataMember]
        public String DE_CARG_0001{get;set;}
        [DataMember]
        public String TI_INGR{get;set;}
        [DataMember]
        public String DE_TIPO_INGR{get;set;}
        [DataMember]
        public String NU_VOLA{get;set;}
        [DataMember]
        public String NU_VOLA_MADR{get;set;}
        [DataMember]
        public String ST_INVE{get;set;}
        [DataMember]
        public String ST_VOLA{get;set;}
        [DataMember]
        public String NU_BULT_VOLA{get;set;}
        [DataMember]
        public String KG_RECI_VOLA{get;set;}
        [DataMember]
        public String ST_TRAN{get;set;}
        [DataMember]
        public String DE_ORIG_CARG{get;set;}
        [DataMember]
        public String DE_DEST_CARG{get;set;}
            

        [DataMember]
        public BE_RESULT Result { get; set; }
    }
}
