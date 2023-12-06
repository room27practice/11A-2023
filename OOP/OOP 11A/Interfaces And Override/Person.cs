public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public virtual void SayHello()
    {
        Console.WriteLine($"Hello from parent {Name}");
    }
    public void WriteNumber(int number)
    {
        Console.WriteLine(number);
    }
    public override bool Equals(object? obj)
    {
        if (Age > ((Person)obj).Age)
        {
            return true;
        }
        return false;
    }
    public override string ToString()
    {
        return $"{Name} - {Age}";
    }
}
