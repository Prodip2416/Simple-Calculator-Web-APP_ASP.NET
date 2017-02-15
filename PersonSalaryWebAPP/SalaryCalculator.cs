using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonSalaryWebAPP
{
    [Serializable]
    public class SalaryCalculator
    {
        public string EmployeeName { get; set; }
        public double BasicAmount { get; set; }
        public double HouseRent { get; set; }
        public double MedicalAllowance { get; set; }

        public double ShowMeSalary()
        {
            double result = BasicAmount +(BasicAmount* HouseRent/100) +(BasicAmount * MedicalAllowance/100);
            return result;
        }
        public SalaryCalculator(string name,double amount,double houseRent,double medicalAllowance):this()
        {
            EmployeeName = name;
            BasicAmount =amount;
            HouseRent = houseRent ;
            MedicalAllowance = medicalAllowance;
        }
        public SalaryCalculator()
        {
          
        }
    }
}