using GYM.Interface.Services.Body.Dto;

namespace GYM.Interface.Services.Body
{
    public interface IBodyWeightService
    {
        int AddBodyWeight(CreateBodyWeightDto createBodyWeightDto);

        void UpdateBodyWeight(int id, CreateBodyWeightDto createBodyWeightDto);

        void DeleteBodyWeight(int id);

        IEnumerable<BodyWeightCard> GetAllBodyWeights();

        BodyWeightCard GetBodyWeight(int id);
    }
}
