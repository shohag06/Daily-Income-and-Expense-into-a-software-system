using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWork
{
    class Promotion
    {
        public Employee Employee { get; private set; }
        public string Date { get; private set; }

        public void PromoteEmployee(string employeeCode, Designation designation)
        {
            Employee = Global.GetEmployeeByCode(employeeCode);
            Employee.Designation = designation;
        }
    }
}
