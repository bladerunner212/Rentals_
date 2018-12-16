using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Transactions;

namespace Rentals.DataBase
{
    class ConnectionManagment
    {
        public static void PassingAnOpenConnection()
        {
             using (var conn = new SqlConnection("{connectionString}"))
             {
                 conn.Open();

                 var sqlCommand = new SqlCommand();
                 sqlCommand.Connection = conn;
                 sqlCommand.CommandText =
                     @"UPDATE Blogs SET Rating = 5" +
                      " WHERE Name LIKE '%Entity Framework%'";
                 sqlCommand.ExecuteNonQuery();

                 using (var context = new AppContext(conn, contextOwnsConnection: false))
                 {
                     var query = context.Posts.Where(p => p.User.Rating > 5);
                     foreach (var post in query)
                     {
                         post.Title += "[Cool Blog]";
                     }
                     context.SaveChanges();
                 }

                 var sqlCommand2 = new SqlCommand();
                 sqlCommand2.Connection = conn;
                 sqlCommand2.CommandText =
                     @"UPDATE Blogs SET Rating = 7" +
                      " WHERE Name LIKE '%Entity Framework Rocks%'";
                 sqlCommand2.ExecuteNonQuery();
             }
         }
         

           /* using (var tx = new TransactionScope())
            {
                using (var con = new SqlConnection($"{connectionString}"))
                {
                    con.Open();

                    using (var com = new SqlCommand($"set xact_abort on; begin transaction; INSERT INTO dbo.KeyValueTable VALUES ('value1', '{Guid.NewGuid()}'); rollback;", con))
                    {
                        // This transaction failed, but it doesn't rollback the entire system.transaction!
                        com.ExecuteNonQuery();
                    }

                    using (var com = new SqlCommand($"set xact_abort on; begin transaction; INSERT INTO dbo.KeyValueTable VALUES ('value2', '{Guid.NewGuid()}'); commit;", con))
                    {
                        // This transaction will actually persist!
                        com.ExecuteNonQuery();
                    }
                }
                tx.Complete();
            }*/



        }
    }
}

