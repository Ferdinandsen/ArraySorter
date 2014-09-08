using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Impl
{
    internal class ArrayBuilderRepo : IArrayBuilder
    {
        public void createArray(int size)
        {
            int idToCreate;
            using (var db = new ArraySorterEntities())
            {

                try
                {
                    idToCreate = db.TableArrays.Max(x => x.ArrayID);
                    idToCreate++;
                }
                catch (Exception) //InvalidOperationException
                {
                    idToCreate = 1;
                }



                for (int i = 0; i < size; i++)
                {
                    TableArray ta = new TableArray();
                    ta.ArrayID = idToCreate;

                    ta.ArrayIndex = i;
                    db.TableArrays.Add(ta);
                }

                db.SaveChanges();
                Console.WriteLine(idToCreate);
            }

        }

        public void fillArray(int id)
        {
            Random rnd = new Random();
            using (var db = new ArraySorterEntities())
            {
                foreach (TableArray arr in db.TableArrays)
                {
                    if (arr.ArrayID == id)
                    {
                        arr.ArrayValue = rnd.Next();
                    }
                }
                db.SaveChanges();
            }
        }

        public long[] getArray(int id)
        {
            long count = 0;
            long[] tmp;
            List<TableArray> allArrays = new List<TableArray>();
            using (var db = new ArraySorterEntities())
            {
                foreach (TableArray test in db.TableArrays)
                {
                    allArrays.Add(test);
                    if (test.ArrayID == id)
                    {
                        count++;
                    }
                }
            }
            tmp = new long[count];
            foreach (TableArray test in allArrays)
            {
                if (test.ArrayID == id)
                {
                    tmp[test.ArrayIndex] = test.ArrayValue;
                }
            }

            return tmp;

        }

        public void deleteArray(int id)
        {
            using (var db = new ArraySorterEntities())
            {
                foreach (TableArray e in db.TableArrays)
                {
                    if (e.ArrayID == id)
                    {
                        db.TableArrays.Remove(e);
                    }
                }
                db.SaveChanges();
            }
        }

        public List<TableArray> getAllArrays()
        {
            using (var db = new ArraySorterEntities())
            {
                return db.TableArrays.ToList();
            }
        }
    }
}
