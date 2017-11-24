using Fitter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fitter.Controllers
{
    public class locationsController : Controller
    {
        CoachDBEntities db;

        public locationsController()
        {
            db = new CoachDBEntities();
        }

        // GET: locations
        public ActionResult Index()
        {
            
            return View(model: db.locations.ToList());
        }
    }
}