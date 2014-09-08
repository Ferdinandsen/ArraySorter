using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Impl
{
    internal class ArraySorterRepo : IArraySorter
    {

        public long[] sortArray(int id)
        {
            throw new NotImplementedException();
        }

        public long[] getSortedArray(int id)
        {
            throw new NotImplementedException();
        }

        public List<TableArray> getArray(TableArray ta)
        {
            List<TableArray> selectedTableArray = new List<TableArray>();
            using (var db = new ArraySorterEntities())
            {
                foreach (TableArray testTa in db.TableArrays)
                {
                    if (ta.ArrayID == testTa.ArrayID)
                    {
                        selectedTableArray.Add(testTa);
                    }
                }
            }
            return selectedTableArray;
        }

        public List<TableArray> getAllArrays()
        {
            List<TableArray> localArrays = new List<TableArray>();

            using (var db = new ArraySorterEntities())
            {
                foreach (TableArray e in db.TableArrays)
                {
                    bool contains = localArrays.Any(x => x.ArrayID == e.ArrayID);

                    if (!contains)
                    {
                        localArrays.Add(e);
                    }
                }
            }
            return localArrays;
        }
    }
}
