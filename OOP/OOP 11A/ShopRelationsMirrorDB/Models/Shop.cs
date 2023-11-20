namespace ShopRelationsMirrorDB.Models
{
    public class Shop
    {
        public Shop()
        {
            ShopVistors = new List<PersonShop>();
        }
        public Shop(string name, int startHour, int endHour) : this()
        {
            Name = name;
            StartHour = startHour;
            EndHour = endHour;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int StartHour { get; set; }
        public int EndHour { get; set; }

        public int AdressId { get; set; }
        public virtual Address Address { get; set; }

        public int PurposeId { get; set; }
        public virtual Purpose Purpose { get; set; }

        public virtual IList<PersonShop> ShopVistors { get; set; }
    }


}
