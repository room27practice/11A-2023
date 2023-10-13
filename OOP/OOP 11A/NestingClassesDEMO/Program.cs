namespace NestingClassesDEMO
{
    internal class Program
    {
        static void Main()
        {
     

            var car1 = new Car();
            car1.RegisterOwner(new Person() { Name="Genadi"});
            car1.RegisterOwner(new Person() { Name="Mitko"});

            foreach (Person owner in car1.Owners)
            {
                Console.WriteLine(owner.Name);
            }
           

        }


        



    }


    class Car
    {
        private int yearOfMake;
        public Car()
        {
            owners = new List<Person>();
        }

        public Car(int yearOfMake, string model) : this()
        {
            YearOfMake = yearOfMake;
            Model = model;
        }

        public int YearOfMake { get => yearOfMake; set => yearOfMake = value; }
        public string Model { get; set; }
        public Engine Engine { get; set; }

        public List<string> TownsVisited { get; set; }
        private List<Person> owners;
        public IReadOnlyCollection<Person> Owners { get => owners.AsReadOnly(); }
        public void RegisterOwner(Person p)
        {
            owners.Add(p);
        }
    }

    public class Engine
    {
        public int HorsePowers { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
    }

    public class Person
    {
        public string Name { get; set; }
        public string EGN { get; set; }
    }

}