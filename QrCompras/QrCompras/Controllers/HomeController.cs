using br.com.fiap.QRCompras.Models;
using QRCompras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QrCompras.Controllers
{
    public class HomeController : Controller
    {
        static List<Promocoes> _promocoes = new List<Promocoes> {
           new Promocoes{Mercado = "Andorinha", qtd = 10, qtdDisponivel = 9, Valor = 19.90},
           new Promocoes{Mercado = "Bergamini", qtd = 15, qtdDisponivel = 7, Valor = 17.00},
           new Promocoes{Mercado = "Andorinha", qtd = 10, qtdDisponivel = 6, Valor = 9.90}
        };

        public ActionResult Index()
        {
            return View(_promocoes);
        }

        public ActionResult SobreNos()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Contato()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contato(FaleConosco contato)
        {
            ViewBag.successMessage = contato.Assunto;
            //Todo contato param
            return View();
        }

        [HttpGet]
        public ActionResult _PartialPromocoes()
        {
            return View(_promocoes);
        }
    }
}