using System;
using System.Runtime.Serialization;

namespace MATEO.Bussines.Entity.REVA
{
    [DataContract]
    public class BE_REVA
    {
        [DataMember]
        public string CO_EMPR { get; set; }
        [DataMember]
        public string CO_TERM { get; set; }
        [DataMember]
        public string NU_REVA { get; set; }
        [DataMember]
        public string NU_MANI { get; set; }
        [DataMember]
        public string NU_GUIA { get; set; }
        [DataMember]
        public string NU_GUIA_MADR { get; set; }
        [DataMember]
        public string NU_BULT { get; set; }// NUMBER(10),
        [DataMember]
        public string KG_RECI { get; set; }// NUMBER(10,2),
        [DataMember]
        public string DE_CARG { get; set; }// VARCHAR2(500 BYTE),
        [DataMember]
        public string EX_DATE { get; set; }// DATE,
        [DataMember]
        public string SP_DATE { get; set; }// DATE,
        [DataMember]
        public string IM_DATE { get; set; }// DATE,
        [DataMember]
        public string AS_DATE { get; set; }// DATE,
        [DataMember]
        public string IM_VFOB { get; set; }// NUMBER(12,2),
        [DataMember]
        public string TI_MONE_VFOB { get; set; }// VARCHAR2(50 BYTE),
        [DataMember]
        public string BL_TERM_0001 { get; set; }// VARCHAR2(50 BYTE),
        [DataMember]
        public string NU_GUIA_UPS { get; set; }// VARCHAR2(50 BYTE),
        [DataMember]
        public string DE_GUIA_UPS { get; set; }// VARCHAR2(4000 BYTE),
        [DataMember]
        public string DE_GUIA_UPS_02 { get; set; }// VARCHAR2(4000 BYTE),
        [DataMember]
        public string ID_UPS { get; set; }// VARCHAR2(500 BYTE),
        [DataMember]
        public string BL_TERM_0002 { get; set; }// VARCHAR2(50 BYTE),
        [DataMember]
        public string NO_AGEN_REVA { get; set; }// VARCHAR2(50 BYTE),
        [DataMember]
        public string DE_REMI { get; set; }// VARCHAR2(500 BYTE),
        [DataMember]
        public string DI_REMI_0001 { get; set; }// VARCHAR2(500 BYTE),
        [DataMember]
        public string DI_REMI_0002 { get; set; }// VARCHAR2(500 BYTE),
        [DataMember]
        public string DI_REMI_0003 { get; set; }// VARCHAR2(500 BYTE),
        [DataMember]
        public string DI_REMI_0004 { get; set; }// VARCHAR2(500 BYTE),
        [DataMember]
        public string DI_REMI_0005 { get; set; }// VARCHAR2(500 BYTE),
        [DataMember]
        public string DI_REMI_0006 { get; set; }// VARCHAR2(500 BYTE),
        [DataMember]
        public string DI_REMI_0007 { get; set; }// VARCHAR2(500 BYTE),
        [DataMember]
        public string DI_REMI_0008 { get; set; }// VARCHAR2(500 BYTE),
        [DataMember]
        public string DI_REMI_0009 { get; set; }// VARCHAR2(500 BYTE),
        [DataMember]
        public string NU_TELF_REMI { get; set; }// VARCHAR2(50 BYTE),
        [DataMember]
        public string DE_CONS { get; set; }// VARCHAR2(500 BYTE),
        [DataMember]
        public string DI_CONS_0001 { get; set; }// VARCHAR2(500 BYTE),
        [DataMember]
        public string DI_CONS_0002 { get; set; }// VARCHAR2(500 BYTE),
        [DataMember]
        public string DI_CONS_0003 { get; set; }// VARCHAR2(500 BYTE),
        [DataMember]
        public string DI_CONS_0004 { get; set; }// VARCHAR2(500 BYTE),
        [DataMember]
        public string DI_CONS_0005 { get; set; }// VARCHAR2(500 BYTE),
        [DataMember]
        public string DI_CONS_0006 { get; set; }// VARCHAR2(500 BYTE),
        [DataMember]
        public string DI_CONS_0007 { get; set; }// VARCHAR2(500 BYTE),
        [DataMember]
        public string DI_CONS_0008 { get; set; }// VARCHAR2(500 BYTE),
        [DataMember]
        public string DI_CONS_0009 { get; set; }// VARCHAR2(500 BYTE),
        [DataMember]
        public string NU_TELF_CONS { get; set; }// VARCHAR2(50 BYTE),
        [DataMember]
        public string IN_NAME_ARCH { get; set; }// VARCHAR2(500 BYTE),
        [DataMember]
        public string ST_REVA { get; set; }// VARCHAR2(50 BYTE),
        [DataMember]
        public string ST_IMPR { get; set; }// VARCHAR2(50 BYTE),
        [DataMember]
        public string CO_USER_IMPR { get; set; }// VARCHAR2(100 BYTE),
        [DataMember]
        public string FE_USER_IMPR { get; set; }// DATE,
        [DataMember]
        public string ST_FACT { get; set; }// VARCHAR2(50 BYTE),
        [DataMember]
        public string CO_USER_FACT { get; set; }// VARCHAR2(100 BYTE),
        [DataMember]
        public string FE_USER_FACT { get; set; }// DATE,
        [DataMember]
        public string TI_DOCU_FACT { get; set; }// VARCHAR2(50 BYTE),
        [DataMember]
        public string NU_DOCU_FACT { get; set; }// VARCHAR2(50 BYTE),
        [DataMember]
        public string FE_DOCU_FACT { get; set; }// VARCHAR2(50 BYTE),
        [DataMember]
        public string ST_ALMA { get; set; }// VARCHAR2(50 BYTE),
        [DataMember]
        public string CO_USER_ALMA { get; set; }// VARCHAR2(100 BYTE),
        [DataMember]
        public string FE_USER_ALMA { get; set; }// DATE,
        [DataMember]
        public string ST_REGI { get; set; }// VARCHAR2(50 BYTE),
        [DataMember]
        public string CO_USER_CREA { get; set; }// VARCHAR2(50 BYTE),
        [DataMember]
        public string FE_USER_CREA { get; set; }// DATE,
        [DataMember]
        public string CO_USER_MODI { get; set; }// VARCHAR2(50 BYTE),
        [DataMember]
        public string FE_USER_MODI { get; set; }// DATE
        [DataMember]
        public string FE_CARG { get; set; }
        [DataMember]
        public string ST_REGIS { get; set; }
        [DataMember]
        public string FE_RECEP { get; set; }
        [DataMember]
        public string DE_RECEP { get; set; }
        [DataMember]
        public string FE_REVAL { get; set; }
        [DataMember]
        public string DE_REVAL { get; set; }
        [DataMember]
        public string FE_FACTU { get; set; }
        [DataMember]
        public string DE_FACTU { get; set; }
        [DataMember]
        public string FE_ALMAC { get; set; }
        [DataMember]
        public string DE_ALMAC { get; set; }
        [DataMember]
        public decimal TP_CAMB { get; set; } 

    }
}
