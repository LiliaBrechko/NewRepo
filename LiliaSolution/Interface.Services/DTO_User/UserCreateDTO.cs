using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Services.DTO_User
{
    public class UserCreateDTO
    {
        public UserCreateDTO(string? name, DateOnly dateOfBirth, string? adress)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Adress = adress;
        }

        public string? Name { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string? Adress { get; set; }
    }
}
