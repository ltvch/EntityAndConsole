using System;
using System.Linq;

namespace EntityAndConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                //  Console.WriteLine("Hello World!");
                User user1 = new User { Name = "Tom", Age = 44 };
                User user2 = new User { Name = "Mary", Age = 2 };

                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
                Console.WriteLine("Object good save");

                //get value from db to console
                var users = db.Users.ToList();
                Console.WriteLine("List of objects: ");
                foreach(User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }
            Console.Read();
        }
    }
}
