using Entities;
using GestionGeneral_ASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
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
            List<ClsPersona> miListadoVista=BL.ClaseListadosBL.listadoPersonasBL();
            if (miListadoVista == null)
            {
                return View("MiError");
            }
            //retorna la vista de personas
            return View(miListadoVista);
        }




        // GET: PersonasController
        public ActionResult Conectarse(Boolean comprobar)
        {
            string estado = "Presione el botón para comprobar la conexión.";

            if (comprobar)
            {
                SqlConnection sqlConnection = DAL.EnlaceBBDD.getConexion();

                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    estado = "Conexión exitosa con la base de datos.";
                    sqlConnection.Close();
                }
                else
                {
                    estado = "No se pudo conectar con la base de datos.";
                }
            }

            ViewBag.estado = estado;
            return View();
        }



        // GET: Personas/Create
        public IActionResult Create()
        {
            // Devuelve la vista para crear una nueva persona
            return View();
        }

        // POST: Personas/Create
        [HttpPost]
        public IActionResult Create(ClsPersona nuevaPersona)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Llama a la capa de lógica de negocio para insertar la persona
                    bool resultado = BL.ClaseListadosBL.AgregarPersonaBL(nuevaPersona);

                    if (resultado)
                    {
                        return RedirectToAction(nameof(ListadoPersonas));
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Error al guardar la persona: " + ex.Message);
                }
            }

            // Si algo falla, devuelve la vista con los datos proporcionados por el usuario
            return View(nuevaPersona);
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
