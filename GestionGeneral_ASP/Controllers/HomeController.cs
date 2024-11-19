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

        // GET: PersonaController/Details/5
        public ActionResult Detalles(int id)
        {
            List<ClsPersona> miListadoVista = BL.ClaseListadosBL.listadoPersonasBL();

            ClsPersona per = miListadoVista.FirstOrDefault(p => p.Id == id);

            return View(per);
        }


        // POST: PersonaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaController/Edit/5
        public ActionResult Editar(int id)
        {


            List<ClsPersona> miListadoVista = BL.ClaseListadosBL.listadoPersonasBL();

            ClsPersona per= miListadoVista.FirstOrDefault(p => p.Id == id);

            return View(per);
        }

        // POST: PersonaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(int id, IFormCollection collection)
        {
            List<ClsPersona> miListadoVista = BL.ClaseListadosBL.listadoPersonasBL();

            ClsPersona per = miListadoVista.FirstOrDefault(p => p.Id == id);

            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(per);
            }
        }

        // GET: PersonaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



    }
}
