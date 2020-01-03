using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.ViewModels;

namespace WebApplication.Controllers
{
    public class LageController : Controller
    {
        // GET: Lage
        public ActionResult Lage()
        {
            PrivateInstallationVM model = new PrivateInstallationVM();
            return View("Lage", model);

        }
        [HttpPost]
        public ActionResult Lage(PrivateInstallationVM model)
        {
            DB_NEEEntities context = new DB_NEEEntities();
            context.Lage.Add(new Lage()
            {
                Strasse = model.strasse,
                Nr = model.no,
                PLZ = model.postleitzahl,
                Stadt = model.stadt
            });
            context.SaveChanges();
            return View("Lage", model);

        }
    }
}