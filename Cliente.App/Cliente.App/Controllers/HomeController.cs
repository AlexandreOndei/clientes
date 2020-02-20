using Cliente.App.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cliente.App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult ListaClientes(string filtro)
        {
            var lista = APIRequests.GetClientes(filtro);
            return PartialView("_ListClientes", lista);
        }
    }
}