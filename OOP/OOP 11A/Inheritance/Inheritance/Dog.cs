namespace Inheritance
{
    public class Dog : Animal
    {
        public Dog(string name, int age, double weight) : base(name, age, weight)
        {        }

        public Dog(string name, int age, double weight, DogBreed dogBreed) : this(name, age, weight)
        {
            Breed = dogBreed;
        }
        public DogBreed Breed { get; set; }
        public string Owner { get; set; }
        public void Bark()
        {
            Console.WriteLine("Wofff Woff");
        }

    }


    public class Puppy : Dog
    {
        public Puppy(string name, int age, double weight, DogBreed dogBreed) : base(name, age, weight, dogBreed)
        {
        }



    }
}
