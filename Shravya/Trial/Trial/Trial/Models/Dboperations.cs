using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Trial.Models;

namespace JQuery.Models
{
    public class Dboperations
    {
        db1Entities T = null;
        public Dboperations()
        {
            T = new db1Entities();
        }
        public List<EMPDATA> FetchEmp()
        {
            var E = from E1 in T.EMPDATAs
                    select E1;
            List<EMPDATA> L = E.ToList();
            return L;
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

        public string DeleteRecord(int eno)
        {
            var E1 = from D1 in T.EMPDATAs
                          where D1.EMPNO == eno
                          select D1;

            
            try
            {
                EMPDATA DEL = E1.First();
                T.EMPDATAs.Remove(DEL);
                T.SaveChanges();
                return "Record deleted";
            }
            catch(Exception D)
            {
                return "No record found";
            }

        }
        public string UpdateEmp(EMPDATA E)
        {
            var E1 = from E2 in T.EMPDATAs
                     where E2.EMPNO == E.EMPNO
                     select E2;
            try
            {

                EMPDATA emp = E1.First();
                emp.ENAME = E.ENAME;
                emp.JOB = E.JOB;
                emp.MGR = E.MGR;
                emp.SAL = E.SAL;
                emp.COMM = E.COMM;
                emp.DEPTNO = E.DEPTNO;
                emp.Grade = E.Grade;
                T.SaveChanges();
                return "recored updated";
            }
            catch( Exception D)
            {
                return "No record with the given Employee number";
            }


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