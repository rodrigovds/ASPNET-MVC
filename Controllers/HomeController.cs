﻿using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_GerenciadorDeConteudo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.Paginas = new Pagina().Lista();
            return View();
        }


        public ActionResult About(int id)
        {
            ViewBag.Message = "Your application description page.";
            return View();
        
        }

       public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}