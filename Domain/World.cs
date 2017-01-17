using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBA.BL.Domain
{
    public class World
    {
        public String WorldName { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public String WorldDesc { get; set; }
        IEnumerable<Plain> plains { get; set; }
    }
}
