namespace ConstructorDemo
{
    public class Manufacturer
    {
        private string telephone = "+359";
        public Manufacturer()
        {
            Name = "Genadi";
        }
        public Manufacturer(string name, string phoneNumber)
        {
            Name = name;
            Telephone = phoneNumber;
        }
        public Manufacturer(string name, string telephone, string webSiteURL, string email)
        {
            Name = name;
            this.telephone = telephone;
            WebSiteURL = webSiteURL;
            Email = email;
        }
        public string Telephone { get => telephone.Replace("+", "BG-Number-Network:"); set { telephone = value; } }
        public int Id { get; set; }
        public string Name { get; set; } = "Asen";
        public string WebSiteURL { get; set; }
        public string Email { get; set; }
        public void ChangeName()
        {
            Name = "Mitko";
        }
    }
}