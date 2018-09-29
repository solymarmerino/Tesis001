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

        public ActionResult DiagnosticoSOAP()
        {
            ViewBag.Message = "Diagnostico SOAP";

            return View();
        }
                
        public ActionResult ResultadoExamenMedico()
        {
            ViewBag.Message = "Resultados examenes";

            return View();
        }

        public ActionResult ProformaExamenMedico()
        {
            ViewBag.Message = "Proforma examenes";

            return View();
        }
                
        public ActionResult CertificadoMedico()
        {
            ViewBag.Message = "Certificado médico";

            return View();
        }
    }
}