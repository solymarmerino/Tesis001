using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tesis001.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult IngresarCita()
        {
            ViewBag.Message = "Ingresar Cita";

            return View();
        }

        public ActionResult NuevaHistoriaClinica()
        {
            ViewBag.Message = "Nueva Historia Clinica";

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

        public ActionResult Peso()
        {
            ViewBag.Message = "Peso";

            return View();
        }
               
        public ActionResult PedidoExamen()
        {
            ViewBag.Message = "Pedido Examen";

            return View();
        }

        public ActionResult PresionArterial()
        {
            ViewBag.Message = "Presion Arterial";

            return View();
        }

        public ActionResult Talla()
        {
            ViewBag.Message = "Talla";

            return View();
        }

        public ActionResult Temperatura()
        {
            ViewBag.Message = "Temperatura";

            return View();
        }

        public ActionResult FrecuenciaCardiaca()
        {
            ViewBag.Message = "Frecuencia Cardiaca";

            return View();
        }


        public ActionResult FrecuenciaRespiratoria()
        {
            ViewBag.Message = "Frecuencia Respiratoria";

            return View();
        }

        public ActionResult DiagnosticoSOAP()
        {
            ViewBag.Message = "DiagnosticoSOAP";

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

        public ActionResult PagosPersonal()
        {
            ViewBag.Message = "Pagos Personal";

            return View();
        }

        public ActionResult Egreso()
        {
            ViewBag.Message = "Egreso";

            return View();
        }

        public ActionResult Ingreso()
        {
            ViewBag.Message = "Ingreso";

            return View();
        }

        public ActionResult InformeContable()
        {
            ViewBag.Message = "Informe Contable";

            return View();
        }

        public ActionResult Inventario()
        {
            ViewBag.Message = "Inventario";

            return View();
        }

        public ActionResult Facturacion()
        {
            ViewBag.Message = "Facturacion";

            return View();
        }

        public ActionResult IngresoPersonal()
        {
            ViewBag.Message = "Ingreso Personal";

            return View();
        }

        public ActionResult ListaPersonal()
        {
            ViewBag.Message = "Lista Personal";

            return View();
        }

        public ActionResult BuscarPaciente()
        {
            ViewBag.Message = "Buscar Paciente";

            return View();
        }
    }
}