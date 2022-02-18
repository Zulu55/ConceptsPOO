using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }

        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tValue to pay.........: {$"{GetValueToPay():C2}", 18}";
        }
    }
}

