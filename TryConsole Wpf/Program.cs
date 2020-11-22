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

               

                foreach (Students students1 in db.Students.ToList() )
                {
                    Console.WriteLine("{0} - {1}", students1.FIO, students1.ClassRoom != null ? students1.ClassRoom.ClassName : ""); 


                    
                }
                Console.ReadLine();
            }
        }
    }
}
