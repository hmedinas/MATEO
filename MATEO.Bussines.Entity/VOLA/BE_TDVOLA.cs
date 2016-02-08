using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace MATEO.Bussines.Entity.VOLA
{
    [DataContract]
    public class BE_TDVOLA
    {
        [DataMember]
        public String CO_EMPR { get; set; }
        [DataMember]
        public String CO_TERM { get; set; }
        [DataMember]
        public String NU_MANI { get; set; }
        [DataMember]
        public String NU_GUIA { get; set; }
        [DataMember]
        public String NU_VOLA { get; set; }
        [DataMember]
        public String TI_ALMA { get; set; }
        [DataMember]
        public String DE_ALMA { get; set; }
        [DataMember]
        public String NU_BULT_RECI { get; set; }
        [DataMember]
        public String NU_BULT_SALI{get;set;}
        [DataMember]
        public String NU_BULT_MALO { get; set; }
        [DataMember]
        public String KG_RECI { get; set; }
        [DataMember]
        public String KG_SALI { get; set; }
        [DataMember]
        public String KG_MALO { get; set; }
        [DataMember]
        public String CO_UBIC_0001 { get; set; }
        [DataMember]
        public String CO_UBIC_0002 { get; set; }

    }
}
