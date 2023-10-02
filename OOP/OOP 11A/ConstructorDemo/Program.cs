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
            var man2 = new Manufacturer("Atanas","+359-953-67-23");

            var man3 = new Manufacturer("Hristiqn","+359888753","vuzdoh.com","hristiqn@abv.bg");

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
            };
            // Food, BeverageAlcohol, BeverageNonAlcohol, CleaningSupplies, Clothing
            proizvoditeli.Add(new Manufacturer());
            proizvoditeli.Add(new Manufacturer("Hristiqn", "+359888753", "vuzdoh.com", "hristiqn@abv.bg"));



            Product product = new Product
            {
                Name = "Prah za prane LEX",
                Description = "Hitriqt nachin za prane Lex, Rex i t.n...",
                PriceBGN = 12.43m,
                WeightKgs = 2,
                ProductType = ProductType.CleaningSupplies,
                Manufacturer = proizvoditeli[0],
                ExpirationDate = DateTime.ParseExact("02-10/2024", "dd-MM/yyyy", CultureInfo.InvariantCulture)
            };
        }
    }

    public class Product
    {
        public decimal PriceBGN { get; set; }
        public DateTime ExpirationDate { get; set; }
        public double WeightKgs { get; set; }
        public ProductType ProductType { get; set; }
        public string Description { get; set; }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Manufacturer Manufacturer { get; set; }
    }
    public enum ProductType
    {
        Food, BeverageAlcohol, BeverageNonAlcohol, CleaningSupplies, Clothing
    }




    public class Manufacturer
    {
        private string telephone;
        public string Telephone { get => telephone; set => telephone = value; }

        public int Id { get; set; }
        public string Name { get; set; } = "Asen";
        public string WebSiteURL { get; set; }
        public string Email { get; set; }

        public Manufacturer()
        {
            Name = "Genadi";
        }

        public Manufacturer(string name, string phoneNumber)
        {
            Name = name;
            Telephone = phoneNumber;
        }

        public Manufacturer(string name, string telephone, string webSiteURL, string email)
        {
            Name = name;
            this.telephone = telephone;
            WebSiteURL = webSiteURL;
            Email = email;
        }

        public void ChangeName()
        {
            Name = "Mitko";
        }


    }
}