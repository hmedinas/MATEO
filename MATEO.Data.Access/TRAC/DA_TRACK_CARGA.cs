using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataBase_Oracle;
using MATEO.Bussines.Entity.TRAC;

namespace MATEO.Data.Access.TRAC
{
    public class DA_TRACK_CARGA : Instance.ConnectionManager
    {
        private static Database db_BaseDatos;
        public DA_TRACK_CARGA()
        {
            db_BaseDatos = new Database(ConexionDataBase);
        }
        public List<BE_TRACKING_CARGA> ListarTracking(string ICO_EMPR, string ICO_TERM, string IFE_INI, string IFE_FIN, decimal ITI_FILT)
        {
            List<BE_TRACKING_CARGA> _result = new List<BE_TRACKING_CARGA>();

            BE_TC_MANIFIESTO objMani = new BE_TC_MANIFIESTO();
            BE_TC_GUIA_MASTER objGM = new BE_TC_GUIA_MASTER();
            BE_TC_GUIA_HOUSE objGH = new BE_TC_GUIA_HOUSE();
            BE_TC_VOLANTE_MASTER objVM = new BE_TC_VOLANTE_MASTER();
            BE_TC_VOLANTE_HIJA objVH = new BE_TC_VOLANTE_HIJA();
            BE_TC_FACTURA objFA = new BE_TC_FACTURA();
            BE_TC_SALIDAS objSA = new BE_TC_SALIDAS();

            try
            {
                db_BaseDatos.LimpiarComandos();
                db_BaseDatos.AddParameterIn("ICO_EMPR", Database.ExpectedType.String, ICO_EMPR);
                db_BaseDatos.AddParameterIn("ICO_TERM", Database.ExpectedType.String, ICO_TERM);
                db_BaseDatos.AddParameterIn("IFE_INI", Database.ExpectedType.String, IFE_INI);
                db_BaseDatos.AddParameterIn("IFE_FIN", Database.ExpectedType.String, IFE_FIN);
                db_BaseDatos.AddParameterIn("ITI_FILT", Database.ExpectedType.Number, ITI_FILT);
                db_BaseDatos.AddParameterOut("VCURSOR", Database.ExpectedType.Cursor);
                IDataReader _reader;

                BE_TRACKING_LIST _objEntidad = null;
                using (_reader = db_BaseDatos.ExecuteReaderByCommand("TLMIMPO.PKG_TRACKING.SP_SEL_FLOW_TRACKING"))
                {
                    int COL0 = _reader.GetOrdinal("NU_MANI");
                    int COL1 = _reader.GetOrdinal("FE_L_AL");
                    int COL2 = _reader.GetOrdinal("FE_L_VL");
                    int COL3 = _reader.GetOrdinal("NU_GUIA_MADR");
                    int COL4 = _reader.GetOrdinal("NU_GUIA");
                    int COL5 = _reader.GetOrdinal("G_KIL");
                    int COL6 = _reader.GetOrdinal("DE_ALMA");
                    int COL7 = _reader.GetOrdinal("NU_VOLA_MADR");
                    int COL8 = _reader.GetOrdinal("NU_VOLA");
                    int COL9 = _reader.GetOrdinal("ST_VOLA");
                    int COL10 = _reader.GetOrdinal("V_KIL");
                    int COL11 = _reader.GetOrdinal("NU_DOCU");
                    int COL12 = _reader.GetOrdinal("FE_DOCU");
                    int COL13 = _reader.GetOrdinal("TI_DOCU");
                    int COL14 = _reader.GetOrdinal("ST_SALI_FACT");
                    int COL15 = _reader.GetOrdinal("IM_EMIT");
                    int COL16 = _reader.GetOrdinal("NU_SALI");
                    int COL17 = _reader.GetOrdinal("FE_SALI");
                    int COL18 = _reader.GetOrdinal("ST_SALI");
                    while (_reader.Read())
                    {
                        _objEntidad = new BE_TRACKING_LIST();
                        _objEntidad.NU_MANI = _reader.IsDBNull(COL0) ? null : _reader.GetString(COL0);
                        _objEntidad.FE_L_AL = _reader.IsDBNull(COL1) ? null : _reader.GetString(COL1);
                        _objEntidad.FE_L_VL = _reader.IsDBNull(COL2) ? null : _reader.GetString(COL2);
                        _objEntidad.NU_GUIA_MADR = _reader.IsDBNull(COL3) ? null : _reader.GetString(COL3);
                        _objEntidad.NU_GUIA = _reader.IsDBNull(COL4) ? null : _reader.GetString(COL4);
                        _objEntidad.G_KIL = _reader.IsDBNull(COL5) ? null : _reader.GetString(COL5);
                        _objEntidad.DE_ALMA = _reader.IsDBNull(COL6) ? null : _reader.GetString(COL6);
                        _objEntidad.NU_VOLA_MADR = _reader.IsDBNull(COL7) ? null : _reader.GetString(COL7);
                        _objEntidad.NU_VOLA = _reader.IsDBNull(COL8) ? null : _reader.GetString(COL8);
                        _objEntidad.ST_VOLA = _reader.IsDBNull(COL9) ? null : _reader.GetString(COL9);
                        _objEntidad.V_KIL = _reader.IsDBNull(COL10) ? null : _reader.GetString(COL10);
                        _objEntidad.NU_DOCU = _reader.IsDBNull(COL11) ? null : _reader.GetString(COL11);
                        _objEntidad.FE_DOCU = _reader.IsDBNull(COL12) ? null : _reader.GetString(COL12);
                        _objEntidad.TI_DOCU = _reader.IsDBNull(COL13) ? null : _reader.GetString(COL13);
                        _objEntidad.ST_SALI_FACT = _reader.IsDBNull(COL14) ? null : _reader.GetString(COL14);
                        _objEntidad.IM_EMIT = _reader.IsDBNull(COL15) ? 0 : _reader.GetDecimal(COL15);
                        _objEntidad.NU_SALI = _reader.IsDBNull(COL16) ? null : _reader.GetString(COL16);
                        _objEntidad.FE_SALI = _reader.IsDBNull(COL17) ? null : _reader.GetString(COL17);
                        _objEntidad.ST_SALI = _reader.IsDBNull(COL18) ? null : _reader.GetString(COL18);

                        //get all to object

                        //Manifiesto
                        if (objMani.value != _objEntidad.NU_MANI)
                        {
                            objMani = new BE_TC_MANIFIESTO();
                            objMani.value = _objEntidad.NU_MANI;
                            objMani.text = "Manifiesto";
                            objMani.data = new List<BE_TC_DATA>() { 
                                new BE_TC_DATA { text = _objEntidad.NU_MANI, label = "Nro Mani" },
                                new BE_TC_DATA { text = _objEntidad.FE_L_AL, label = "F.ALM L" },
                                new BE_TC_DATA { text = _objEntidad.FE_L_VL, label = "F.VUEL L" }
                            };
                            _result.Add(objMani);

                            //new instance variable
                            objGM = new BE_TC_GUIA_MASTER();
                            objGH = new BE_TC_GUIA_HOUSE();
                            objVM = new BE_TC_VOLANTE_MASTER();
                            objVH = new BE_TC_VOLANTE_HIJA();
                            objFA = new BE_TC_FACTURA();
                            objSA = new BE_TC_SALIDAS();
                        }

                        //Guia
                        if (objGM.value != _objEntidad.NU_GUIA_MADR)
                        {
                            objGM = new BE_TC_GUIA_MASTER();
                            objGM.value = _objEntidad.NU_GUIA_MADR;
                            objGM.text = "Guia Madre";
                            objGM.data = new List<BE_TC_DATA>() { 
                            new BE_TC_DATA { text = _objEntidad.NU_GUIA_MADR, label = "Guia Master" }
                        };
                            objMani.items.Add(objGM);
                            //objGM = new BE_TC_GUIA_MASTER();
                        }

                        //House
                        if (objGH.value != _objEntidad.NU_GUIA)
                        {
                            //objVM = new Dictionary<string, BE_TC_VOLANTE_MASTER>();
                            objGH = new BE_TC_GUIA_HOUSE();
                            objGH.value = _objEntidad.NU_GUIA;
                            objGH.text = "Guia House";
                            objGH.data = new List<BE_TC_DATA>() { 
                                new BE_TC_DATA { text = _objEntidad.NU_GUIA, label = "Guia House" },
                                new BE_TC_DATA { text = _objEntidad.G_KIL, label = "K.Bult" },
                                new BE_TC_DATA { text = _objEntidad.DE_ALMA, label = "T. Carga" }
                            };
                            objGH.rootValue = _objEntidad.NU_MANI;
                            objGH.parentValue = _objEntidad.NU_GUIA_MADR;

                            objGH.allowButtons = true;
                            objGM.items.Add(objGH);
                        }

                        //Vol Mast --Parente node temp
                        if (objVM.value != _objEntidad.NU_VOLA_MADR)
                        {
                            if (_objEntidad.NU_VOLA_MADR == objVH.value)
                            {
                                objVH.tag = "PH";
                                objVM = objVH;
                            }
                            else
                            {

                                objVM = new BE_TC_VOLANTE_MASTER();
                                objGH.items.Add(objVM);

                                objVM.value = _objEntidad.NU_VOLA_MADR;
                                objVM.text = "Volante Madre";
                                objVM.data = new List<BE_TC_DATA>() {
                                new BE_TC_DATA { text = _objEntidad.NU_VOLA_MADR, label = "Vol Master" },
                                new BE_TC_DATA { text = _objEntidad.ST_VOLA, label = "Estado" }
                            };
                            }
                            //objVM.value = _objEntidad.NU_VOLA_MADR;
                            //objVM.text = "Volante Madre";
                            //objVM.data = new List<BE_TC_DATA>() { 
                            //    new BE_TC_DATA { text = _objEntidad.NU_VOLA_MADR, label = "Vol Master" },
                            //    new BE_TC_DATA { text = _objEntidad.ST_VOLA, label = "Estado" }
                            //};

                            objGH.collapsed = objGH.items.Count > 1;

                        }

                        //Vol Hija
                        if (objVH.value != _objEntidad.NU_VOLA)
                        {
                            objVH = new BE_TC_VOLANTE_HIJA();
                            objVH.value = _objEntidad.NU_VOLA;
                            objVH.text = "Volante Hija";
                            objVH.data = new List<BE_TC_DATA>() { 
                                new BE_TC_DATA { text = _objEntidad.NU_VOLA, label = "Volante" },
                                new BE_TC_DATA { text = _objEntidad.V_KIL, label = "Inventario" },
                                new BE_TC_DATA { text = _objEntidad.ST_VOLA, label = "Estado" }
                            };
                            objVH.rootValue = _objEntidad.NU_MANI;
                            objVH.parentValue = _objEntidad.NU_GUIA;

                            objVH.allowButtons = true;
                            objVM.items.Add(objVH);

                            if (objVM.items.Count > 1)
                            {
                                var parent = objVM.items.Find(v => v.value == objVM.value);
                                if (parent != null)
                                {
                                    objVM.items.Remove(parent);
                                }
                            }
                        }

                        //House
                        if (objFA.value != _objEntidad.NU_DOCU)
                        {
                            if (!string.IsNullOrEmpty(_objEntidad.NU_DOCU))
                            {
                                objFA = new BE_TC_FACTURA();
                                objFA.value = _objEntidad.NU_DOCU;
                                objFA.text = "Factura";
                                objFA.data = new List<BE_TC_DATA>() { 
                                new BE_TC_DATA { text = _objEntidad.NU_DOCU, label = "Factura" },
                                new BE_TC_DATA { text = _objEntidad.FE_DOCU, label = "Fecha" },
                                new BE_TC_DATA { text = _objEntidad.TI_DOCU, label = "Tipo" },
                                new BE_TC_DATA { text = _objEntidad.ST_SALI_FACT, label = "Salida" },
                                new BE_TC_DATA { text = _objEntidad.IM_EMIT.ToString(), label = "Importe" }
                            };

                                objVH.items.Add(objFA);
                            }
                        }

                        //Salidas
                        if (objSA.value != _objEntidad.NU_SALI)
                        {
                            if (!string.IsNullOrEmpty(_objEntidad.NU_SALI))
                            {
                                objSA = new BE_TC_SALIDAS();
                                objSA.value = _objEntidad.NU_SALI;
                                objSA.text = "Factura";
                                objSA.data = new List<BE_TC_DATA>(){
                                new BE_TC_DATA { text = _objEntidad.NU_SALI, label = "Nro Salida" },
                                new BE_TC_DATA { text = _objEntidad.FE_SALI, label = "Fecha" },
                                new BE_TC_DATA { text = _objEntidad.ST_SALI, label = "Estado" },

                            };
                                objFA.items.Add(objSA);
                            }
                        }

                    }
                    _reader.Close();
                }



            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db_BaseDatos.LimpiarComandos();
                db_BaseDatos.CloseConnection();
            }

            return _result;
        }
    }
}
