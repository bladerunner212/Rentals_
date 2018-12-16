using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Infrastructure;

namespace Rentals.DataBase
{
    internal class DatabaseOpenConnectionBehavior_
    {
        public static void DatabaseOpenConnectionBehavior()
        {
            using (var context = new AppContext())
            {
                // At this point the underlying store connection is closed

                context.Database.Connection.Open();

                // Now the underlying store connection is open and the
                // ObjectContext.Connection.State correctly reports open too

                var user = new User { /* Blog’s properties */ };
                context.Users.Add(user);
                context.SaveChanges();

                // The underlying store connection remains open for the next operation  

                user = new User { /* Blog’s properties */ };
                context.Users.Add(user);
                context.SaveChanges();

                // The underlying store connection is still open

            } // The context is disposed – so now the underlying store connection is closed
        }
    }
}
