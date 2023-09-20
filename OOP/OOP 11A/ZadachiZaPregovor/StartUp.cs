namespace ZadachiZaPregovor
{
    internal class StartUP
    {
        static void Main()
        {
            //  Zadacha1();
             Zadacha2();


        }

        private static void Zadacha1()
        {
            int rentOfHall = int.Parse(Console.ReadLine());
            decimal statuesValue = rentOfHall * 0.7m;
            decimal ceteringValue = statuesValue * 0.85m;
            var soundValue = ceteringValue / 2;
            decimal totalCost = rentOfHall + statuesValue + ceteringValue + soundValue;
            Console.WriteLine($"Otgovorut e {totalCost:F2}");
        }


        private static void Zadacha2()
        {
            Console.WriteLine("Tova e zadacha 2!!!!!!!");
        }
    }
}