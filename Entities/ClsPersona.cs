namespace Entities
{
    /// <summary>
    /// entidad persona
    /// </summary>
    public class ClsPersona
    {
        #region atributos
        /// <summary>
        /// Atributos de la entidad ClsPersona
        /// </summary>
        int id;
        String nombre;
        String apellido;
        DateTime fechaNac;
        String direccion;
        String foto;
        String telefono;
        int idDepartamento;

        #endregion

        #region propiedades
        /// <summary>
        /// propiedades de la entidad ClsPersona
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public DateTime FechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }

        public int IdDepartamento
        {
            get { return idDepartamento; }
            set { idDepartamento = value; }
        }

        public String Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        #endregion

        #region constructores

        /// <summary>
        /// constructor de ClsPersona sin parametros
        /// </summary>
        public ClsPersona()
        {
        }

        /// <summary>
        /// constructor de la entidad de ClsPersona con parametros
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="fechaNac"></param>
        /// <param name="direccion"></param>
        /// <param name="foto"></param>
        /// <param name="telefono"></param>
        /// <param name="idDepartamento"></param>
        public ClsPersona(int id, string nombre, string apellido, DateTime fechaNac, String direccion, String foto, String telefono, int idDepartamento)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
            this.direccion = direccion;
            this.foto = foto;
            this.telefono = telefono;
            this.idDepartamento = idDepartamento;
        }
        #endregion
    }
}
