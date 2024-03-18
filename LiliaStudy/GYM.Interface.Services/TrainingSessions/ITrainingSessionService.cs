using GYM.Interface.Services.Sets.Dto;
using GYM.Interface.Services.TrainingSessions.Dto;

namespace GYM.Interface.Services.TrainingSessions
{
    public interface ITrainingSessionService
    {
        int AddTrainingSession(IEnumerable<CreateSetDto>? sets = null, DateTimeOffset? dateTimeOffset = null);

        void UpdateTrainingSession(int id, IEnumerable<CreateSetDto>? sets = null, DateTimeOffset? dateTimeOffset = null);

        void DeleteTrainingSession(int id);

        IEnumerable<TrainingSessionCard> GetAllTrainingSessions();

        TrainingSessionCard GetTrainingSession(int id);
    }
}
