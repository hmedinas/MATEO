using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace MATEO.Bussines.Entity
{
    [DataContract]
    public class BE_RESULT
    {
        [DataMember]
        public Boolean ResultEje { get; set; }
         [DataMember]
        public Int32 Codigo { get; set; }
         [DataMember]
        public String Mensaje { get; set; }

        
    }
}
