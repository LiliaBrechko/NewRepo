
using Interface.Services.DTO;
using Models;
using Repository;
using Services;

Repository<Book> bookrepository = new Repository<Book>();
Repository<LibraryUser> libraryUsersrepository = new Repository<LibraryUser>();
Repository<BookHistory> bookHistoryrepository = new Repository<BookHistory>();

BookServise bookServise = new BookServise(bookrepository);
LibraryService libraryService = new LibraryService(bookrepository, libraryUsersrepository, bookHistoryrepository );
UserServise userServise = new UserServise(libraryUsersrepository, bookHistoryrepository, bookrepository);

//BookCreateDTO book1 = new BookCreateDTO("")