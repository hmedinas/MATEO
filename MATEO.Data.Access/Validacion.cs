using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MATEO.Data.Access
{
    public class Validacion
    {
        public static string BuscarCadena(String Cadena, char Inicio)
        {
            try
            {
                string[] CadenaArray;
                CadenaArray = Cadena.Split(Inicio);
                return CadenaArray[1].ToString().Replace("ORA-20001", "ERROR").Replace("ORA-20000", "ERROR");
            }
            catch (Exception)
            {

                return RecuperarError(Cadena);
            }
        }
        public static string RecuperarError(String inputMensajeError)
        {
            string MensajeError = inputMensajeError.ToString();
            MensajeError = MensajeError.ToString().Replace("\"", "").Replace("\n", "</br>").Replace("'", "");
            return MensajeError;
        }
    }
}
