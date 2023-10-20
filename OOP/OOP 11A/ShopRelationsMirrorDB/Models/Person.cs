namespace ShopRelationsMirrorDB.Models
{
    public class Person
    {
        public Person()
        {
            PersonShops = new List<PersonShop>();
        }
        public Person(string eGN, string name, int age, string email, string proffession) : this()
        {
            EGN = eGN;
            Name = name;
            Age = age;
            Email = email;
            Proffession = proffession;
        }

        //Id
        public string EGN { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Proffession { get; set; }

        public virtual IList<PersonShop> PersonShops { get; set; }
    }


}
