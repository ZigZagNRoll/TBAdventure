using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBA.BL.Domain
{
    public class Room
    {
        public virtual int RoomNumber { get; set; }
        public string Details { get; set; }
        public int Exits { get; set; }
        public int locationX { get; set; }
        public int locationY { get; set; }
        public ICollection<Door> Doors { get; set; } 
    }
}
