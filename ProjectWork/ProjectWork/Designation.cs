using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWork
{
    class Designation
    {
        public string Title { get; private set; }
        public string Code { get; private set; }
        public Salary Salary { get; private set; }

        public Designation(string title, string code, double salaryBasic, double houseRent, double medicalAmount)
        {
            Title = title;
            Code = code;
            Salary = new Salary(salaryBasic, houseRent, medicalAmount);
        }
    }
}
