using DigitalKale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DigitalKale.Controllers
{
    public class LoginController : Controller
    {


        DijitalKaleDBEntities db = new DijitalKaleDBEntities();
        public ActionResult Index()
        {

            var model = db.Author.ToList();
            return View();
        }
    }
}