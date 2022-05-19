
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Web;  
using System.Web.Mvc;  
using StaffingProject2.Models;  
  
namespace StaffingProject2.Controllers
{
    public class StaffingController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Registration obj)

        {
            if (ModelState.IsValid)
            {
                StaffingEntities1 db = new StaffingEntities1();
                db.Registrations.Add(obj);
                db.SaveChanges();
            }
            return View(obj);
        }
    }
}