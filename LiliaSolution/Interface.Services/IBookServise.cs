using Interface.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Services
{
    public interface IBookServise
    {
        IEnumerable<BookListItemDTO> GetListItems();
        BookCardDTO GetBookCard(int id);
        int CreateBook(BookCreateDTO bookCreate);
    }
}
