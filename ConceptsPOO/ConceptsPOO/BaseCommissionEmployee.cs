using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConceptsPOO
{
    public class BaseCommissionEmployee : CommissionEmployee
    {
        public decimal Salary { get; set; }

        public override decimal GetValueToPay()
        {
            return base.GetValueToPay() + Salary;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tSalary......: {$"{Salary:C2}",15}";
        }
    }
}