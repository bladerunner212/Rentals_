using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentals.DataBase
{
    class User : AbstractEntity
    {
        public string FirstName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int TelNumber { get; set; }
        public string Password { get; set; }
        public List<CarOwn> carOwns { get; set; }
    }
}
