using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataProvider
{
    public class ApplicationDbContext : DbContext
    {
        public static IDisposable Create()
        {
            return null;
        }
    }
}
