using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentals.DataBase
{
    class Car : AbstractEntity
    {
        public string brand { get; set; }
        public string model { get; set; }
        public int power { get; set; }
        public int maxSpeed { get; set; }
        public string transmission { get; set; }
        public int year { get; set; }
        public string type { get; set; }
        public string color { get; set; }
        public string country { get; set; }
        public bool owned { get; set; }
        public List<CarOwn> carOwns { get; set; }
    }
}
