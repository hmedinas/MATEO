using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace MATEO.Bussines.Entity.VOLA
{
    [DataContract]
    public class BE_VOLA
    {
        [DataMember]
        public List<BE_TDVOLA> lstCabVolante { get; set; }
        [DataMember]
        public List<BE_TDVOLA> lstDetVolante { get; set; }
        [DataMember]
        public List<BE_TDVOLA_UBIC> lstUbicVolante { get; set; }
        [DataMember]
        public List<BE_TCVOLA_REPO> lstVolanteReport { get; set; }
        [DataMember]
        public BE_RESULT Result { get; set; }
    }
}
