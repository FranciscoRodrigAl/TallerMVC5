using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TallerMVC5.Models;

namespace TallerMVC5.Controllers
{
    public class ContactController : Controller
    {
        
        [HttpGet]
        public ActionResult Index()
        {
            var model = new Contacto();
            return View(model);
        }

        [HttpGet]
        public ActionResult AjaxIndex()
        {
            var model = new Contacto();
            return View(model);
           
        }

        [HttpPost]
        public ActionResult Index(Contacto model)
        {
            if (model == null)
                model = new Contacto();

            if (ModelState.IsValid)
            {

            }

            return View(model);
        }

        [HttpPost]
        public ActionResult AjaxIndex(Contacto model)
        {
            if (model == null)
                throw new ArgumentException("El modelo viene nulo", "Contacto");

            if (ModelState.IsValid)
            {

            }

            return View(model);

        }
    }
}