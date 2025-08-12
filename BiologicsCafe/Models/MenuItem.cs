
namespace BiologicsCafe.Models
{

    public enum ItemType { Food, Drink }
    public class MenuItem
    {
        public string Name { get; set; }
        public ItemType Type { get; set; }
        public decimal Price { get; set; }
    }
}
