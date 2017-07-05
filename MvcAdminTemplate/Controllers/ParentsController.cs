using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcAdminTemplate.Models;

namespace MvcAdminTemplate.Controllers
{
    public class ParentsController : Controller
    {
        //
        // GET: /Parents/
        private merry_cliff_academyEntities db = new merry_cliff_academyEntities();

        public ActionResult Index()
        {
            return View(db.parents.ToList());

        }

        //GET : /Parents/ParentsDetails
        public ActionResult ParentsDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            parent parentdetails = db.parents.Find(id);
            if (parentdetails == null)
            {
                return HttpNotFound();
            }
            return View(parentdetails);
        }
    }

   
}
