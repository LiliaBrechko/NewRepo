using Interface.Services.DTO.User;
using Interface.Services.DTO_User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Services
{
    public interface IUserServise
    {
        IEnumerable<UserListItemDTO> GetUsersList();    
        UserCardDTO GetUserCard(int id);
        int CreateUser(UserCreateDTO userCreateDTO);


    }
}
