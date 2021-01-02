using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWork
{
    class Salary
    {
        public double SalaryBasic { get; private set; }
        public double HouseRent { get; private set; }
        public double MedicalAmount { get; private set; }

        public Salary(double salaryBasic, double houseRent, double medicalAmount)
        {
            SalaryBasic = salaryBasic;
            HouseRent = houseRent;
            MedicalAmount = medicalAmount;
        }
        public double TotalSalary()
        {
            return SalaryBasic + HouseRent + MedicalAmount;
        }
    }
}
