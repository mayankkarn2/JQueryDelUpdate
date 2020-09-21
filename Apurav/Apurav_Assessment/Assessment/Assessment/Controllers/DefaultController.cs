using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assessment.Models;

namespace Assessment.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UpdateEmp()
        {
            return View();
        }
        public JsonResult UpdateEmpDB(EMPDATA E)
        {
            DBoperations D = new DBoperations();
            string S = D.UpdateEmp(E);
            return Json(S, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Delete()
        {
            return View();
        }
        public JsonResult DeleteEmp(int Empno)
        {
            DBoperations D = new DBoperations();
            string L = D.DeleteEmp(Empno);
            return Json(L, JsonRequestBehavior.AllowGet);
        }
    }
}