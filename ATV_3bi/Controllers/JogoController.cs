﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ATV_3bi.Models;

namespace ATV_3bi.Controllers
{
    public class JogoController : Controller
    {
        // GET: Jogo
        public ActionResult IndexJogo()
        {
            var jogo = new Jogo();
            return View(jogo);
        }
        [HttpPost]
        public ActionResult IndexJogo(Jogo jogo)
        {
            if (ModelState.IsValid)
            {
                return View("ListarJogo", jogo);
            }
            return View(jogo);
        }
        public ActionResult ListarJogo(Jogo jogo)
        {
            return View(jogo);
        }
    }
}