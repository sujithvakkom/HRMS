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
    public class HRDepartment
    {
        [Column("DepartmentID")]
        public int DepartmentID { get; set; }
        [Column("Name")]
        public string Name { get; set; }

        public static List<HRDepartment> GetList(DbContext context)
        {
            return context.Database.SqlQuery<HRDepartment>(
                @"SELECT d.[DepartmentID] ,
       d.[Name]
FROM HR_DEPARTMENT AS d"
                ).ToList();
        }

        public static HRDepartment Get(string Name, DbContext context)
        {
            try
            {
                return context.Database.SqlQuery<HRDepartment>(
                    @"SELECT d.[DepartmentID] ,
       d.[Name]
FROM HR_DEPARTMENT AS d
WHERE d.[Name] = @Name",

                    new SqlParameter("@Name", Name)
                    ).First();
            }
            catch (Exception) { return null; }
        }

        public static int AddDept(string Name, DataStore context)
        {
            var existDept = Get(Name, context);
            if (existDept == null)
                return context.Database.ExecuteSqlCommand(
                    @"INSERT INTO HR_DEPARTMENT ( Name
                          )
VALUES(@Name
       )",
                    new SqlParameter("@Name", Name));
            else
                throw new Exception(String.Format("[0] already exists", Name));
        }
    }
}