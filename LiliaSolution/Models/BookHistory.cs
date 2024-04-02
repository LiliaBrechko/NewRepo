using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BookHistory : IEntity
    {
        public int Id { get; set; }
        
        public int UserID { get; set; }

        [ForeignKey(nameof(UserID))]
        public LibraryUser? LibraryUser { get; set; }

        public int BookID { get; set; }
        [ForeignKey(nameof(BookID))]
        public Book? Book { get; set; }
        public DateTime GetDate {  get; set; }
        public DateTime? ReturnDate { get; set; }

    }
}
