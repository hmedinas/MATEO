using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace MATEO.Bussines.Entity.VOLA
{
    [DataContract]
    public class BE_TCVOLA
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
        public String NU_VOLA_MADR{get;set;}
        [DataMember]
        public String FE_EMIS{get;set;}
        [DataMember]
        public String TI_ENTI_AGAD{get;set;}
        [DataMember]
        public String CO_ENTI_AGAD{get;set;}
        [DataMember]
        public String DE_ENTI_AGAD { get; set; }
        [DataMember]
        public String NU_POLI{get;set;}
        [DataMember]
        public String DE_CARG_0001{get;set;}
        [DataMember]
        public String DE_CARG_0002{get;set;}
        [DataMember]
        public String DE_OBSE_0001{get;set;}
        [DataMember]
        public String DE_OBSE_0002{get;set;}
        [DataMember]
        public String ST_VOLA{get;set;}
        [DataMember]
        public String FE_STAT_VOLA{get;set;}
        [DataMember]
        public String ST_INVE {get;set;}
        [DataMember]
        public String TI_SALI{get;set;}
        [DataMember]
        public String FE_SALI{get;set;}
        [DataMember]
        public String HO_SALI{get;set;}
        [DataMember]
        public String CO_REGI{get;set;}
        [DataMember]
        public String TI_SALI_ADUA{get;set;}
        [DataMember]
        public String DE_SALI_ADUA { get; set; }
        [DataMember]
        public String SAL_ABAN{get;set;}
        [DataMember]
        public String FE_ABAN{get;set;}

        [DataMember]
        public List<BE_TDVOLA> lstDetVolante{get;set;}
        [DataMember]
        public List<BE_TDVOLA_UBIC> lstUbicVolante { get; set; }
        [DataMember]
        public List<BE_TCVOLA_REPO> lstVolanteReport { get; set; }
         [DataMember]

        public BE_RESULT Result { get; set; }




    }
}
