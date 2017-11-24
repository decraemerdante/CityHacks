using Fitter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fitter.Controllers
{
    public class HomeController : Controller
    {
        ListModelViews mv = new ListModelViews();
        CoachDBEntities1 db = new CoachDBEntities1();
        public ActionResult Index()
        {
            ListModelViews mv = new ListModelViews();
            
            return View(mv);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult Info(int id)
        {
            
            ViewBag.Message = "Your contact info.";

            foreach(var item in mv.ModelSports)
            {

                if(item.SportId == id)
                {
                    return View(item);
                }
            }

            return View();
        }
    }
}