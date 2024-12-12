using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using B1_I_3.Models;

namespace B1_I_3.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    return "Hello from Index";
        //}

        public IActionResult Index(int id)
        {
            IndexModel model = new IndexModel();
            model.Message="Chao cac ban " + id;
            ViewBag.n = "Hi ViewBag";
            //var n = Request.Form["ten"].ToString();

            return View(model);
        }

    }
}