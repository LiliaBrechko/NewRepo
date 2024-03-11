using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDB
{
    [Table("People")]
    public class Customer
    {
        

        [Column("Customer_id")]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Adress { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public IEnumerable<Order> Orders { get; set; } = null!;

    }
}
