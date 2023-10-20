namespace ShopRelationsMirrorDB.Models
{
    public class Address
    {
        public Address()
        {
            Shops = new List<Shop>();
        }
        public Address(string townName, string streetName, int streetNumber, string description):this()
        {
            TownName = townName;
            StreetName = streetName;
            StreetNumber = streetNumber;
            Description = description;
        }

        public int Id { get; set; }
        public string TownName { get; set; }
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public string Description { get; set; }
        public virtual IList<Shop> Shops { get; set; }
    }


}
