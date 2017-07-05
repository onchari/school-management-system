using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcAdminTemplate.Models;

namespace MvcAdminTemplate.Controllers
{
    public class SchoolController : Controller
    {
        //
        // GET: /School/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Parents()
        {
            using (merry_cliff_academyEntities db = new merry_cliff_academyEntities())
            {
                return View(db.parents.ToList());
            }
           
        }

    }
}
