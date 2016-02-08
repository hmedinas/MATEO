using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace MATEO.Bussines.Entity.TRAC
{
    class BE_TRAC
    {
    }
    [DataContract]
    public class BE_TRACKING_LIST
    {
        [DataMember]
        public string NU_MANI { get; set; }
        [DataMember]
        public string FE_L_AL { get; set; }
        [DataMember]
        public string FE_L_VL { get; set; }
        [DataMember]
        public string NU_GUIA_MADR { get; set; }
        [DataMember]
        public string NU_GUIA { get; set; }
        [DataMember]
        public string G_KIL { get; set; }
        [DataMember]
        public string DE_ALMA { get; set; }
        [DataMember]
        public string NU_VOLA_MADR { get; set; }
        [DataMember]
        public string NU_VOLA { get; set; }
        [DataMember]
        public string ST_VOLA { get; set; }
        [DataMember]
        public string V_KIL { get; set; }
        [DataMember]
        public string NU_DOCU { get; set; }
        [DataMember]
        public string FE_DOCU { get; set; }
        [DataMember]
        public string TI_DOCU { get; set; }
        [DataMember]
        public string ST_SALI_FACT { get; set; }
        [DataMember]
        public decimal IM_EMIT { get; set; }
        [DataMember]
        public string NU_SALI { get; set; }
        [DataMember]
        public string FE_SALI { get; set; }
        [DataMember]
        public string ST_SALI { get; set; }
        
    }
    [DataContract]
    public class BE_TC_DATA
    {
        [DataMember]
        public string label { get; set; }
        [DataMember]
        public string text { get; set; }
        [DataMember]
        public bool hidden { get; set; }
    }
     [DataContract]
    public class BE_TC_PARAM
    {
         [DataMember]
        public string name { get; set; }
         [DataMember]
        public string value { get; set; }
    }
    [DataContract]
     public abstract class BE_TRACKING_CARGA
     {
          [DataMember]
         private List<BE_TRACKING_CARGA> _items;
          [DataMember]
         public abstract string typeName { get; }
          [DataMember]
         public bool allowButtons { get; set; }
          [DataMember]
         public List<BE_TC_DATA> data { get; set; }
          [DataMember]
         public string text { get; set; }
          [DataMember]
         public string value { get; set; }
          [DataMember]
         public string tag { get; set; }
          [DataMember]
         public List<BE_TRACKING_CARGA> items
         {
             get
             {
                 if (_items == null)
                     _items = new List<BE_TRACKING_CARGA>();
                 return _items;
             }
             set
             {
                 _items = value;
             }
         }
          [DataMember] 
        public bool collapsed { get; set; }
     }
    [DataContract]
     public class BE_TC_GENERIC : BE_TRACKING_CARGA
     {
          [DataMember]
         public override string typeName
         {
             get
             {
                 return "GENERICO";
             }
         }
     }

    [DataContract]
     public class BE_TC_MANIFIESTO : BE_TRACKING_CARGA
     {
          [DataMember]
         public override string typeName
         {
             get
             {
                 return "MANIFIESTO";
             }
         }


     }
    [DataContract]
     public class BE_TC_GUIA_MASTER : BE_TRACKING_CARGA
     {
          [DataMember]
         public override string typeName
         {
             get
             {
                 return "GUIA_MASTER";
             }
         }
     }
    [DataContract]
     public class BE_TC_GUIA_HOUSE : BE_TC_GUIA_MASTER
     {
         [DataMember]
         public override string typeName
         {
             get
             {
                 return "GUIA_HOUSE";
             }
         }
          [DataMember]
         public string rootValue { get; set; }
          [DataMember]
         public string parentValue { get; set; }
     }
    [DataContract]
     public class BE_TC_VOLANTE_MASTER : BE_TRACKING_CARGA
     {
         [DataMember]
         public override string typeName
         {
             get
             {
                 return "VOLANTE_MASTER";
             }
         }
     }
    [DataContract]
     public class BE_TC_VOLANTE_HIJA : BE_TC_VOLANTE_MASTER
     {
         [DataMember]
         public override string typeName
         {
             get
             {
                 return "VOLANTE_HIJA";
             }
         }
         [DataMember]
         public string rootValue { get; set; }
         [DataMember]
         public string parentValue { get; set; }
     }
    [DataContract]
     public class BE_TC_FACTURA : BE_TRACKING_CARGA
     {
         [DataMember]
         public override string typeName
         {
             get
             {
                 return "FACTURA";
             }
         }
     }
    [DataContract]
     public class BE_TC_SALIDAS : BE_TRACKING_CARGA
     {
         [DataMember]
         public override string typeName
         {
             get
             {
                 return "SALIDAS";
             }
         }
     }

}
