using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CvWeb.Models.Entitiy;

namespace CvWeb.Controllers
{
    public class DefaultController : Controller
    {

        // GET: Default
        DbWebPageEntities1 db = new DbWebPageEntities1 ();
        public ActionResult Index()
        {
            var values = db.about_tb.ToList();
            return View(values);
        }

        public PartialViewResult Experience()
        {
            var values = db.experience_tb.ToList();
            return PartialView(values);
        }
        public PartialViewResult Education()
        {
            var values = db.education_tb.ToList();
            return PartialView(values);
        }
        public PartialViewResult Skill()
        {
            var values = db.Skill_tb.ToList();
            return PartialView(values);
        }
        public PartialViewResult Hobies()
        {
            var values = db.hobies_tb.ToList();
            return PartialView(values);
        }

        [HttpGet]
        public PartialViewResult Contact()
        {
        
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Contact(contact_tb c)
        {
            c.date = DateTime.Now.ToShortDateString();
            db.contact_tb.Add(c);
            db.SaveChanges();
            return PartialView();
        }
    }
}