using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace MATEO.Bussines.Entity.ULDS
{
    [DataContract]
    public class BE_TCMANI_ULDS_TEMP
    {
        [DataMember]
        public string CO_EMPR{get;set;}
        [DataMember]
        public string CO_TERM{get;set;}
        [DataMember]
        public string NU_MANI {get;set;}
        [DataMember]
        public string CO_LINE{get;set;}
        [DataMember]
        public Int32 CAN_ULDS{get;set;}
        [DataMember]
        public String NU_ULD  {get;set;}
        [DataMember]
        public String NU_ULD_AMEX {get;set;}
        [DataMember]
        public String DE_OBSE {get;set;}

    }
}
