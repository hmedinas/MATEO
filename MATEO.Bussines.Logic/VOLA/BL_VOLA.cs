using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA = MATEO.Data.Access.VOLA;
using BE = MATEO.Bussines.Entity.VOLA;

namespace MATEO.Bussines.Logic.VOLA
{
    public class BL_VOLA
    {
        public BE.BE_VOLA GetConsultGuia(string CO_EMPR, string CO_TERM, string TP_NEGO, string TP_FILT, string VL_FILT)
        {
            BE.BE_VOLA _Result = new BE.BE_VOLA();
            try
            {
                DA.DA_VOLA _objDA_VOLA = new DA.DA_VOLA();
                if (TP_NEGO == "IMP")
                {
                    _Result = _objDA_VOLA.GetVolante(CO_EMPR, CO_TERM, TP_FILT, VL_FILT);
                }
                if (TP_NEGO == "EXP")
                {
                    _Result = new BE.BE_VOLA();
                }
                
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            return _Result;

        }
    }
}
