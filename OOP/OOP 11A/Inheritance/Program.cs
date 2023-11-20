using Inheritance.SuperList;
using SuperPosition_Delegation;

public class Program
{
    public static void Main()
    {
        //Animal dog1 = new Inheritance.Dog("Sharo", 12, 15.4, DogBreed.Buldog);
        //var dog2 = new NoInheritance.Dog("Sharo", 12, 15.4, DogBreed.Buldog);
        //dog1.RunForTimeSeconds(230);
        //dog2.RunForTimeSeconds(230);
        //var animal = new Animal("Sharo", 12, 15.4);

        //Candy candy = new Candy();


        SuperList experiment = new SuperList();

        experiment.Add("ala");
        experiment.Add("bala");
        experiment.Add("nica");
        experiment.Add("portokal");
        experiment.Add("turpokal");
        experiment.Add("banan");
        experiment.Add("shtepsel");

        Console.WriteLine(string.Join(" - ", experiment));
        Console.WriteLine(new string('=', 20));
       
        Console.WriteLine(experiment.GetRandomEl());
       
        Console.WriteLine(new string('=',20));
        Console.WriteLine(string.Join(" - ",experiment ));




    }


    public static void TestSuperpositionDemo()
    {
        var phone = new SmartPhone("XMASS23");
        phone.MakeBrighter();
       


    }





}
