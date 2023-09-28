namespace MethodsDemo
{
    internal class Program
    {
        static void Main()
        {
            GetNum(6, "alabala");

            //Optional Parameters
            ChangeOil("Ford Focus Gen2");
            ChangeOil("Ford Focus Gen2", "duperMaslo");
            ChangeOil("Ford Focus Gen2", "duperMaslo", "full");
            ChangeOil("Ford Focus Gen2", "duperMaslo", "full", true);
            ChangeOil(model: "Ford Mustang", refillFuel: true);
            ChangeOil(howMuch: "quarter", model: "C200 Mercedess");


            //OverLoading
            Refuel("ford-mustang 87");
            Refuel("ford-mustang 87", "benzine");
            Refuel("ford-mustang 87", "benzine", 0.98);
            //demo with Params
            double[] nums = { 1, 4, 6, 8, 12 };
            Console.WriteLine("Sumata na chislata e:" + SumNumbers(6.8,nums));
            Console.WriteLine("Sumata na chislata e:" + SumNumbers(10.43,2.7));

        }



        //Optional Parameters
        public static void ChangeOil(string model, string oil = "superMaslo", string howMuch = "half", bool refillFuel = false)
        {
            Console.WriteLine("we change oil best");
        }
        public static void Refuel(string model)
        {
            Console.WriteLine($"we refuel cars best, knowing model is {model}");
        }
        public static void Refuel(string model, string fuelType)
        {
            Refuel(model);
            Console.WriteLine($"fuell added was {fuelType}");
        }
        public static void Refuel(string model, string fuelType, double quantityPercentage) //1.0 full OR 0.5 = half
        {
            Refuel(model, fuelType);
            Console.WriteLine($"filled it to {quantityPercentage * 100}% of cappacity");
        }


        public static int GetNum(int num1 = 6, string s1 = "nqma problem")
        {
            return 5;
        }



        public static int GetNum(string s1)
        {
            return 15;
        }
        //Params
        public static double SumNumbers(double favoriteNumber,params double[] numbers)
        {
            double result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result = result + numbers[i];
            }
            result *= favoriteNumber;
            return result;
        }
    }
}