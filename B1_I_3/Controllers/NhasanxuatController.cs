using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using B1_I_3.Models;

namespace B1_I_3.Controllers
{
    public class NhasanxuatController : Controller
    {
        QLBHContext db = new QLBHContext();

        public IActionResult Index()
        {
            //var kq = from a in db.Nhasanxuat
            //         orderby a.Tennsx descending
            //         select a;
            //ViewBag.nsx = kq;

            ViewBag.nsx = db.Nhasanxuat;
            return View();
        }
        [HttpGet]
        public ActionResult them()
        {
            return View();
        }
        [HttpPost]
        public ActionResult them(Nhasanxuat n)
        {
            db.Nhasanxuat.Add(n);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult sua(string id)
        {            
            Nhasanxuat nsx = db.Nhasanxuat.Find(id);
            ViewBag.nsx = nsx;
            return View(nsx);
        }
        [HttpPost]
        public ActionResult sua()
        {
            string ma = Request.Form["mansx"].ToString();
            Nhasanxuat nsx = db.Nhasanxuat.Find(ma);
            nsx.Tennsx = Request.Form["tennsx"].ToString();
            nsx.Diachi = Request.Form["diachi"].ToString();            
            db.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult xoa(string id)
        {
            Nhasanxuat n = db.Nhasanxuat.Find(id);
            ViewBag.nsx = n;
            return View(n);
        }
        [HttpPost, ActionName("xoa")]
        public ActionResult xoa_Post(string id)
        {
            Nhasanxuat n = db.Nhasanxuat.Find(id);
            if (n != null)
            {
                db.Nhasanxuat.Remove(n);
                db.SaveChanges();
            }
            return RedirectToAction("index");            
        }
    }
}