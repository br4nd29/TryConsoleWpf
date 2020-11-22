using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryConsole_Wpf.Model
{
  public  class ClassRoom
    {
        [Key]
        public int IdClassRoom { get; set; }
        public string ClassName { get; set; }
        public ICollection<Students> Students { get; set; } 
        public ClassRoom()
        {
            Students = new List<Students>();
        }
    }
}
