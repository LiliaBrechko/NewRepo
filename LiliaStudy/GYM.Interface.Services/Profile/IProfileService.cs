using GYM.Interface.Services.Exercises.Dto;
using GYM.Interface.Services.Profile.Dto;

namespace GYM.Interface.Services.Profile
{
    public interface IProfileService
    {
        int AddProfile(CreateProfileDto createExerciseDto);

        void UpdateProfile(int id, CreateProfileDto createExerciseDto);

        void DeleteProfile(int id);

        ProfileCard GetProfile(int id);

        IEnumerable<ProfileCard> GetAllProfiles();

        void ChangeStatus(int id, bool isActive);
    }
}
