using Inheritance;

public class Program
{
    public static void Main()
    {
        Animal dog1 = new Inheritance.Dog("Sharo", 12, 15.4, DogBreed.Buldog);
        var dog2 = new NoInheritance.Dog("Sharo", 12, 15.4, DogBreed.Buldog);
        dog1.RunForTimeSeconds(230);
        dog2.RunForTimeSeconds(230);
        var animal = new Animal("Sharo", 12, 15.4);




    }





}
