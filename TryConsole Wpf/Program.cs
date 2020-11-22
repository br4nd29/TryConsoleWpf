using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryConsole_Wpf.Model;

namespace TryConsole_Wpf
{
    class Program
    {
        static void Main(string[] args)
        {
            using(SchoolContext db = new SchoolContext())
            {

                foreach (ClassRoom classRoom in db.ClassRooms)
                {
                    Console.WriteLine(classRoom.ClassName);
                }

                foreach (Students students1 in db.Students.ToList() )
                {
                    Console.WriteLine($"{students1.FIO} ");

                    
                }
                Console.ReadLine();
            }
        }
    }
}
