namespace CandyShop
{
    internal class Program
    {
        static void Main()
        {
            //TestDemo();
            List<Candy> shopItems = new List<Candy>();
            #region FirstOption
            FillData1stOption(shopItems);
            #endregion
            #region SecondOption
            //FillData2ndOption(shopItems);
            #endregion
            Console.WriteLine("List of Products In our Shop:");
            for (int i = 0; i < shopItems.Count(); i++)
            {
                Candy currentCandy = shopItems[i];
                Console.WriteLine($"{i}. {currentCandy.Name} - {currentCandy.PriceUSD:F2}$.");
            }
            while (true)
            {
                Console.WriteLine("What do you want to buy? Insert Number-Quantity (1-3)/ Or END");
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                int[] choiseOfProducts = input.Split("-").Select(x => int.Parse(x)).ToArray();
                int index = choiseOfProducts[0];
                int ammount = choiseOfProducts[1];
                shopItems[index].SellAmmount(ammount);
                Console.WriteLine($"you have purchased {shopItems[index].Name}x{ammount}!");
            }
            PrintData(shopItems);
        }
        private static void PrintData(List<Candy> shopItems)
        {
            decimal totalCost = 0;
            foreach (Candy product in shopItems.Where(x => x.CalculateProfit() > 0))
            {
                totalCost += product.CalculateProfit();
                Console.WriteLine($"{product.Name}x{product.Sold} [{product.PriceUSD}]={product.CalculateProfit()} ");
            }
            Console.WriteLine($"Total Money Bill: {totalCost}");
        }
        private static void FillData2ndOption(List<Candy> shopItems)
        {
            while (true)
            {
                //“{Име}; {Калории}; {Тегло}; {Цена}; {ТипНа изделието}”
                string input = Console.ReadLine();//"Donut; 500; 125; 0.49; Pretzels" или "END"
                if (input == "END")
                {
                    break;
                }
                shopItems.Add(new Candy(input));
            }
        }
        private static void FillData1stOption(List<Candy> shopItems)
        {
            while (true)
            {
                //“{Име}; {Калории}; {Тегло}; {Цена}; {ТипНа изделието}”
                string[] inputArr = Console.ReadLine().Split("; ");//Donut; 500; 125; 0,49; Pretzels
                if (inputArr[0] == "END")
                {
                    break;
                }
                string name = inputArr[0];
                int calories = int.Parse(inputArr[1]);
                double weight = double.Parse(inputArr[2]);
                decimal price = decimal.Parse(inputArr[3]);
                FamilyType type = Enum.Parse<FamilyType>(inputArr[4]);
                shopItems.Add(new Candy(name, calories, weight, price, type));
            }
        }
        private static void TestDemo()
        {
            var candy = new Candy();
            var candy2 = new Candy(false);
            var candy3 = new Candy(true);
            string nameOfCandy = candy.Name;
            candy.Calories = 120;
            Console.WriteLine(candy.Weight);
            candy.Weight = 300;
            //  candy.Ammount = 223;
        }
    }
    public class Candy
    {
        private int calories;
        private int totalSold;
        private decimal priceUSD;
        public Candy(bool isVeganAcceptable = true)
        {
            Ammount = 100;
            IsVeganAcceptable = isVeganAcceptable;
        }
        public Candy(string name, int calories, bool isVeganAcceptable = true) : this(isVeganAcceptable)
        {
            this.Name = name;
            this.Calories = calories;
        }
        public Candy(string name, int calories, double weight, bool isVeganAcceptable = true) : this(name, calories, isVeganAcceptable)
        {
            Weight = weight;
        }
        public Candy(string name, int calories, double weight, decimal price, bool isVeganAcceptable = true) : this(name, calories, weight, isVeganAcceptable)
        {
            PriceUSD = price;
            this.priceUSD = price;
        }
        public Candy(string name, int calories, double weight, decimal price, FamilyType famType, bool isVeganAcceptable = true) : this(name, calories, weight, price, isVeganAcceptable)
        {
            FamilyType = famType;
        }
        #region SecondOption
        public Candy(string input) : this()
        {
            var inputArr = input.Split("; ");
            Name = inputArr[0];
            Calories = int.Parse(inputArr[1]);
            Weight = double.Parse(inputArr[2]);
            PriceUSD = decimal.Parse(inputArr[3]);
            FamilyType = Enum.Parse<FamilyType>(inputArr[4]);
        }
        #endregion
        public string Name { get; private set; }
        public int Sold { get => totalSold; }
        public int Calories
        {
            get { return calories; }
            set
            {
                if (value < 100)
                {
                    calories = 100;
                }
                else
                {
                    calories = value;
                }
            }

        }
        //Не е по условие просто показвам достъп с различни нива.
        public double Weight { get; set; }
        public decimal PriceUSD
        {
            get
            {
                return 1.2m * priceUSD;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Invalid Price for Candy! 0.5$ is not happy!");
                    priceUSD = 5;
                }
                else
                {
                    priceUSD = value;
                }
            }
        }
        public int Ammount { get; private set; }
        public bool IsVeganAcceptable { get; set; }
        public FamilyType FamilyType { get; set; }
        public void SetCaloriesAdmin(string pwd, int newCalories)
        {
            if (pwd == "123#P")
            {
                calories = newCalories;
            }
            else
            {
                Console.WriteLine("You shall not Pass!!!");
            }
        }
        public void IncreaseAmmount(int ammount, string pwd = "")
        {
            if (pwd == "123#P")
            {
                Console.WriteLine("Welcome MasterChief!");
                Ammount += ammount;
                return;
            }
            if (ammount <= 0)
            {
                Console.WriteLine("Nqma da uvelicha kolichestvoto.");
                return;
            }
            if (ammount >= 100)
            {
                Console.WriteLine("Bomba ne moje tolkova mnogo");
                return;
            }
            Ammount += ammount;
        }
        public void SellAmmount(int ammount)
        {
            Ammount -= ammount;
            totalSold += ammount;
        }
        public decimal CalculateProfit()
        {
            return totalSold * PriceUSD;
        }
    }
    public enum FamilyType
    {
        Bonbon,
        Cake,
        Licorice,
        Pretzels,
        ShugarMagic,
        FruitPower,
        Waffle,
        Snacks,
        Unspecified
    }
}