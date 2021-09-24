using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ATV_3bi.Models;

namespace ATV_3bi.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult IndexCli()
        {
            var cliente = new Cliente();
            return View(cliente);
        }

        Action ac = new Action();

        [HttpPost]

        public ActionResult IndexCli(Cliente cliente)
        {
            ac.CadastrarCliente(cliente);
            return View(cliente);
        }
        /*public ActionResult IndexCli(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                return View("ListarCli", cliente);
            }
            return View(cliente);
        }
        public ActionResult ListarCli(Cliente cliente)
        {
            return View(cliente);
        }*/
    }
}