﻿using MangaList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MangaList.Controllers
{
    public class HomeController : Controller
    {
    
        public ActionResult Started_list()
        {
            List<Elements> elements = new List<Elements>();

            elements.Add(new Elements()
            {
                login = "jackkim",
                password = "1234"
        });




            return View(elements);
        }


        public ActionResult Authorization()
        {
            List<Elements> elements = new List<Elements>();

            elements.Add(new Elements()
            {
                login = "fuckoff",
                password = "dddddd"
            });



            return View(elements);
        }

        public ActionResult Finished_list()
        {
            return View();
        }
    }
}