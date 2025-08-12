namespace BiologicsCafe.Models
{
    public class OrderItem
    {
        public MenuItem Item { get; set; }
        public int Quantity { get; set; }

        public decimal TotalPrice => Item.Price * Quantity;
    }
}
