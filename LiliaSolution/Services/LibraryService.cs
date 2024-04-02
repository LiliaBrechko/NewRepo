using Interface.Repository;
using Interface.Services;
using Models;

namespace Services
{
    public class LibraryService : ILibraryService
    {
        private IRepository<Book> BookRepository;
        private IRepository<LibraryUser> Libraryuserrepo;
        private IRepository<BookHistory> BookHistoryRepository;

        public LibraryService(IRepository<Book> bookrepository, IRepository<LibraryUser> libraryuserrepo, IRepository<BookHistory> bookHistoryRepository)
        {
            BookRepository = bookrepository;
            Libraryuserrepo = libraryuserrepo;
            BookHistoryRepository = bookHistoryRepository;
        }
        public void GetBooks(int userid, params int[] bookIDs)
        {
            var books = BookRepository.GetAll().Where(x=> bookIDs.Contains(x.Id));
            foreach (var book in books)
            {
                if (!book.IsAvailable)
                {
                    var userID = BookHistoryRepository.GetAll().Where(x => x.BookID == book.Id).OrderBy(x => x.GetDate).Last().UserID;
                    var userName = Libraryuserrepo.Get(userID).Name;
                    throw new ApplicationException($"Book is already taken by user {userName}");
                }
                book.IsAvailable = false;
                BookRepository.Update(book.Id, book);
                var bookhistory = new BookHistory() {UserID = userid, BookID = book.Id, GetDate = DateTime.Now, ReturnDate = null };

            }
            
           
        }

        public void  ReturnBooks(int userid, params int[] bookIDs)
        {
            var bookstoreturn = BookRepository.GetAll().Where(x => bookIDs.Contains(x.Id));
            foreach (var book in bookstoreturn)
            {
                book.IsAvailable = true;
                BookRepository.Update(book.Id, book);
                var bookhistoryreturn = BookHistoryRepository.GetAll().Where(x=>x.UserID == userid && bookIDs.Contains(x.Id) 
                && x.ReturnDate == null);
                foreach(var returnbook  in bookhistoryreturn)
                {
                    returnbook.ReturnDate = DateTime.Now;
                    BookHistoryRepository.Update(returnbook.Id, returnbook);
                }
            }
            
        }
    }
}
