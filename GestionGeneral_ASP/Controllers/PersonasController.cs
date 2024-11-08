using Entities;
using GestionGeneral_ASP.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionGeneral_ASP.Controllers
{
    public class PersonasController : Controller
    {


        // GET: PersonasController
        [HttpPost]
        public ActionResult ListaPersonas()
        {
            //retorna la vista de personas
            return View(BL.ClaseListadosBL.listadoPersonasBL());
        }





        /// <summary>
        /// Metodo para la pagina para EDITAR la persona (Es una simulacion)
        /// </summary>
        /// <returns></returns>
        public IActionResult EditarPersona(ClsPersona perEditar)
        {
            // Obtener persona aleatoria
            ClsPersona persona = perEditar;

            // Obtener listado de departamentos
            //List<ClsDepartamento> departamentos = ;

            // Crear el ViewModel
            //ClsPersonaConListaDepartamentos miPersona = new ClsPersonaConListaDepartamentos(persona, departamentos);

            //retornamos la vista con la persona del ViewModel
            return View();
        }










    }
}
