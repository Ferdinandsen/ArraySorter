using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IArraySorter
    {
        List<TableArray> sortArray(TableArray ta);
        List<TableArray> getArray(TableArray ta);
        List<TableArray> getAllArrays();
        void RandomizeArray(TableArray ta);

    }
}
