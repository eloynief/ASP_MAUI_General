using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// clase para los enlaces de la base de datos
    /// </summary>
    internal class EnlaceBBDD
    {

        /// <summary>
        /// Metodo para el enlace de la base de datos
        /// </summary>
        /// <returns></returns>
        public static string enlace(string server,string baseDatos, string usuario, string contrasena)
        {
            //enlace a la base de datos
            string enlace = $"server={server};database={baseDatos};uid={usuario};pwd={contrasena};";

            return enlace;
        }

        /// <summary>
        /// metodo para obtener la conexion a la base de datos
        /// </summary>
        /// <returns></returns>
        public static SqlConnection getConexion()
        {
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = enlace("eloybadat.database.windows.net", "eloybadat", "prueba", "fernandoG321");
                conexion.Open();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return conexion;
        }





    }
}
