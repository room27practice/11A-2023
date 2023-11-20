namespace Furnitures
{
    public class Furniture
    {
        public int Id { get; set; }
        public Furniture(string name, decimal price)
        {
            Name = name;
            Price = price;
            Weight = -1;
            Manufacturer = "StoreShop";
            Material = Material.Unidentified;
        }

        public Furniture(string name, decimal price, double weight, string manufacturer, Material material) : this(name, price)
        {
            Weight = weight;
            Manufacturer = manufacturer;
            Material = material;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public double Weight { get; set; }
        public string Manufacturer { get; set; }
        public Material Material { get; set; }
    }
}
