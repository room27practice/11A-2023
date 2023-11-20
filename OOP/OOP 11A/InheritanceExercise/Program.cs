using Furnitures;
namespace IneritanceExercise
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello 11A");
            Furniture furniture = new Furniture("Biufet", 234.54m);
            Bed bed1 = new Bed("Shiroko Leglo", 199.99m, 67, 45, 90, 200, BedSpec.TopMatress);
            Chair ch1 = new Chair("Vurtiasht Ofisen", 99.99m, 50);

            Console.WriteLine(bed1.UsersCount);
           
        }
    }
}