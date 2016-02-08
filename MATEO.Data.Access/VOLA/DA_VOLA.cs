using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using DataBase_Oracle;
using BE = MATEO.Bussines.Entity.VOLA;


namespace MATEO.Data.Access.VOLA
{
    public class DA_VOLA : Instance.ConnectionManager
    {
        private static Database db_BaseDatos;
        public DA_VOLA()
        {
            db_BaseDatos = new Database(ConexionDataBase);
        }
        public BE.BE_VOLA GetVolante(string CO_EMPR, string CO_TERM,  string TP_FILT, string VL_FILT)
        {
            BE.BE_VOLA _Result = new BE.BE_VOLA();
            _Result.lstVolanteReport = new List<BE.BE_TCVOLA_REPO>();
            _Result.Result = new Bussines.Entity.BE_RESULT();
            try
            {
                db_BaseDatos.LimpiarComandos();
                db_BaseDatos.AddParameterIn("ICO_EMPR", Database.ExpectedType.String, CO_EMPR);
                db_BaseDatos.AddParameterIn("ICO_TERM", Database.ExpectedType.String, CO_TERM);
                db_BaseDatos.AddParameterIn("ICO_NEGO", Database.ExpectedType.String, "IMP");
                db_BaseDatos.AddParameterIn("ITP_FILT", Database.ExpectedType.String, TP_FILT);
                db_BaseDatos.AddParameterIn("IVL_FILT", Database.ExpectedType.String, VL_FILT);

                db_BaseDatos.AddParameterOut("VCURSOR", Database.ExpectedType.Cursor);

                IDataReader _Reader;
                BE.BE_TCVOLA_REPO _objBE_TCVOLA_REPO = null;
                using (_Reader = db_BaseDatos.ExecuteReaderByCommand("TLMEXTR.PKG_MATEO.UPS_GET_CONSULT_GUIA"))
                {
                    int COL0, COL1, COL2, COL3, COL4, COL5, COL6, COL7, COL8, COL9, COL10, COL11, COL12, COL13, COL14, COL15, COL16, COL17, COL18, COL19, COL20, COL21, COL22, COL23, COL24, COL25, COL26, COL27, COL28, COL29, COL30;
                    //CURSOR 1
                    COL0 = _Reader.GetOrdinal("CO_EMPR");
                    COL1 = _Reader.GetOrdinal("CO_TERM");
                    COL2 = _Reader.GetOrdinal("NU_MANI");
                    COL3 = _Reader.GetOrdinal("NU_VUEL");
                    COL4 = _Reader.GetOrdinal("CO_ENTI_LINE");
                    COL5 = _Reader.GetOrdinal("CO_CIUD_ORIG");
                    COL6 = _Reader.GetOrdinal("CO_CIUD_DEST");
                    COL7 = _Reader.GetOrdinal("NU_GUIA_MADR");
                    COL8 = _Reader.GetOrdinal("NU_GUIA");
                    COL9 = _Reader.GetOrdinal("CO_ENTI_AGRE");
                    COL10 = _Reader.GetOrdinal("DE_ENTI_AGRE");
                    COL11 = _Reader.GetOrdinal("CO_ENTI_AGEM");
                    COL12 = _Reader.GetOrdinal("DE_ENTI_AGEM");
                    COL13 = _Reader.GetOrdinal("NU_BULT_RECI");
                    COL14 = _Reader.GetOrdinal("KG_RECI");
                    COL15 = _Reader.GetOrdinal("CO_ENTI_CONS");
                    COL16 = _Reader.GetOrdinal("NO_CONS");
                    COL17 = _Reader.GetOrdinal("DE_CARG_0001");
                    COL18 = _Reader.GetOrdinal("TI_INGR");
                    COL19 = _Reader.GetOrdinal("DE_TIPO_INGR");
                    COL20 = _Reader.GetOrdinal("NU_VOLA");
                    COL21 = _Reader.GetOrdinal("NU_VOLA_MADR");
                    COL22 = _Reader.GetOrdinal("ST_INVE");
                    COL23 = _Reader.GetOrdinal("ST_VOLA");
                    COL24 = _Reader.GetOrdinal("NU_BULT_VOLA");
                    COL25 = _Reader.GetOrdinal("KG_RECI_VOLA");
                    COL26 = _Reader.GetOrdinal("ST_TRAN");
                    COL27 = _Reader.GetOrdinal("DE_ORIG_CARG");
                    COL28 = _Reader.GetOrdinal("DE_DEST_CARG");

                    while (_Reader.Read())
                    {
                        _objBE_TCVOLA_REPO = new BE.BE_TCVOLA_REPO();
                        _objBE_TCVOLA_REPO.CO_EMPR = _Reader.IsDBNull(COL0) ? string.Empty : _Reader.GetString(COL0);
                        _objBE_TCVOLA_REPO.CO_TERM = _Reader.IsDBNull(COL1) ? string.Empty : _Reader.GetString(COL1);
                        _objBE_TCVOLA_REPO.NU_MANI = _Reader.IsDBNull(COL2) ? string.Empty : _Reader.GetString(COL2);
                        _objBE_TCVOLA_REPO.NU_VUEL = _Reader.IsDBNull(COL3) ? string.Empty : _Reader.GetString(COL3);
                        _objBE_TCVOLA_REPO.CO_ENTI_LINE = _Reader.IsDBNull(COL4) ? string.Empty : _Reader.GetString(COL4);
                        _objBE_TCVOLA_REPO.CO_CIUD_ORIG = _Reader.IsDBNull(COL5) ? string.Empty : _Reader.GetString(COL5);
                        _objBE_TCVOLA_REPO.CO_CIUD_DEST = _Reader.IsDBNull(COL6) ? string.Empty : _Reader.GetString(COL6);
                        _objBE_TCVOLA_REPO.NU_GUIA_MADR = _Reader.IsDBNull(COL7) ? string.Empty : _Reader.GetString(COL7);
                        _objBE_TCVOLA_REPO.NU_GUIA = _Reader.IsDBNull(COL8) ? string.Empty : _Reader.GetString(COL8);
                        _objBE_TCVOLA_REPO.CO_ENTI_AGRE = _Reader.IsDBNull(COL9) ? string.Empty : _Reader.GetString(COL9);
                        _objBE_TCVOLA_REPO.DE_ENTI_AGRE = _Reader.IsDBNull(COL10) ? string.Empty : _Reader.GetString(COL10);
                        _objBE_TCVOLA_REPO.CO_ENTI_AGEM = _Reader.IsDBNull(COL11) ? string.Empty : _Reader.GetString(COL11);
                        _objBE_TCVOLA_REPO.DE_ENTI_AGEM = _Reader.IsDBNull(COL12) ? string.Empty : _Reader.GetString(COL12);
                        _objBE_TCVOLA_REPO.NU_BULT_RECI = _Reader.IsDBNull(COL13) ? string.Empty : _Reader.GetString(COL13);
                        _objBE_TCVOLA_REPO.KG_RECI = _Reader.IsDBNull(COL14) ? string.Empty : _Reader.GetString(COL14);
                        _objBE_TCVOLA_REPO.CO_ENTI_CONS = _Reader.IsDBNull(COL15) ? string.Empty : _Reader.GetString(COL15);
                        _objBE_TCVOLA_REPO.NO_CONS = _Reader.IsDBNull(COL16) ? string.Empty : _Reader.GetString(COL16);
                        _objBE_TCVOLA_REPO.DE_CARG_0001 = _Reader.IsDBNull(COL17) ? string.Empty : _Reader.GetString(COL17);
                        _objBE_TCVOLA_REPO.TI_INGR = _Reader.IsDBNull(COL18) ? string.Empty : _Reader.GetString(COL18);
                        _objBE_TCVOLA_REPO.DE_TIPO_INGR = _Reader.IsDBNull(COL19) ? string.Empty : _Reader.GetString(COL19);
                        _objBE_TCVOLA_REPO.NU_VOLA = _Reader.IsDBNull(COL20) ? string.Empty : _Reader.GetString(COL20);
                        _objBE_TCVOLA_REPO.NU_VOLA_MADR = _Reader.IsDBNull(COL21) ? string.Empty : _Reader.GetString(COL21);
                        _objBE_TCVOLA_REPO.ST_INVE = _Reader.IsDBNull(COL22) ? string.Empty : _Reader.GetString(COL22);
                        _objBE_TCVOLA_REPO.ST_VOLA = _Reader.IsDBNull(COL23) ? string.Empty : _Reader.GetString(COL23);
                        _objBE_TCVOLA_REPO.NU_BULT_VOLA = _Reader.IsDBNull(COL24) ? string.Empty : _Reader.GetString(COL24);
                        _objBE_TCVOLA_REPO.KG_RECI_VOLA = _Reader.IsDBNull(COL25) ? string.Empty : _Reader.GetString(COL25);
                        _objBE_TCVOLA_REPO.ST_TRAN = _Reader.IsDBNull(COL26) ? string.Empty : _Reader.GetString(COL26);
                        _objBE_TCVOLA_REPO.DE_ORIG_CARG = _Reader.IsDBNull(COL27) ? string.Empty : _Reader.GetString(COL27);
                        _objBE_TCVOLA_REPO.DE_DEST_CARG = _Reader.IsDBNull(COL28) ? string.Empty : _Reader.GetString(COL28);
                        _Result.lstVolanteReport.Add(_objBE_TCVOLA_REPO);
                    }

                }
                _Result.Result.ResultEje = true;
                _Result.Result.Codigo = 1;
                _Result.Result.Mensaje = "OK";
            }
            catch (Exception ex)
            {                 
                _Result.Result.ResultEje=false;
                _Result.Result.Codigo = -1;
                _Result.Result.Mensaje =Validacion.BuscarCadena(ex.Message, '@');
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
