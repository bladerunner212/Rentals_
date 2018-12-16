using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rentals.DataBase
{
    class CarOwn : AbstractEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public DateTime dateOfStart { get; set; }
        public DateTime dateOfEnd { get; set; }
        public int price { get; set; }
        public bool closed { get; set; }
        public Car car { get; set; }
        public User owner { get; set; }
    }
}
