using DAL.Repository;
using DAL.Repository.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFacade
    {
        IArrayBuilder ab;
        IArraySorter asr;
        public IArrayBuilder getArrayBuilder()
        {
            return ab != null ? ab : ab = new ArrayBuilderRepo();
        }

        public IArraySorter getArraySorter(){
            return asr != null ? asr : asr = new ArraySorterRepo();
        }
    }
}
