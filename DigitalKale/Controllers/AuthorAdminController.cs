using DigitalKale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DigitalKale.Controllers
{
    public class AuthorAdminController : Controller
    {
       DijitalKaleDBEntities db = new DijitalKaleDBEntities();
        public ActionResult Index()
        {
            return View(db.Author.ToList()) ;
        }
    }
}