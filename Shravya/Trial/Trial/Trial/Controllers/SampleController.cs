using JQuery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trial.Models;

namespace JQuery.Controllers
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
            Dboperations D = new Dboperations();
            List<EMPDATA> L = D.FetchEmp();
            return Json(L, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AjaxEx2()
        {
            return View();
        }

        public JsonResult FetchDept(int DNO)
        {
            Dboperations D = new Dboperations();
            List<EMPDATA> L = D.FetchDepartment(DNO);
            return Json(L,JsonRequestBehavior.AllowGet);
        }

        public ActionResult Insert()
        {
            return View();
        }
        public JsonResult InsertEmp(EMPDATA E)
        {
            Dboperations D = new Dboperations();
            string S = D.Insert(E);
            return Json(S, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DeleteRecord()
        {
            return View();
        }

        public JsonResult DeleteEmp(int Empno)
        {
            Dboperations D = new Dboperations();
            string S = D.DeleteRecord(Empno);
            return Json(S, JsonRequestBehavior.AllowGet);

        }

       

        
        public ActionResult UpdateEmp()
        {
            return View();
        }
        
        public JsonResult UpdateEmpDb(EMPDATA E)
        {
            Dboperations D = new Dboperations();
            string S = D.UpdateEmp(E);
            return Json(S, JsonRequestBehavior.AllowGet);
        }

        public ActionResult FetchEmp()
        {
            return View();
        }
        public JsonResult Display(int Empno)
        {
            Dboperations D = new Dboperations();
            EMPDATA E = D.fetchEmployee(Empno);
            return Json(E, JsonRequestBehavior.AllowGet);

        }

    }
}