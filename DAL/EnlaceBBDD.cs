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

    }
}
