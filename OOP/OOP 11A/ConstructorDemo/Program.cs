using System.Globalization;

namespace ConstructorDemo
{
    internal class Program
    {
        static void Main()
        {
            #region SpisuciPrimer
            //var listNums = new List<int>();

            //listNums.Add(1);
            //listNums.Add(5);
            //listNums.Add(3);


            //var listNums2 = new List<int>() { 1,5,3};
            //listNums2.Add(31);
            #endregion
            var man = new Manufacturer();
            man.Name = "Georgi";
            var man2 = new Manufacturer("Atanas", "+359-953-67-23");
            var man3 = new Manufacturer("Hristiqn", "+359888753", "vuzdoh.com", "hristiqn@abv.bg");
            List<Manufacturer> proizvoditeli = CreateInitialManufacturersList();

            // Food, BeverageAlcohol, BeverageNonAlcohol, CleaningSupplies, Clothing
            proizvoditeli.Add(new Manufacturer());
            proizvoditeli.Add(new Manufacturer("Hristiqn", "+359888753", "vuzdoh.com", "hristiqn@abv.bg") { Telephone = "0995" });

            var products = new List<Product>();
            products.Add(new Product()
            {
                Name = "Prah za prane LEX",
                Description = "Hitriqt nachin za prane Lex, Rex i t.n...",
                PriceBGN = 12.43m,
                WeightKgs = 2,
                ProductType = ProductType.CleaningSupplies,
                Manufacturer = proizvoditeli[0],
                ExpirationDate = DateTime.ParseExact("02-10/2024", "dd-MM/yyyy", CultureInfo.InvariantCulture)
            });
            products.Add(new Product("Hrana za kucheta Kucharek", 5.76m, "Granuli leko vlajni lesni za duvchene", "24-12/2023", ProductType.AnimalFood, 3.00));
            PrintInfoAboutProducts(products);

            var animal1 = new Animal() { Name = "Sharo" };
            var animal2 = new Animal("Alex", 3);

            animal1.ProductsUsed.Add(products[0]);
            animal2.ProductsUsed.Add(products[1]);

        }

        private static void PrintInfoAboutProducts(List<Product> products)
        {
            foreach (var p in products.OrderByDescending(x => x.Description.Length))
            {
                p.PrintData();
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public static List<Manufacturer> CreateInitialManufacturersList()
        {
            var proizvoditeli = new List<Manufacturer>()
            {
                new Manufacturer()
                    {
                    Id = 1,
                    Name = "Lex",
                    Telephone = "0883368643",
                    Email = "lex@yahoo.com",
                    WebSiteURL = "www.lex-company.com"
                     },
                new Manufacturer()
                    {
                    Id = 2,
                    Name = "Krasi",
                    Telephone = "0883368999",
                    Email = "krasi-white-magic@abv.bg",
                    WebSiteURL = "www.krasi-plant.com"
                     },
                    new Manufacturer()
                    {
                    Id = 3,
                    Name = "Dunavia",
                    Telephone = "0883368777",
                    Email = "sirene-dunavia@abv.bg",
                    WebSiteURL = "www.dunavia-sirene.com"
                     },
            };
            return proizvoditeli;
        } 

    }
}