﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// entidad departamento
    /// </summary>
    public class ClsDepartamento
    {
        #region atributos
        /// <summary>
        /// atributos del departamento (id y nombre)
        /// </summary>
        private int id;
        private string nombre;
        #endregion

        #region propiedades
        /// <summary>
        /// Propiedades de la entidad ClsDepartamento
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor vacío
        /// </summary>
        public ClsDepartamento()
        {


        }
        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        public ClsDepartamento(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        #endregion
    }
}