namespace ConstructorDemo
{
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("A");
            ProductsUsed = new List<Product>();
        }
        public Animal(string name) : this()
        {
            Console.WriteLine("B");
            Name = name;
        }

        public Animal(string name, int age) : this(name)
        {
            Console.WriteLine("C");
            Age = age;
        }

        public List<Product> ProductsUsed { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}