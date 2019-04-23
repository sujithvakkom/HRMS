using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider
{
    public class DataStore: DbContext
    {
        public DataStore(String ConnectionString) : base(ConnectionString) { }


    }
}
