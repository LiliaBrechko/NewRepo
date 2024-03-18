namespace GYM.Interface.Services.Exercises.Dto
{
    public class CreateExerciseDto
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }

        public bool IsActive { get; set; }
    }
}
