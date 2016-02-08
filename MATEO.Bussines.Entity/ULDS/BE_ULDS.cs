using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace MATEO.Bussines.Entity.ULDS
{
    [DataContract]
    public class BE_ULDS
    {
        [DataMember]
        public string CO_EMPR;
        [DataMember]
        public string CO_TERM;
        [DataMember]
        public string NU_MANI;
        [DataMember]
        public string TI_ENTI_LINE;
        [DataMember]
        public string CO_ENTI_LINE;
        [DataMember]
        public string DE_ENTI_LINE;
        [DataMember]
        public string LG_ENTI_LINE;
        [DataMember]
        public string NU_VUEL;
        [DataMember]
        public string FE_LLEG_VUEL;
        [DataMember]
        public string FE_LLEG_ALMA;
        [DataMember]
        public string CO_CIUD_ORIG;
        [DataMember]
        public string DE_CIUD_ORIG;
        [DataMember]
        public string CO_CIUD_DEST;
        [DataMember]
        public string DE_CIUD_DEST;
        [DataMember]
        public string PC_ESTI_ULDS;
        [DataMember]
        public string CT_ACTU_ULDS;
        [DataMember]
        public string CT_TOTA_ULDS;
        [DataMember]
        public string DE_DESC_ULDS;



        [DataMember]
        public List<BE_TCMANI_ULDS> lstBE_TCMANI_ULDS { get; set; }
        [DataMember]
        public List<BE_TCMANI_ULDS_TEMP> lstBE_TCMANI_ULDS_TEMP { get; set; }
        [DataMember]
        public List<BE_TDMANI_ULDS> lstBE_TDMANI_ULDS { get; set; }
    }
}
