namespace CandyShop
{
    internal class Program
    {
        static void Main()
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
        public string Name { get; private set; }
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
        Pretsels,
        ShugarMagic,
        FruitPower
    }
}