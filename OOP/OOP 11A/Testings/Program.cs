using Furnitures;

namespace Testings
{
    internal class Program
    {
        static void Main()
        {
            /*Пример за TypeCheck 
             * Проверка дали обект е от даден вид клас! 
             * Прави се преди кастване */
            List<Furniture> mebeli = new List<Furniture>();

            mebeli.Add(new Chair("ofisen stol", 43.23m, 50));
            mebeli.Add(new Bed("mekoleko",133.43m,30,125,200,BedSpec.Nails));

            if (mebeli[1].GetType()==typeof(Bed))
            {

            }



        }
    }
}