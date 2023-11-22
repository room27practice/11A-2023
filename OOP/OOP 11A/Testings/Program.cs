using Furnitures;

namespace Testings
{
    internal class Program
    {
        static void Main()
        {
            List<Furniture> mebeli = new List<Furniture>();

            mebeli.Add(new Chair("ofisen stol", 43.23m, 50));
            mebeli.Add(new Bed("mekoleko",133.43m,0,30,125,200,BedSpec.Nails));

            if (typeof(mebeli[1])==Bed)
            {

            }



        }
    }
}