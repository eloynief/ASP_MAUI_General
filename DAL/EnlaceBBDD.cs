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
        public static string enlace(string usuario, string contrasena)
        {
            


            //enlace a la base de datos
            string enlace = $"server=localhost;database=eloybadat;uid={usuario};pwd={contrasena};server=107-03\\SQLEXPRESS;database=Personas;uid={usuario};pwd={contrasena}; TrustServerCertificate = true;";


            return enlace;
        }

    }
}
