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

    }
}
