namespace ConceptsPOO
{
    public class HourlyEmployee : Employee
    {
        public float Hours { get; set; }

        public decimal HourValue { get; set; }

        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tHours................: {$"{Hours:N2}",18}" +
                $"\n\tHour value...........: {$"{HourValue:C2}",18}" +
                $"\n\tValue to pay.........: {$"{GetValueToPay():C2}",18}";
        }
    }
}
