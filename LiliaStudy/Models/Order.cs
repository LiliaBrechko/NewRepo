using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDB
{
    public class Order : IEntity
    {
        [Key]
        public int Id {  get; set; }
        public int CustomerId {  get; set; }
        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; } = null!;
        public IEnumerable<OrderDetails> OrderDetails  { get; set; } = null!;
    }
}
