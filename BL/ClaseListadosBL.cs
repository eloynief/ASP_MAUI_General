using Entities;

namespace BL
{
    public class ClaseListadosBL
    {


        /// <summary>
        /// Funcion para crear el listado de personas
        /// </summary>
        /// <returns></returns>
        public static List<ClsPersona> listadoPersonasBL()
        {



            return DAL.ClaseListados.listadoPersonas();

        }



    }
}
