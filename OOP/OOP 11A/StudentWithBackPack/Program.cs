namespace StudentWithBackPack
{
    internal class Program
    {
        static void Main()
        {
            Student st1 = new Student() {Name="Gancho",FamilyName="Petrov", Age = 15 };
            BackPack bp1 = new BackPack() { Volume = 15.6, Color = "Camoflage", Price = 69.75m };
            st1.BackPack = bp1;
          //  st1.Grades = new List<int>();
            st1.Grades.Add(5);
            st1.Grades.Add(4);
            st1.Grades.Add(6);
            st1.Grades.Add(5);
            st1.Grades.Add(6);
            Console.WriteLine("Sreden uspeh e :" + st1.GetAverageGrade());  ;
        }
    }

    public class BackPack
    {
        public double Volume { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
    }


    public class Student
    {
        public string Name { get; set; }
        
        private string familyName;
        public string FamilyName {
            get {
                return familyName.ToUpper().Substring(0,1)+"."; 
            }  
            set => familyName = value;         
        }  
        public int Age { get; set; }

        public BackPack BackPack { get; set; }

        public List<int> Grades { get; set; } = new List<int>();

        public void PresentYourSelf()
        {
            //Console.WriteLine($"I am {name} and I am {Age} years old!");
            //IncreaseAge();
        }

        public double GetAverageGrade()
        {
            double result = Grades.Sum()/Grades.Count();
            return result;
        }
        private void IncreaseAge()
        {
            Age++;
        }
    }




}