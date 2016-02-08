using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using DataBase_Oracle;
using BE = MATEO.Bussines.Entity.ULDS;


namespace MATEO.Data.Access.ULDS
{
    public class DA_ULDS:Instance.ConnectionManager
    {
        private static Database db_BaseDatos;
        public DA_ULDS()
        {
            db_BaseDatos = new Database(ConexionDataBase);
        }
        /// <summary>
        /// Muestra la información que se mostrara en el tablero del talmanet
        /// </summary>
        /// <param name="CO_EMPR">Código de empresa</param>
        /// <param name="CO_TERM">Código de terminal</param>
        /// <param name="NU_MANI">Numero de manifiesto</param>
        /// <returns>Retorna una lista con con la informacino del Tablero</returns>
        public BE.BE_ULDS GetTableULD(string CO_EMPR, string CO_TERM, string NU_MANI)
        {
            BE.BE_ULDS _Result = new BE.BE_ULDS();
            
            try
            {
                db_BaseDatos.LimpiarComandos();
                db_BaseDatos.AddParameterIn("ICO_EMPR",Database.ExpectedType.String,CO_EMPR);
                db_BaseDatos.AddParameterIn("ICO_TERM",Database.ExpectedType.String,CO_TERM);
                db_BaseDatos.AddParameterIn("INU_MANI",Database.ExpectedType.String,NU_MANI);

                db_BaseDatos.AddParameterOut("VCURSOR1", Database.ExpectedType.Cursor);
                db_BaseDatos.AddParameterOut("VCURSOR2", Database.ExpectedType.Cursor);
                db_BaseDatos.AddParameterOut("VCURSOR3", Database.ExpectedType.Cursor);

                IDataReader _Reader;
                BE.BE_TCMANI_ULDS objTCMANI_ULDS=null;
                BE.BE_TDMANI_ULDS objTDMANI_ULDS=null;
                BE.BE_TCMANI_ULDS_TEMP objTCMANI_ULDS_TEMP=null;

                List<BE.BE_TCMANI_ULDS> lstTCMANI_ULDS=new List<BE.BE_TCMANI_ULDS>();
                List<BE.BE_TDMANI_ULDS> lstTDMANI_ULDS=new List<BE.BE_TDMANI_ULDS>();
                List<BE.BE_TCMANI_ULDS_TEMP> lstTCMANI_ULDS_TEMP=new List<BE.BE_TCMANI_ULDS_TEMP>();

                using (_Reader = db_BaseDatos.ExecuteReaderByCommand("TLMEXTR.PKG_ULDS.UPS_GET_ULDS_TABLERO"))
                {
                    

                    int COL0=_Reader.GetOrdinal("CO_EMPR");
                    int COL1=_Reader.GetOrdinal("CO_TERM");
                    int COL2=_Reader.GetOrdinal("NU_MANI");
                    int COL3=_Reader.GetOrdinal("TI_ENTI_LINE");
                    int COL4=_Reader.GetOrdinal("CO_ENTI_LINE");
                    int COL5=_Reader.GetOrdinal("DE_ENTI_LINE");
                    int COL6=_Reader.GetOrdinal("LG_ENTI_LINE");
                    int COL7=_Reader.GetOrdinal("NU_VUEL");
                    int COL8=_Reader.GetOrdinal("FE_LLEG_VUEL");
                    int COL9=_Reader.GetOrdinal("FE_LLEG_ALMA");
                    int COL10=_Reader.GetOrdinal("CO_CIUD_ORIG");
                    int COL11=_Reader.GetOrdinal("DE_CIUD_ORIG");
                    int COL12=_Reader.GetOrdinal("CO_CIUD_DEST");
                    int COL13=_Reader.GetOrdinal("DE_CIUD_DEST");
                    int COL14=_Reader.GetOrdinal("PC_ESTI_ULDS");
                    int COL15=_Reader.GetOrdinal("CT_ACTU_ULDS");
                    int COL16=_Reader.GetOrdinal("CT_TOTA_ULDS");
                    int COL17=_Reader.GetOrdinal("DE_DESC_ULDS");
                    //Cursor 1
                    while(_Reader.Read())
                    {
                        _Result.CO_EMPR = _Reader.IsDBNull(COL0) ? string.Empty : _Reader.GetString(COL0);
                        _Result.CO_TERM = _Reader.IsDBNull(COL1) ? string.Empty : _Reader.GetString(COL1);
                        _Result.NU_MANI = _Reader.IsDBNull(COL2) ? string.Empty : _Reader.GetString(COL2);
                        _Result.TI_ENTI_LINE = _Reader.IsDBNull(COL3) ? string.Empty : _Reader.GetString(COL3);
                        _Result.CO_ENTI_LINE = _Reader.IsDBNull(COL4) ? string.Empty : _Reader.GetString(COL4);
                        _Result.DE_ENTI_LINE = _Reader.IsDBNull(COL5) ? string.Empty : _Reader.GetString(COL5);
                        _Result.LG_ENTI_LINE = _Reader.IsDBNull(COL6) ? string.Empty : _Reader.GetString(COL6);
                        _Result.NU_VUEL = _Reader.IsDBNull(COL7) ? string.Empty : _Reader.GetString(COL7);
                        _Result.FE_LLEG_VUEL = _Reader.IsDBNull(COL8) ? string.Empty : _Reader.GetString(COL8);
                        _Result.FE_LLEG_ALMA = _Reader.IsDBNull(COL9) ? string.Empty : _Reader.GetString(COL9);
                        _Result.CO_CIUD_ORIG = _Reader.IsDBNull(COL10) ? string.Empty : _Reader.GetString(COL10);
                        _Result.DE_CIUD_ORIG = _Reader.IsDBNull(COL11) ? string.Empty : _Reader.GetString(COL11);
                        _Result.CO_CIUD_DEST = _Reader.IsDBNull(COL12) ? string.Empty : _Reader.GetString(COL12);
                        _Result.DE_CIUD_DEST = _Reader.IsDBNull(COL13) ? string.Empty : _Reader.GetString(COL13);
                        _Result.PC_ESTI_ULDS = _Reader.IsDBNull(COL14) ? string.Empty : _Reader.GetString(COL14);
                        _Result.CT_ACTU_ULDS = _Reader.IsDBNull(COL15) ? string.Empty : _Reader.GetString(COL15);
                        _Result.CT_TOTA_ULDS = _Reader.IsDBNull(COL16) ? string.Empty : _Reader.GetString(COL16);
                        _Result.DE_DESC_ULDS = _Reader.IsDBNull(COL17) ? string.Empty : _Reader.GetString(COL17);
                    }
                    //Cursor 2
                    _Reader.NextResult();
                    COL0 = _Reader.GetOrdinal("CO_EMPR");
                    COL1 = _Reader.GetOrdinal("CO_TERM");
                    COL2 = _Reader.GetOrdinal("NU_MANI");
                    COL3 = _Reader.GetOrdinal("NU_ULD");
                    COL4 = _Reader.GetOrdinal("NU_ULD_AMEX");
                    COL5 = _Reader.GetOrdinal("DE_OBSE");

                    _Result.lstBE_TCMANI_ULDS_TEMP = new List<BE.BE_TCMANI_ULDS_TEMP>();
                    while(_Reader.Read())
                    {

                        objTCMANI_ULDS_TEMP=new BE.BE_TCMANI_ULDS_TEMP();
                        
                        objTCMANI_ULDS_TEMP.CO_EMPR=_Reader.IsDBNull(COL0) ? string.Empty : _Reader.GetString(COL0);
                        objTCMANI_ULDS_TEMP.CO_TERM=_Reader.IsDBNull(COL1) ? string.Empty : _Reader.GetString(COL1);
                        objTCMANI_ULDS_TEMP.NU_MANI=_Reader.IsDBNull(COL2) ? string.Empty : _Reader.GetString(COL2);
                        objTCMANI_ULDS_TEMP.NU_ULD=     _Reader.IsDBNull(COL3) ? string.Empty : _Reader.GetString(COL3);
                        objTCMANI_ULDS_TEMP.NU_ULD_AMEX=_Reader.IsDBNull(COL4) ? string.Empty : _Reader.GetString(COL4);
                        objTCMANI_ULDS_TEMP.DE_OBSE=   _Reader.IsDBNull(COL5) ? string.Empty : _Reader.GetString(COL5);

                        _Result.lstBE_TCMANI_ULDS_TEMP.Add(objTCMANI_ULDS_TEMP);
                    }
                    //CURSOR 3
                    _Reader.NextResult();

                    COL0 = _Reader.GetOrdinal("CO_EMPR");
                    COL1 = _Reader.GetOrdinal("CO_TERM");
                    COL2 = _Reader.GetOrdinal("NU_MANI");
                    COL3 = _Reader.GetOrdinal("CO_GROU_ULD");
                    COL4 = _Reader.GetOrdinal("NU_ARRA");
                    COL5 = _Reader.GetOrdinal("FE_USER_DATE");
                    COL6 = _Reader.GetOrdinal("NOM_TRANS");
                    COL7 = _Reader.GetOrdinal("NU_PLACA");
                    COL8 = _Reader.GetOrdinal("NU_GUIA_MAGA");
                    COL9 = _Reader.GetOrdinal("NU_ULD");
                    COL10 = _Reader.GetOrdinal("CT_ULD");
                    COL11 = _Reader.GetOrdinal("MT_CARR");
                    COL12 = _Reader.GetOrdinal("OP_CARR");
                    COL13 = _Reader.GetOrdinal("HO_AERO_AMEX");
                    COL14 = _Reader.GetOrdinal("NU_ULD_AMEX");
                    COL15 = _Reader.GetOrdinal("DE_OBSE_0001");
                    COL16 = _Reader.GetOrdinal("DE_OBSE_0002");
                    COL17 = _Reader.GetOrdinal("ES_AERO");
                    int COL18=_Reader.GetOrdinal("CO_STAD_ULDS");
                    int COL19=_Reader.GetOrdinal("DE_STAD_ULDS");
                    

                    _Result.lstBE_TDMANI_ULDS = new List<BE.BE_TDMANI_ULDS>();
                    while(_Reader.Read())
                    {
                        objTDMANI_ULDS=new BE.BE_TDMANI_ULDS();
                        objTDMANI_ULDS.CO_EMPR = _Reader.IsDBNull(COL0) ? string.Empty : _Reader.GetString(COL0);
                        objTDMANI_ULDS.CO_TERM = _Reader.IsDBNull(COL1) ? string.Empty : _Reader.GetString(COL1);
                        objTDMANI_ULDS.NU_MANI = _Reader.IsDBNull(COL2) ? string.Empty : _Reader.GetString(COL2);
                        objTDMANI_ULDS.CO_GROU_ULD = _Reader.IsDBNull(COL3) ? string.Empty : _Reader.GetString(COL3);
                        objTDMANI_ULDS.NU_ARRA = _Reader.IsDBNull(COL4) ? string.Empty : _Reader.GetString(COL4);
                        objTDMANI_ULDS.FE_USER_DATE = _Reader.IsDBNull(COL5) ? string.Empty : _Reader.GetString(COL5);
                        objTDMANI_ULDS.NOM_TRANS = _Reader.IsDBNull(COL6) ? string.Empty : _Reader.GetString(COL6);
                        objTDMANI_ULDS.NU_PLACA = _Reader.IsDBNull(COL7) ? string.Empty : _Reader.GetString(COL7);
                        objTDMANI_ULDS.NU_GUIA_MAGA = _Reader.IsDBNull(COL8) ? string.Empty : _Reader.GetString(COL8);
                        objTDMANI_ULDS.NU_ULD = _Reader.IsDBNull(COL9) ? string.Empty : _Reader.GetString(COL9);
                        objTDMANI_ULDS.CT_ULD = _Reader.IsDBNull(COL10) ? string.Empty : _Reader.GetString(COL10);
                        objTDMANI_ULDS.MT_CARR = _Reader.IsDBNull(COL11) ? string.Empty : _Reader.GetString(COL11);
                        objTDMANI_ULDS.OP_CARR = _Reader.IsDBNull(COL12) ? string.Empty : _Reader.GetString(COL12);
                        objTDMANI_ULDS.HO_AERO_AMEX = _Reader.IsDBNull(COL13) ? string.Empty : _Reader.GetString(COL13);
                        objTDMANI_ULDS.NU_ULD_AMEX = _Reader.IsDBNull(COL14) ? string.Empty : _Reader.GetString(COL14);
                        objTDMANI_ULDS.DE_OBSE_0001 = _Reader.IsDBNull(COL15) ? string.Empty : _Reader.GetString(COL15);
                        objTDMANI_ULDS.DE_OBSE_0002 = _Reader.IsDBNull(COL16) ? string.Empty : _Reader.GetString(COL16);

                        objTDMANI_ULDS.ES_AERO = _Reader.IsDBNull(COL17) ? string.Empty : _Reader.GetString(COL17);
                        objTDMANI_ULDS.CO_STAD_ULDS = _Reader.IsDBNull(COL18) ? string.Empty : _Reader.GetString(COL18);
                        objTDMANI_ULDS.DE_STAD_ULDS = _Reader.IsDBNull(COL19) ? string.Empty : _Reader.GetString(COL19);

                        _Result.lstBE_TDMANI_ULDS.Add(objTDMANI_ULDS);
                    }
                    
                    
                    
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(Validacion.BuscarCadena(ex.Message,'@'));
            }
            finally {
                db_BaseDatos.LimpiarComandos();
                db_BaseDatos.CloseConnection();
            }
            
            return _Result;

        }

        public List<BE.BE_ULDS_EXCE> GetInventarioULDS(string CO_EMPR, string CO_TERM, string CO_ENTI_LINE)
        {
           List<BE.BE_ULDS_EXCE> _Result = new List<BE.BE_ULDS_EXCE>();

            try
            {
                db_BaseDatos.LimpiarComandos();
                db_BaseDatos.AddParameterIn("ICO_EMPR", Database.ExpectedType.String, CO_EMPR);
                db_BaseDatos.AddParameterIn("ICO_TERM", Database.ExpectedType.String, CO_TERM);
                db_BaseDatos.AddParameterIn("ICO_ENTI_LINE", Database.ExpectedType.String, CO_ENTI_LINE);

                db_BaseDatos.AddParameterOut("VCURSOR", Database.ExpectedType.Cursor);

                IDataReader _Reader;
                BE.BE_ULDS_EXCE objBE_ULDS_EXCE = null;
             

                using (_Reader = db_BaseDatos.ExecuteReaderByCommand("TLMEXTR.PKG_ULDS.UPS_GET_ULDS_INVE_EX"))
                {


                    int COL0 = _Reader.GetOrdinal("CO_EMPR");
                    int COL1 = _Reader.GetOrdinal("CO_TERM");
                    int COL2 = _Reader.GetOrdinal("NU_MANI");
                    int COL3 = _Reader.GetOrdinal("TI_ENTI_LINE");
                    int COL4 = _Reader.GetOrdinal("CO_ENTI_LINE");
                    int COL5 = _Reader.GetOrdinal("DE_ENTI_LINE");                   
                    int COL6 = _Reader.GetOrdinal("NU_VUEL");
                    int COL7 = _Reader.GetOrdinal("FE_LLEG_VUEL");
                    int COL8 = _Reader.GetOrdinal("FE_LLEG_ALMA");
                    int COL9 = _Reader.GetOrdinal("NU_GUIA_MAGA");
                    int COL10 = _Reader.GetOrdinal("DE_OBSE_0001");
                    int COL11 = _Reader.GetOrdinal("DE_OBSE_0002");
                    int COL12 = _Reader.GetOrdinal("ST_ULDS");
                    int COL13 = _Reader.GetOrdinal("NU_ULD");
                    int COL14 = _Reader.GetOrdinal("ES_AERO");
                    //Cursor 1
                    while (_Reader.Read())
                    {
                        objBE_ULDS_EXCE = new BE.BE_ULDS_EXCE();

                        objBE_ULDS_EXCE.CO_EMPR = _Reader.IsDBNull(COL0) ? string.Empty : _Reader.GetString(COL0);
                        objBE_ULDS_EXCE.CO_TERM = _Reader.IsDBNull(COL1) ? string.Empty : _Reader.GetString(COL1);
                        objBE_ULDS_EXCE.NU_MANI = _Reader.IsDBNull(COL2) ? string.Empty : _Reader.GetString(COL2);
                        objBE_ULDS_EXCE.TI_ENTI_LINE = _Reader.IsDBNull(COL3) ? string.Empty : _Reader.GetString(COL3);
                        objBE_ULDS_EXCE.CO_ENTI_LINE = _Reader.IsDBNull(COL4) ? string.Empty : _Reader.GetString(COL4);
                        objBE_ULDS_EXCE.DE_ENTI_LINE = _Reader.IsDBNull(COL5) ? string.Empty : _Reader.GetString(COL5);
                        objBE_ULDS_EXCE.NU_VUEL = _Reader.IsDBNull(COL6) ? string.Empty : _Reader.GetString(COL6);
                        objBE_ULDS_EXCE.FE_LLEG_VUEL = _Reader.IsDBNull(COL7) ? string.Empty : _Reader.GetString(COL7);
                        objBE_ULDS_EXCE.FE_LLEG_ALMA = _Reader.IsDBNull(COL8) ? string.Empty : _Reader.GetString(COL8);
                        objBE_ULDS_EXCE.NU_GUIA_MAGA = _Reader.IsDBNull(COL9) ? string.Empty : _Reader.GetString(COL9);
                        objBE_ULDS_EXCE.DE_OBSE_0001 = _Reader.IsDBNull(COL10) ? string.Empty : _Reader.GetString(COL10);
                        objBE_ULDS_EXCE.DE_OBSE_0002 = _Reader.IsDBNull(COL11) ? string.Empty : _Reader.GetString(COL11);
                        objBE_ULDS_EXCE.ST_ULDS = _Reader.IsDBNull(COL12) ? string.Empty : _Reader.GetString(COL12);
                        objBE_ULDS_EXCE.NU_ULD = _Reader.IsDBNull(COL13) ? string.Empty : _Reader.GetString(COL13);
                        objBE_ULDS_EXCE.ES_AERO = _Reader.IsDBNull(COL14) ? string.Empty : _Reader.GetString(COL14);
                        
                        _Result.Add(objBE_ULDS_EXCE);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(Validacion.BuscarCadena(ex.Message, '@'));
            }
            finally
            {
                db_BaseDatos.LimpiarComandos();
                db_BaseDatos.CloseConnection();
            }

            return _Result;
        }


    }
}
