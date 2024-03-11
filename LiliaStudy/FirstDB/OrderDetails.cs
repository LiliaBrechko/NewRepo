using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDB
{
    public class OrderDetails
    {
        [Key]
        public int Id { get; set; }

        public int OrderId { get; set; }
        public int ProductId {  get; set; }
        public Order Order { get; set; } = null!;
        public Product Product { get; set; } = null!;
        public int Quantity { get; set; }
    }
}
