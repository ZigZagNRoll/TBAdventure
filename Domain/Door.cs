using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBA.BL.Domain
{
    public class Door
    {
        public int DoorNumber { get; set; }
        public String Text { get; set; }
        public Boolean Locked { get; set; }
        public int EntersOn { get; set; }
        public int ExitsOn { get; set; }

    }
}
