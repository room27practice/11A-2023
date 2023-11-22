namespace Errors
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 3, 4, -23, 3, 13, 5, 6, 7 };
            while (true)
            {
                Console.Write("Please enter Index: ");
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                try
                {
                    int index = int.Parse(input);//mushmol -10
                    Console.WriteLine("You selected number :" + numbers[index]);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("We are very sorry but we cant find number at this index!");
                    Console.WriteLine(ex.Message);
                    //throw new InvalidDataException("You made big mastake");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"We are very sorry but we understand your number {input}!");
                    Console.WriteLine(ex.Message);
                }
                finally
                { }
                try
                {
                    int a = int.Parse("sad");
                }
                catch
                { }

                Console.WriteLine("!!!Completed!!!");
                Console.WriteLine(new string('=', 20));
            }
        }
    }
}