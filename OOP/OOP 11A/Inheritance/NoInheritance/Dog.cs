namespace NoInheritance
{
    public class Dog
    {
        private double speedMetersPerSecond = 3.0;

        public Dog(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public Dog(string name, int age, double weight, DogBreed dogBreed) : this(name, age, weight)
        {
            Breed = dogBreed;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public DogBreed Breed { get; set; }
        public int RunForTimeSeconds(double distanceMeters)
        {
            int timeRequired = (int)Math.Ceiling(distanceMeters / speedMetersPerSecond);
            return timeRequired;
        }
        public void Bark()
        {
            Console.WriteLine("Wofff Woff");
        }
    }
}

