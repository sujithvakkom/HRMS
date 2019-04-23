using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Models
{
    [ComplexType]
    public class HRDocType
    {
        [Column("DocTypeId")]
        public int DocTypeId { get; set; }
        [Column("Name")]
        public string Name { get; set; }

        public static List<HRDocType> GetList(DbContext context)
        {
            return context.Database.SqlQuery<HRDocType>(
                @"SELECT d.[DocTypeId] ,
       d.[Name]
FROM HR_DOCTYPE AS d"
                ).ToList();
        }

        public static HRDocType Get(string Name, DbContext context)
        {
            try
            {
                return context.Database.SqlQuery<HRDocType>(
                    @"SELECT d.[DocTypeId] ,
       d.[Name]
FROM HR_DOCTYPE AS d
WHERE d.[Name] = @Name",

                    new SqlParameter("@Name", Name)
                    ).First();
            }
            catch (Exception) { return null; }
        }

        public static int AddDocType(string Name, DataStore context)
        {
            var existDept = Get(Name, context);
            if (existDept == null)
                return context.Database.ExecuteSqlCommand(
                    @"INSERT INTO HR_DOCTYPE ( Name
                          )
VALUES(@Name
       )",
                    new SqlParameter("@Name", Name));
            else
                throw new Exception(String.Format("[0] already exists", Name));
        }
    }
}