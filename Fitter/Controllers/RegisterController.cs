using Fitter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fitter.Controllers
{
    public class RegisterController : Controller
    {
        CoachDBEntities db = new CoachDBEntities();
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
    }
}