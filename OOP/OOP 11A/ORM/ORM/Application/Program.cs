using Application.Data;
using Application.Models;

namespace Application
{
    internal class Program
    {
        static void Main()
        {
            using (AppDbContext db=new AppDbContext())
            {
                // InsertData(db);

                Student[] students = db.Students.ToArray();
               
                
                Console.WriteLine();

            }





        }

        private static void InsertData(AppDbContext db)
        {
            var room = new Room(2, 27, 13, "Master Hall");
            var person = new Student("Genadi", 11, 'A');
            person.Room = room;
            // room.Students.Add(person);
            db.Students.Add(person);
            db.SaveChanges();
            Console.WriteLine("Gotovo!");
        }
    }
}