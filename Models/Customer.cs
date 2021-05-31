using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_app.Models
{
    [Table("Customertable")]
    public class Customer
    {
        public int ID { get; set; }
        public String Username  { get; set; }

        [Required][MinLength(8)]
        public string Password { get; set; }
    }
}
