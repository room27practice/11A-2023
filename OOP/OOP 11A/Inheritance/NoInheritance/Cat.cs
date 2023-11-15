using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoInheritance
{

    public class Cat
    {
        private double speedMetersPerSecond = 4.0;
        public Cat(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public Cat(string name, int age, double weight, int lives, CatBreed breed) : this(name, age, weight)
        {
            Lives = lives;
            Breed = breed;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public int Lives { get; set; } = 9;
        public CatBreed Breed { get; set; }
        public int RunForTimeSeconds(double distanceMeters)
        {
            int timeRequired = (int)Math.Ceiling(distanceMeters / speedMetersPerSecond);
            return timeRequired;
        }
        public void Meaw()
        {
            Console.WriteLine("Miew Meaw");
        }
    }
}

