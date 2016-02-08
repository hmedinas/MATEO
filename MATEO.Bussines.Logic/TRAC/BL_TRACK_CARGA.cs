using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MATEO.Bussines.Entity.TRAC;
using MATEO.Data.Access.TRAC;

namespace MATEO.Bussines.Logic.TRAC
{
    public class BL_TRACK_CARGA
    {
        public List<BE_TRACKING_CARGA> ListarTracking(string ICO_EMPR, string ICO_TERM, string IFE_INI, string IFE_FIN, decimal ITI_FILT)
        {
            try
            {
                return new DA_TRACK_CARGA().ListarTracking(ICO_EMPR, ICO_TERM, IFE_INI, IFE_FIN, ITI_FILT);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
