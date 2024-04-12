
using Interface.Services.DTO;
using Interface.Services.DTO_User;
using Models;
using Repository;
using Services;

Repository<Book> bookrepository = new Repository<Book>();
Repository<LibraryUser> libraryUsersrepository = new Repository<LibraryUser>();
Repository<BookHistory> bookHistoryrepository = new Repository<BookHistory>();

BookServise bookServise = new BookServise(bookrepository);
LibraryService libraryService = new LibraryService(bookrepository, libraryUsersrepository, bookHistoryrepository );
UserServise userServise = new UserServise(libraryUsersrepository, bookHistoryrepository, bookrepository);

BookCreateDTO Hamlet = new BookCreateDTO("Hamlet", null, "Shakespear");
BookCreateDTO FairytalesOfTheWorld = new BookCreateDTO ("Fairytales Of the World", null, null);

//bookServise.CreateBook(FairytalesOfTheWorld);
//userServise.CreateUser(new UserCreateDTO("Lilia Brechko", DateOnly.FromDateTime(new DateTime(1992, 10, 9)), null));

libraryService.GetBooks(1, 1);

