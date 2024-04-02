﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public bool IsAvailable { get; set; }
        
        public IEnumerable<LibraryUser>? UsersHistory { get; set; }
        public IEnumerable<BookHistory>? BookHistories { get; set; }

    }
}
