using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IArrayBuilder
    {
        void createArray(int size);

        void fillArray(int id);

        long[] getArray(int id);

        void deleteArray(int id);

        List<TableArray> getAllArrays();
    }

}

