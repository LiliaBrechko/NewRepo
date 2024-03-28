using GYM.Interface.Repositories;
using GYM.Interface.Services.Exercises.Dto;
using GYM.Interface.Services.Profile;
using GYM.Interface.Services.Profile.Dto;
using GYM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IRepository<Profile> repository;

        public ProfileService(IRepository<Profile> repository)
        {
            this.repository = repository;
        }

        public int AddProfile(CreateProfileDto createProfileDto)
        {
            var existing = repository.GetAll().FirstOrDefault(e => e.Name == createProfileDto.Name);

            if (existing != null)
            {
                throw new ApplicationException($"{typeof(Profile).Name} with name '{createProfileDto.Name}' already exists");
            }

            return repository.Create(new Profile
            {
                Name = createProfileDto.Name,
                Description = createProfileDto.Description,
                IsActive = createProfileDto.IsActive
            });
        }

        public void ChangeStatus(int id, bool isActive)
        {
            var profile = repository.Get(id);

            repository.Update(id, new Profile
            {
                Id = id,
                Name = profile.Name,
                Description = profile.Description,
                IsActive = isActive
            });
        }

        public void DeleteProfile(int id)
        {
            repository.Delete(id);
        }

        public IEnumerable<ProfileCard> GetAllProfiles()
        {
            var profiles = repository.GetAll();

            return profiles.Select(e => new ProfileCard
            {
                Id = e.Id,
                Name = e.Name,
                Description = e.Description,
                IsActive = e.IsActive
            }).ToArray();
        }

        public ProfileCard GetProfile(int id)
        {
            var profile = repository.Get(id);

            return new ProfileCard
            {
                Id = profile.Id,
                Name = profile.Name,
                Description = profile.Description,
                IsActive = profile.IsActive
            };
        }

        public void UpdateProfile(int id, CreateProfileDto createProfileDto)
        {
            repository.Update(id, new Profile
            {
                Id = id,
                Name = createProfileDto.Name,
                Description = createProfileDto.Description,
                IsActive = createProfileDto.IsActive
            });
        }
    }
}
