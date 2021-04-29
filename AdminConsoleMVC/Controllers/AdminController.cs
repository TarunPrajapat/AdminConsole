using BoLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminConsoleMVC.Controllers
{
    public class AdminController : Controller
    {
        BaLayer.BaLayerDataAccess dataAccess = new BaLayer.BaLayerDataAccess();
        // GET: Admin
        public ActionResult Index()
        {
            
            return View(dataAccess.GetAdmins());
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(AdminModel adminModel)
        {
        
                    dataAccess.InsertAdmin(adminModel);
                    return RedirectToAction("Index");
        }
        public ActionResult Login()
        {
            return View();
        }

    }
}