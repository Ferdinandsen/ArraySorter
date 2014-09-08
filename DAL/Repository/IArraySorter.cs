using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IArraySorter
    {
        long[] sortArray(int id);

        long[] getSortedArray(int id);

        List<TableArray> getArray(TableArray ta);
        List<TableArray> getAllArrays();
        void RandomizeArray(TableArray ta);

    }
}
