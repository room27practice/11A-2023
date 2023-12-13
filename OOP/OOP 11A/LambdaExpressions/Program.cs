namespace LambdaExpressions
{
    public class Program
    {
        static void Main()
        {
            //Console.WriteLine("Hello, World!");
            //Person p1 = new Person();
            //p1.PrintSomething("edno dve tri");

            var pr1 = new Program();
            pr1.GiveMeANumber(15, "kuncho");
        }

        public int GiveMeANumber(int age, string name, bool isImportant = false)
        {
            return 5;
        }


        public double Multiply(double x, double y)
        {
            return x * y;
        }



    }


    public class Person
    {
        public void PrintSomething(string something)
        {
            Console.WriteLine(something + "abrakadabra");
        }
    }
}