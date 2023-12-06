using System.Security.Cryptography.X509Certificates;

namespace Interfaces_And_Override
{
    internal class Program
    {
        static void Main()
        {
            // Demo1();

            var dog1 = new Dog("Sharo");
            var dog2 = new Dog("Jaro");
            var dog3 = new Dog("Haro");

            var cat1 = new Cat("Redjeb");
            var cat2 = new Cat("Garfield");
            var cat3 = new Cat("Chizmarq");

            List<INamableAndDiable> animalsList = new List<INamableAndDiable>();
            animalsList.Add(dog1);
            animalsList.Add(cat1);
        
        }

        public class Dog
        {
            private bool isAlive = true;

            public Dog(string name)
            {
                Name = name;
            }

            public string  Name { get; set; }
            public void Bark()
            {
                Console.WriteLine("Woof Woof");
            }
            public void Die()
            {
                Console.WriteLine("It is dead!");
                isAlive = false;
            }
        }

        public class Cat:INamableAndDiable
        {
            public Cat(string name, int lives=9)
            {
                Name = name;
                Lives = lives;
            }

            public string Name { get; set; }
            public int Lives { get; set; }
            public void Miew()
            {
                Console.WriteLine("Miew Miew");
            }
            public void Die()
            {
                Lives--;
            }
        }


        public interface INamableAndDiable
        {
            string Name { get; set; }
            void Die();
        }



        private static void Demo1()
        {
            Student std = new Student { Name = "Grisho", Age = 27 };
            Person prs = new Person { Name = "Kuncho", Age = 47 };
            Person[] people = { std, prs };
            people[0].SayHello();
            people[1].SayHello();
            Console.WriteLine(std);
            std.SayHello();
            Console.WriteLine(new string('=', 20));
            prs.SayHello();
        }
    }
}
