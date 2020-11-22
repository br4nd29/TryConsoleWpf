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
                ClassRoom classRoom = new ClassRoom { ClassName = "Lol" };
                db.ClassRooms.Add(classRoom);
                db.SaveChanges();
            }
        }
    }
}
