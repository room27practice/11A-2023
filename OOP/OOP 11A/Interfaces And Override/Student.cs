public class Student : Person
{
    public string SchoolName { get; set; } = "PGMETT";
    public override void SayHello()
    {
        //base.SayHello();
        Console.WriteLine("We all live in a yellow submarine");
    }
    public override string ToString()
    {
        return base.ToString() + $" I am a student from {SchoolName}";
    }
}