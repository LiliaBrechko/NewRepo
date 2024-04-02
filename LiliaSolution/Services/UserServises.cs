using Interface.Repository;
using Interface.Services;
using Interface.Services.DTO.User;
using Interface.Services.DTO_User;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserServise : IUserServise
    {
        private readonly IRepository<LibraryUser> _libraryUserRepository;
        private readonly IRepository<BookHistory> _bookHistoryRepository;
        private readonly IRepository<Book> _bookRepository;

        public UserServise(IRepository<LibraryUser> libraryUserRepository, IRepository<BookHistory> bookHistoryRepository, IRepository<Book> bookRepository)
        {
            _libraryUserRepository = libraryUserRepository;
            _bookHistoryRepository = bookHistoryRepository;
            _bookRepository = bookRepository;
        }

        public int CreateUser(UserCreateDTO userCreateDTO)
        {
            var user = new LibraryUser() { Name = userCreateDTO.Name, Adress = userCreateDTO.Adress, DateOfBirth = userCreateDTO.DateOfBirth };
             return _libraryUserRepository.Create(user);
            

        }

        public UserCardDTO GetUserCard(int id)
        {
            var user = _libraryUserRepository.Get(id);
            var bookshistoryIDs = _bookHistoryRepository.GetAll().Where(x => x.UserID == id && x.ReturnDate == null).
                Select(x => x.Id);
            var books = _bookRepository.GetAll().Where(x => bookshistoryIDs.Contains(x.Id)).Select(x=> x.Title);
            return new UserCardDTO { Name = user.Name, Adress = user.Adress, DateOfBirth = user.DateOfBirth, Books = books };
        }

        public IEnumerable<UserListItemDTO> GetUsersList()
        {
            return _libraryUserRepository.GetAll().Select(x => new UserListItemDTO { Name = x.Name });
        }
    }
}
