using GYM.Interface.Services.Sets.Dto;

namespace GYM.Interface.Services.TrainingSessions.Dto
{
    public class TrainingSessionCard
    {
        public int Id { get; set; }

        public DateTimeOffset DateTime { get; set; }

        public IEnumerable<SetCard> Sets { get; set; } = Array.Empty<SetCard>();
    }
}
