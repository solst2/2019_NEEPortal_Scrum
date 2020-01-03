using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.ViewModels;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Lage() {
            return View();
        }
        [HttpPost]
        public ActionResult Lage(PrivateInstallationVM vm)
        {
            DB_NEEEntities context = new DB_NEEEntities();
            context.Lage.Add(new Lage()
            {
                Strasse = vm.strasse,
                Nr = vm.no,
                PLZ = vm.postleitzahl,
                Stadt = vm.stadt
            });
            context.SaveChanges();
            return View("Lage", vm);
            //return RedirectToAction("Art", "Home", vm);
            //return View(vm);
        }

       
        public ActionResult Art(PrivateInstallationVM vm) {
            return View(vm);
        }
        public ActionResult Ausrichtung(PrivateInstallationVM vm) {
            return View(vm);
        }
        public ActionResult Oberfläche(PrivateInstallationVM vm) {
            return View();
        }
    }
}