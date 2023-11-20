namespace Inheritance
{
    public  class Animal
    {
        protected double speedMetersPerSecond = 2;
        public Animal(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }  
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
       
        public int RunForTimeSeconds(double distanceMeters)
        {
            int timeRequired = (int)Math.Ceiling(distanceMeters / speedMetersPerSecond);
            return timeRequired;
        }
    }
}
