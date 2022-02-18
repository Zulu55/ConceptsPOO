namespace ConceptsPOO
{
    public class Invoice : IPay
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public float Quantity { get; set; }

        public decimal GetValueToPay()
        {
            return Price * (decimal)Quantity;
        }

        public override string ToString()
        {
            return $"{Id} - {Description}" +
                $"\n\tPrice........: {Price:C2}" +
                $"\n\tQuantity.....: {Quantity:N2}" +
                $"\n\tValue........: {GetValueToPay():C2}";

        }
    }
}
