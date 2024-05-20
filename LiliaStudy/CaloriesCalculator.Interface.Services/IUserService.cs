using CaloriesCalculator.Interface.Services.DTO;

namespace CaloriesCalculator.Interface.Services
{
    public interface IUserService
    {
        int Create(CreateUserDTO createUserDTO);
        void Update(int id, UpdateUserDTO updateUserDTO);
        UserCardDTO Get(int id);
        void Delete(int id);

        double GetCalorieToEat(int userId, DateTime dateTime);


    }
}
