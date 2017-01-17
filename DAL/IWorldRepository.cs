using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBA.BL.Domain;

namespace TBA.DAL
{
    public interface IWorldRepository
    {
        #region World
        IEnumerable<Plain> ReadPlains();

        Plain CreatePlain(Plain Plain);
        Plain ReadPlain(int Plain);

        #endregion

    }
}
