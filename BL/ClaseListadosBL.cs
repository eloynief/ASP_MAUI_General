﻿using Entities;

namespace BL
{
    public class ClaseListadosBL
    {


        /// <summary>
        /// Funcion para la capa de negocios del listado de personas de la capa DAL
        /// </summary>
        /// <returns></returns>
        public static List<ClsPersona> listadoPersonasBL()
        {

            //return DAL.ClaseListados.listadoPersonas();

            return DAL.ClaseListados.listadoPersonas();

        }

        public static List<ClsDepartamento> listadoDepartamentosBL()
        {

            return DAL.ClaseListados.listadoDepartamentos();
        }



    }
}
