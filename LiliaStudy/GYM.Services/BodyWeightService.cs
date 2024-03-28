using GYM.Interface.Repositories;
using GYM.Interface.Services.Body;
using GYM.Interface.Services.Body.Dto;
using GYM.Models;

namespace GYM.Services
{
    public class BodyWeightService : IBodyWeightService
    {
        private readonly IRepository<BodyWeight> repository;

        public BodyWeightService(IRepository<BodyWeight> repository)
        {
            this.repository = repository;
        }

        public int AddBodyWeight(CreateBodyWeightDto createBodyWeightDto)
        {
            return repository.Create(new BodyWeight
            {
                DateTime = createBodyWeightDto.DateTime,
                Weight = createBodyWeightDto.Weight,
                ProfileId = createBodyWeightDto.ProfileId
            });
        }

        public void DeleteBodyWeight(int id)
        {
            repository.Delete(id);
        }

        public IEnumerable<BodyWeightCard> GetAllBodyWeights()
        {
            var bodyWeights = repository.GetAll();

            return bodyWeights.Select(e => new BodyWeightCard
            {
                Id = e.Id,
                DateTime = e.DateTime,
                Weight = e.Weight,
                ProfileId = e.ProfileId
            }).ToArray();
        }

        public BodyWeightCard GetBodyWeight(int id)
        {
            var bodyWeight = repository.Get(id);

            return new BodyWeightCard
            {
                Id = bodyWeight.Id,
                DateTime = bodyWeight.DateTime,
                Weight = bodyWeight.Weight,
                ProfileId = bodyWeight.ProfileId
            };
        }

        public void UpdateBodyWeight(int id, CreateBodyWeightDto createBodyWeightDto)
        {
            repository.Update(id, new BodyWeight
            {
                Id = id,
                DateTime = createBodyWeightDto.DateTime,
                Weight = createBodyWeightDto.Weight,
                ProfileId = createBodyWeightDto.ProfileId
            });
        }
    }
}
