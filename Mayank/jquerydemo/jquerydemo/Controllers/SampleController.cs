using jquerydemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jquerydemo.Controllers
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
            Dboperation D = new Dboperation();
            List<EMPDATA> L = D.FetchEmp();
            return Json(L, JsonRequestBehavior.AllowGet);
            
        }

        public ActionResult AjaxEx2()
        {
            return View();        
        }

        public JsonResult Fetchdept(int DNO)
        {
            Dboperation D = new Dboperation();
            List<EMPDATA> L = D.FetchDept(DNO);
            return Json(L, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AjaxEx3()
        {
            return View();
        }

        public JsonResult deleteEmp(int Empno)
        {
            Dboperation D = new Dboperation();
            string L = D.deleteEmp(Empno);
            return Json(L, JsonRequestBehavior.AllowGet);
        }

        public ActionResult update()
        {
            return View();
        }

        public JsonResult updateEmp(EMPDATA E)
        {
            Dboperation D = new Dboperation();
            string S = D.updateEmp(E);
            return Json(S, JsonRequestBehavior.AllowGet);
        }

    }
}