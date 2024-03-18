namespace GYM.Interface.Services.Exercises.Dto
{
    public class ExerciseListItem
    {
        public string Name { get; set; } = default!;
        public bool IsActive { get; set; }
        public int Id { get; set; }
    }
}
