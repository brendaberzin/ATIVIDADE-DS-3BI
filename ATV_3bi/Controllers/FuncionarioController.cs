using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ATV_3bi.Models;

namespace ATV_3bi.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult IndexFunc()
        {
            var funcionario = new Funcionario();
            return View(funcionario);
        }
        [HttpPost]
        public ActionResult IndexFunc(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                return View("Listar", funcionario);
            }
            return View(funcionario);
        }
        public ActionResult Listar(Funcionario funcionario)
        {
            return View(funcionario);
        }
    }
}