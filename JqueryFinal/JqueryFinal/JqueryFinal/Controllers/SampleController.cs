using JqueryExample.Models;
using JqueryFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JqueryExample.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AjaxEx()
        {
            return View();
        }
        public JsonResult Fetch()
        {
            DBoperation D = new DBoperation();
            List<EMPDATA> L=D.FetchEmp();
            return Json(L, JsonRequestBehavior.AllowGet);
        }
        public ActionResult AjaxEx2()
        {
            return View();
        }
        public JsonResult FetchDept(int DNO)
        {
            DBoperation D = new DBoperation();
          List<EMPDATA> L= D.FetchDepartment(DNO);
            return Json(L,JsonRequestBehavior.AllowGet);
        }

        public ActionResult Insert()
        {
            return View();
        }
        public JsonResult InsertEmp(EMPDATA E)
        {
            DBoperation D = new DBoperation();
            string S = D.Insert(E);
            return Json(S,JsonRequestBehavior.AllowGet);
        }


        public ActionResult UpdateEmp()
        {
            return View();
            //Json(E, JsonRequestBehavior.AllowGet);
        }

        public JsonResult UpdateEmpDb(EMPDATA E)
        {
            DBoperation D = new DBoperation();
            string I = D.UpdateEmp(E);
            return Json(I, JsonRequestBehavior.AllowGet);
        }




        public ActionResult Delete()
        {
            return View();
        }

        public JsonResult deleteEmployee(int Empno)
        {
            DBoperation D = new DBoperation();
            string S = D.Delete(Empno);
            return Json(S, JsonRequestBehavior.AllowGet);
        }


        public ActionResult FetchEmp()
        {
            return View();
        }
        public JsonResult Display(int Empno)
        {
            DBoperation D = new DBoperation();
            EMPDATA E=D.fetchEmployee(Empno);
            return Json(E, JsonRequestBehavior.AllowGet);

        }

    }
}