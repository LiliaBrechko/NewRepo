using Interface.Repository;
using Interface.Services;
using Interface.Services.DTO;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{

    public class BookServise : IBookServise
    {
        private readonly IRepository<Book> _bookRepository;

        public BookServise(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public int CreateBook(BookCreateDTO bookCreate)
        {
            var book = new Book() { Author = bookCreate.Author, Title = bookCreate.Title, Description = bookCreate.Description, IsAvailable = true };
            _bookRepository.Create(book);
            return book.Id;
        }

        public BookCardDTO GetBookCard(int id)
        {
            var book = _bookRepository.Get(id);
            return new BookCardDTO() { Title = book.Title, Description = book.Description, Author = book.Author };
        }

        public IEnumerable<BookListItemDTO> GetListItems()
        {
            return _bookRepository.GetAll().Select(x => new BookListItemDTO() { Author = x.Author, Name = x.Title });
        }
    }
}
