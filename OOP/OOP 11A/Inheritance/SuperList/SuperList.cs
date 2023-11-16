namespace Inheritance.SuperList
{
    public class SuperList : List<string>
    {
        public string GetRandomEl()
        {
            int countOfElements = base.Count - 1; //"ala", "bala" , "turpokal"
            if (countOfElements == 0)
            {
                return null;
            }
            var random = new Random();
            int index = random.Next(0, countOfElements);
            string result = base[index];
            base.RemoveAt(index);
            return result;
        }
    }
}
