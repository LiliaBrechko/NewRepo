namespace Models
{
    public class LibraryUser : IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string? Adress {  get; set; }

        public IEnumerable<Book>? Books { get; set; }
        public IEnumerable<BookHistory>? BookHistories { get; set; }
    }
}
