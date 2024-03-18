namespace GYM.Interface.Services.Sets.Dto
{
    public class CreateSetDto
    {
        public int Reps { get; set; }

        public double Weight { get; set; }

        public int ExerciseId { get; set; }

        public int TrainingSessionId { get; set; }
    }
}
