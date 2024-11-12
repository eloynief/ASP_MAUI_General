using Entities;
using GestionGeneral_ASP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GestionGeneral_ASP.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        // GET: PersonasController
        //[HttpPost]
        public ActionResult ListadoPersonas()
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
