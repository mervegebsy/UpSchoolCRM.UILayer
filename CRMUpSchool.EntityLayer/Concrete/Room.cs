using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMUpSchool.EntityLayer.Concrete
{
    public class Room
    {
        [Key]
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
