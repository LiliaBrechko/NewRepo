using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Services.DTO
{
    public class BookCreateDTO
    {
        public BookCreateDTO(string? title, string? description, string? author)
        {
            Title = title;
            Description = description;
            Author = author;
        }

        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
    }
}
