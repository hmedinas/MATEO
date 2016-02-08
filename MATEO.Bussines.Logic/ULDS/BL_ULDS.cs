using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA = MATEO.Data.Access.ULDS;
using BE = MATEO.Bussines.Entity.ULDS;
namespace MATEO.Bussines.Logic.ULDS
{
    public class BL_ULDS
    {
        public BE.BE_ULDS GetTableULD(string CO_EMPR, string CO_TERM, string NU_MANI) 
        {
            BE.BE_ULDS _Result = new BE.BE_ULDS();
            try
            {
                DA.DA_ULDS _objDA_ULDS = new DA.DA_ULDS();
                _Result= _objDA_ULDS.GetTableULD(CO_EMPR, CO_TERM, NU_MANI);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            return _Result;

        }
        public List<BE.BE_ULDS_EXCE> GetInventarioULDS(string CO_EMPR, string CO_TERM, string CO_ENTI_LINE)
        {
            List<BE.BE_ULDS_EXCE> _Result = new List<BE.BE_ULDS_EXCE>();
            try
            {
                DA.DA_ULDS _objDA_ULDS = new DA.DA_ULDS();
                _Result = _objDA_ULDS.GetInventarioULDS(CO_EMPR, CO_TERM, CO_ENTI_LINE);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            return _Result;
        }
    }
}
