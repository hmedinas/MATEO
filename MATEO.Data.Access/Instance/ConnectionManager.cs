using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Configuration;
using keyConnection;
using System.Data;
using System.Reflection;


namespace MATEO.Data.Access.Instance
{
    public abstract class ConnectionManager
    {
        private String m_strSqlConnectionDB;

        public ConnectionManager()
        {
            if (ConfigurationManager.AppSettings["Encriptacion"].ToString() == "OFF")
            {

                m_strSqlConnectionDB = ConfigurationManager.ConnectionStrings["BD_CONECTION"].ConnectionString;
            }
            else
            {

                m_strSqlConnectionDB = new Connection().DesencriptarOnlyText(ConfigurationManager.ConnectionStrings["BD_CONECTION"].ConnectionString);
            }
        }


        /// <summary>
        /// Conexion a la base de datos
        /// </summary>
        public String ConexionDataBase
        {
            get { return m_strSqlConnectionDB; }
            set { m_strSqlConnectionDB = value; }
        }


        public List<OBJECT> MapToObject<OBJECT>(DataTable dtTable)
            where OBJECT : new()
        {
            List<OBJECT> lista = new List<OBJECT>();

            foreach (DataRow drRow in dtTable.Rows)
            {
                OBJECT obj = new OBJECT();
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (drRow[prop.Name].Equals(DBNull.Value))
                    {
                        if (prop.PropertyType == typeof(string))
                            drRow[prop.Name] = "";
                        else if (prop.PropertyType == typeof(decimal))
                            drRow[prop.Name] = 0;
                        else if (prop.PropertyType == typeof(DateTime))
                            drRow[prop.Name] = DateTime.Now;
                    }

                    prop.SetValue(obj, drRow[prop.Name], null);
                }
                lista.Add(obj);
            }

            return lista;
        }

        public List<OBJECT> MapToPartialObject<OBJECT>(DataTable dt)
            where OBJECT : new()
        {
            List<OBJECT> lista = new List<OBJECT>();

            foreach (DataRow dr in dt.Rows)
            {
                OBJECT obj = new OBJECT();

                foreach (DataColumn dcColumna in dr.Table.Columns)
                {
                    String columna;
                    columna = dcColumna.ColumnName;

                    foreach (PropertyInfo prop in obj.GetType().GetProperties())
                    {
                        if (prop.Name.Equals(columna))
                        {
                            if (dr[prop.Name].Equals(DBNull.Value))
                            {
                                if (prop.PropertyType == typeof(string))
                                    dr[prop.Name] = "";
                                else if (prop.PropertyType == typeof(decimal))
                                    dr[prop.Name] = 0;
                                else if (prop.PropertyType == typeof(DateTime))
                                    dr[prop.Name] = DateTime.Now;
                            }

                            prop.SetValue(obj, dr[prop.Name], null);
                            break;
                        }
                    }
                }
                lista.Add(obj);
            }
            return lista;
        }
    }
}
