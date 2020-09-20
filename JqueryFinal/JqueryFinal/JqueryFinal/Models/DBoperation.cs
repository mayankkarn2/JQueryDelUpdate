using JqueryFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace JqueryExample.Models
{
    public class DBoperation
    { 
        TrainingEntities T = null;
        public DBoperation()
        {
            T = new TrainingEntities(); 
        }
        public List<EMPDATA> FetchEmp()
        {
            var E = from E1 in T.EMPDATAs
                    select E1;
            List<EMPDATA> L = E.ToList();
            return L;    
                //T.EMPDATAs.ToList();
        }
        public List<EMPDATA> FetchDepartment(int Deptno)
        {
            var D = from D1 in T.EMPDATAs
                    where D1.DEPTNO == Deptno
                    select D1;
            return D.ToList();
        }
        public string Insert(EMPDATA E)
        {
            try
            {
                T.EMPDATAs.Add(E);
                T.SaveChanges();
                return "1 record inserted";
            }
            catch (DbUpdateException D)
            {
                SqlException sql = (SqlException)D.GetBaseException();
                return sql.Message;
            }
            }

        public string Delete(int Empno)
        {
            try
            {
                var D = from D1 in T.EMPDATAs
                        where D1.EMPNO == Empno
                        select D1;

                EMPDATA delete = D.First();
                T.EMPDATAs.Remove(delete);
                T.SaveChanges();
                return "1 record deleted successfully";
            }
            catch
            {
                return "No record found";
            }
        }

        public string UpdateEmp(EMPDATA E)
        {
            try
            {
                var E1 = from E2 in T.EMPDATAs
                         where E2.EMPNO == E.EMPNO
                         select E2;

                EMPDATA emp = E1.First();
                emp.ENAME = E.ENAME;
                emp.grade = E.grade;
                emp.JOB = E.JOB;
                emp.SAL = E.SAL;
                emp.COMM = E.COMM;
                emp.DEPTNO = E.DEPTNO;

                T.SaveChanges();
                return "recored updated";
            }
            catch
            {
                return "please enter existing employee number";

            }
        }

        public EMPDATA getEmp(int Empno)
        {
            var E = from E1 in T.EMPDATAs
                    where E1.EMPNO == Empno
                    select E1;
            return E.First();
        }




        public EMPDATA fetchEmployee(int Empno)
        {
            var E = from E1 in T.EMPDATAs
                    where E1.EMPNO == Empno
                    select E1;
            return E.First();
        
        }


    }
}