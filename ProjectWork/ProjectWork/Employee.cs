using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWork
{
    class Employee
    {
        public string Code { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string ContactNo { get; private set; }
        public string Address { get; private set; }
        public Designation Designation { get; set; }
        public DateTime JoinedDate { get; private set; }

        private List<Promotion> promotions;

        public Employee(string code, string name, string email, string contactNo, string address, Designation designation, DateTime joinedDate)
        {
            Code = code;
            Name = name;
            Email = email;
            ContactNo = contactNo;
            Address = address;
            Designation = designation;
            JoinedDate = joinedDate;
        }
        public void PromoteEmployee(Designation desingnation)
        {

        }
        public void AddPromotion(Promotion promotion)
        {
            promotions = new List<Promotion>();
            promotions.Add(promotion);
        }
        public List<Promotion> GetPromotions()
        {
            return promotions;
        }
    }
}
