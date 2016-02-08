using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace MATEO.Bussines.Entity.ULDS
{
    [DataContract]
    public class BE_TCMANI_ULDS
    {
        [DataMember]
        public string CO_EMPR { get; set; }
        [DataMember]
        public string CO_TERM { get; set; }
        [DataMember]
        public string NU_MANI { get; set; }
        [DataMember]
        public string CO_GROUP_ULD { get; set; }
        [DataMember]
        public string NO_REPR_LINE { get; set; }
        [DataMember]
        public string HO_PROG_ARRI { get; set; }
        [DataMember]
        public string HO_ARRI_POSI { get; set; }
        [DataMember]
        public string HO_INIC_DESC { get; set; }
        [DataMember]
        public string HO_FIN_DESC { get; set; }
        [DataMember]
        public string HO_LLEG_PRIM_PALL { get; set; }
        [DataMember]
        public string HO_LLEG_ULTI_PALL { get; set; }
        [DataMember]
        public string HO_INIC_DES_PALL { get; set; }
        [DataMember]
        public string HO_FIN_DES_PALL { get; set; }
        [DataMember]
        public string HO_INIC_CONF { get; set; }
        [DataMember]
        public string HO_FIN_CONF { get; set; }
        [DataMember]
        public string TI_MAXI_ATEN { get; set; }
        [DataMember]
        public string TI_EMPL_REAL { get; set; }
        [DataMember]
        public string RE_MANI_BLAN { get; set; }
        [DataMember]
        public string HO_FIN_CAPT { get; set; }
        [DataMember]
        public string DE_RESP_CAPT { get; set; }
        [DataMember]
        public string DE_OBSE_0001 { get; set; }
        [DataMember]
        public string NO_TRAB { get; set; }
        [DataMember]
        public string NO_SUPE_COOR { get; set; }
        [DataMember]
        public string NO_JEFE_ALMA { get; set; }
        [DataMember]
        public string ST_REGI { get; set; }
        [DataMember]
        public string CO_USER_CREA { get; set; }
        [DataMember]
        public DateTime FE_USER_DATE { get; set; }
        [DataMember]
        public string CO_USER_MODI { get; set; }
        [DataMember]
        public DateTime FE_USER_MODI { get; set; }

    }
}
