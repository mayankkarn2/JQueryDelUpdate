using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assessment.Models
{
	public class DBoperations
	{
		TrainingEntities T = null;
		public DBoperations()
		{
			T = new TrainingEntities();
		}
		public string UpdateEmp(EMPDATA E)
		{
			var E1 = from E2 in T.EMPDATAs
					 where E2.EMPNO == E.EMPNO
					 select E2;
			try
			{
				EMPDATA emp = E1.First();
				emp.JOB = E.JOB;
				emp.MGR = E.MGR;
				emp.SAL = E.SAL;
				emp.COMM = E.COMM;
				emp.DEPTNO = E.DEPTNO;
				emp.GRADE = E.GRADE;
				T.SaveChanges();
				return "Updated!";
			}
			catch(Exception Ex)
			{
				return "No such record exists!";
			}
			
		}
		public string DeleteEmp(int DelEmp)
		{
			var D = from D1 in T.EMPDATAs
					where D1.EMPNO == DelEmp
					select D1;
			try
			{
				EMPDATA demp = D.First();
				T.EMPDATAs.Remove(demp);
				T.SaveChanges();
				return "Deleted!";
			}
			catch(Exception E)
			{
				return "No such record exists!";
			}

		}
	}
}