using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;

namespace Rentals.DataBase
{
    class AppInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<AppContext>
    {
        protected override void Seed(AppContext context)
        {
            var users = new List<User>
            {
                new User {FirstName = "Nikita", Username = "Nik228", Email = "sas@mail.ru", Password = "qwerty123", TelNumber = 12335647  }
            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var cars = new List<Car>
            {
                new Car { brand = "Honda", color = "White", country = "Japan", maxSpeed = 220 },
                new Car { brand = "Kia", color = "DeepBlue", country = "Korea", maxSpeed = 220 }
            };
            cars.ForEach(s => context.Cars.Add(s));
            context.SaveChanges();
        }
    }
}
