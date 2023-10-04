using System.Globalization;

namespace ConstructorDemo
{
    public class Product
    {
        private string name;
        private bool isOnSale = false;
        public Product()
        {
            Manufacturer = new Manufacturer("Rodea", "+3593434354545");
        }
        public Product(string name, decimal priceBGN, string description, string expirationDate, ProductType productType, double weightKgs) : this()
        {
            Name = name;
            PriceBGN = priceBGN;
            Description = description;
            ExpirationDate = DateTime.ParseExact(expirationDate, "dd-MM/yyyy", CultureInfo.InvariantCulture);
            ProductType = productType;
            WeightKgs = weightKgs;
        }
        public Product(string name, decimal priceBGN, string description, string expirationDate, ProductType productType, double weightKgs, Manufacturer manufacturer)
    : this(name, priceBGN, description, expirationDate, productType, weightKgs)
        {
            Manufacturer = manufacturer;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal PriceBGN { get; set; }
        public string Description { get; set; }
        public DateTime ExpirationDate { get; set; }
        public ProductType ProductType { get; set; }
        public double WeightKgs { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public void SetThisProductOnSale()
        {
            isOnSale = true;
        }
        public void PrintData()
        {
            if (isOnSale)
            {
                Console.WriteLine("HOT - DEALS - BLACK FRIDAY");
            }
            Console.WriteLine($"Details about Product: {Name}");
            Console.WriteLine(new string('=', 20));
            Console.WriteLine($"Type of Product: {ProductType.ToString()}");
            Console.WriteLine($"Weight of Product: {WeightKgs * 1000} grams");
            Console.WriteLine($"Expires On: {ExpirationDate.ToString("dd (dddd).MM[yyyy]")} grams");
            var timeFrame = (ExpirationDate - DateTime.UtcNow);
            Console.WriteLine($"Expires After: {timeFrame.Days} days");
            Console.WriteLine(new string('=', 15));
            Console.WriteLine($"About the product Info: {Description}");
            Console.WriteLine(new string('=', 15));
            Console.WriteLine($"This product was manufactured by: {Manufacturer.Name}");
            Console.WriteLine(new string('=', 20));
        }
    }
}