using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryConsole_Wpf.Model
{
   public class SchoolContext : DbContext
    {
        public SchoolContext() : base("TryConnect") { }
        public DbSet<Students> Students { get; set; }   
        public DbSet<ClassRoom> ClassRooms { get; set; }

    }
}
