using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Models
{
    [ComplexType]
    public class User
    {
        [Column("UserName")]
        public String UserName { get; set; }
        [Column("Password")]
        public String Password { get; set; }
        [Column("IsLogedIn")]
        public bool IsLogedIn { get; set; }
        public User()
        {
            IsLogedIn = false;
        }

        public void Login(DbContext context)
        {
            User user = null;
            try
            {
                var temp =
                context.Database.SqlQuery<User>(
                          @"SELECT u.[UserName] ,
                                   u.[Password] ,       
                                   cast(1 as bit) AS [IsLogedIn]
                            FROM [user] AS u
                            WHERE u.[UserName] = @user_name
                                  AND
                                  u.[Password] = @password",
                    new SqlParameter("@user_name", this.UserName),
                    new SqlParameter("@password", this.Password)
                    ).ToList();
                if (temp.Count() > 0)
                    user = temp.First();
                else
                    user = null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }
            if (user != null) this.IsLogedIn = user.IsLogedIn;
        }
    }
}
