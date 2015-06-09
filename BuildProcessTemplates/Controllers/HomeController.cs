﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.SomeValue = "From the Action method!";

            var cars = HelloModel.GetCars();

            return View(cars);
        }
    }
}