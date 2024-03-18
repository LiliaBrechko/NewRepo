using GYM.Interface.Services.Exercises.Dto;

namespace GYM.Interface.Services.Exercises
{
    public interface IExerciseService
    {
        int AddExercise(CreateExerciseDto createExerciseDto);

        void UpdateExercise(int id, CreateExerciseDto createExerciseDto);

        void DeleteExercise(int id);

        ExerciseCard GetExercise(int id);

        IEnumerable<ExerciseListItem> GetAllExercises();

        IEnumerable<ExerciseLastDateDto> GetAllExercisesWithLastDates();

        void ChangeStatus(int id, bool isActive);
    }
}
