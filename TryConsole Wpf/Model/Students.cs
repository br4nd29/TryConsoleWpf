using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryConsole_Wpf.Model
{
  public  class Students
    {
        [Key]
        
        public int IdStudent { get; set; }
        [StringLength(50)]
        
        public string FIO { get; set; }
        [ForeignKey("IdClassRoom")]
        public int? ClassRoomId { get; set; }
        public ClassRoom ClassRoom { get; set; }

    }
}
