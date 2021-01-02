using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWork
{
    static class Global
    {
        private static List<Designation> __designations = new List<Designation>();
        private static List<Employee> __employess = new List<Employee>();
        public static List<Designation> Designations{
            get { return __designations;  }
            set { __designations = value; }
        }
        public static List<Employee> Employess
        {
            get { return __employess; }
            set { __employess = value; }
        }
        public static Designation GetDesignationByTitle(string title)
        {
            foreach (Designation designation in Designations)
            {
                if (designation.Title == title)
                {
                    return designation;
                }
            }
            return null;
        }
        public static Employee GetEmployeeByCode(string code)
        {
            foreach (Employee employee in Employess)
            {
                if (employee.Code == code)
                {
                    return employee;
                }
            }
            return null;
        }
        public static bool HasDesignation(string code)
        {
            foreach (Designation designation in Designations)
            {
                if (designation.Code == code)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool HasEmployee(string codeOrEmail)
        {
            foreach (Employee employee in Employess)
            {
                if (employee.Code == codeOrEmail || employee.Email == codeOrEmail)
                {
                    return true;
                }
            }
            return false;
        }

        public static void ResignEmployee(string code)
        {
            Employess.RemoveAll(a => a.Code == code);
        }
    }
}
