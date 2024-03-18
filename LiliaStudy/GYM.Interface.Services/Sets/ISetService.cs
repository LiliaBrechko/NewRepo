using GYM.Interface.Services.Sets.Dto;

namespace GYM.Interface.Services.Sets
{
    public interface ISetService
    {
        int AddSet(CreateSetDto createSetDto);

        void UpdateSet(int id, CreateSetDto createSetDto);

        void DeleteSet(int id);

        SetCard GetSet(int id);

        IEnumerable<SetCard> GetAllSets();

        IEnumerable<SetDateInfo> GetSetDateInfos();
    }
}
