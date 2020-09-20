using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jquerydemo.Models
{
    public class Dboperation
    {
		trainingEntities T = null;
		public Dboperation()
		{
			T = new trainingEntities();
		}
		public List<EMPDATA> FetchEmp()
		{
			var E = from E1 in T.EMPDATAs
					select E1;
			List<EMPDATA> L = E.ToList();
			return L;
		}

		public List<EMPDATA> FetchDept(int deptno)
        {
			var D = from D1 in T.EMPDATAs
					where D1.DEPTNO == deptno
					select D1;
			List<EMPDATA> L = D.ToList();
			return L;
        }

		public string deleteEmp(int empno)
        {
			var D = from D1 in T.EMPDATAs
					where D1.EMPNO == empno
					select D1;
            try
            {
				EMPDATA del = D.First();
				T.EMPDATAs.Remove(del);
				T.SaveChanges();
				return "Employee Deleted";
			}

			catch(Exception E)
            {
				return "No data found";
			}
			
		}

		public string updateEmp(EMPDATA E)
        {
			var E1 = from E2 in T.EMPDATAs
					 where E2.EMPNO == E.EMPNO
					 select E2;
			try {
				EMPDATA emp = E1.First();
				emp.ENAME = E.ENAME;
				emp.COMM = E.COMM;
				emp.DEPTNO = E.DEPTNO;
				emp.JOB = E.JOB;
				emp.SAL = E.SAL;
				emp.grade = E.grade;
				emp.MGR = E.MGR;
				T.SaveChanges();
				return "recored updated";
			}
			catch(Exception Ex)
            {
				return "No record found";
            }
			
		}
	}
}