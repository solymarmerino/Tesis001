using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tesis001.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CitaMedicaListar()
        {
            ViewBag.Message = "Listar Citas Médicas.";

            return View();
        }

        public ActionResult SignosVitales()
        {
            ViewBag.Message = "Signos Vitales";

            return View();
        }

        public ActionResult HistoriaClinica()
        {
            ViewBag.Message = "Historia Clinica";

            return View();
        }

        public ActionResult Temperatura()
        {
            ViewBag.Message = "Temperatura";

            return View();
        }

        public ActionResult PresionArterial()
        {
            ViewBag.Message = "Presión Arterial";

            return View();
        }

        public ActionResult FrecuenciaCardiaca()
        {
            ViewBag.Message = "FrecuenciaCardiaca";

            return View();
        }

        public ActionResult FrecuenciaRespiratoria()
        {
            ViewBag.Message = "FrecuenciaRespiratoria";

            return View();
        }

        public ActionResult Peso()
        {
            ViewBag.Message = "Peso";

            return View();
        }

        public ActionResult Talla()
        {
            ViewBag.Message = "Talla";

            return View();
        }

        public ActionResult PedidoExamen()
        {
            ViewBag.Message = "Pedido Examen";

            return View();
        }

    }
}