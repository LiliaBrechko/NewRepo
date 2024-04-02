using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Services.DTO_User
{
    public class UserCardDTO
    {
        public string? Name { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string? Adress { get; set; }

        public IEnumerable<string>? Books { get; set; }

    }
}
