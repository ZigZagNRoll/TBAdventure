using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBA.BL.Domain
{
    public class Plain
    {
        public int PlainNumber { get; set; }
        public string PlainName { get; set; }
        public string Text { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
