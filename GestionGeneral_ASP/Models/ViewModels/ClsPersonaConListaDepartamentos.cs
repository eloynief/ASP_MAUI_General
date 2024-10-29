using Entities;

namespace GestionGeneral_ASP.Models.ViewModels
{


    /// <summary>
    /// viewmodel con la entidad de persona y una lista de los departamentos
    /// Este viewmodel interactua con la pagina. Dentro de 
    /// (Puse summary en el viewmodel)
    /// </summary>
    public class ClsPersonaConListaDepartamentos : ClsPersona
    {
        #region atributos
        /// <summary>
        /// atributo para la lista de departamentos
        /// </summary>
        private List<ClsDepartamento> listadoDepartamentos;
        #endregion

        #region propiedades
        /// <summary>
        /// propiedad para el listado de departamentos
        /// </summary>
        public List<ClsDepartamento> ListadoDepartamentos
        {
            get { return listadoDepartamentos; }
        }
        #endregion

        #region constructores
        /// <summary>
        /// constructor con parametros
        /// </summary>
        /// <param name="persona"></param>
        /// <param name="listadoDepartamentos"></param>
        public ClsPersonaConListaDepartamentos(ClsPersona persona, List<ClsDepartamento> listadoDepartamentos) : base(persona.Id, persona.Nombre, persona.Apellido, persona.FechaNac, persona.Direccion, persona.Foto, persona.Telefono, persona.IdDepartamento)
        {


            //(int id, string nombre, string apellido, DateTime fechaNac, String direccion, String foto, String telefono, int idDepartamento)
            this.listadoDepartamentos = listadoDepartamentos;


        }
        #endregion
    }



}
