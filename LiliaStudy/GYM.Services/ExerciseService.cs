using GYM.Interface.Repositories;
using GYM.Interface.Services.Exercises;
using GYM.Interface.Services.Exercises.Dto;
using GYM.Models;

namespace GYM.Services
{
    public class ExerciseService : IExerciseService
    {
        private readonly IRepository<Exercise> repository;
        private readonly IRepository<TrainingSession> repositoryTrainingSession;

        public ExerciseService(IRepository<Exercise> repository, IRepository<TrainingSession> repositoryTrainingSession)
        {
            this.repository = repository;
            this.repositoryTrainingSession = repositoryTrainingSession;
        }

        public int AddExercise(CreateExerciseDto createExerciseDto)
        {
            var existing = repository.GetAll().FirstOrDefault(e => e.Name == createExerciseDto.Name);

            if (existing != null)
            {
                throw new ApplicationException($"{typeof(Exercise).Name} with name '{createExerciseDto.Name}' already exists");
            }

            return repository.Create(new Exercise
            {
                Name = createExerciseDto.Name,
                Description = createExerciseDto.Description,
                IsActive = createExerciseDto.IsActive
            });
        }

        public void ChangeStatus(int id, bool isActive)
        {
            var exercise = repository.Get(id);

            repository.Update(id, new Exercise
            {
                Id = id,
                Name = exercise.Name,
                Description = exercise.Description,
                IsActive = isActive
            });
        }

        public void DeleteExercise(int id)
        {
            repository.Delete(id);
        }

        public IEnumerable<ExerciseListItem> GetAllExercises()
        {
            var exercises = repository.GetAll();

            return exercises.Select(e => new ExerciseListItem
            {
                Id = e.Id,
                Name = e.Name,
                IsActive = e.IsActive
            }).ToArray();
        }

        public IEnumerable<ExerciseLastDateDto> GetAllExercisesWithLastDates()
        {
            var sessionsWithDates = repositoryTrainingSession.GetAll().ToDictionary(t => t.Id, t => t.DateTime);
            var exercises = repository.GetAll(e => e.Sets!).Select(e => new { Exercise = e, TrainingSessionDates = e.Sets!.Select(s => sessionsWithDates[s.TrainingSessionId]) });

            return exercises.Select(e => new ExerciseLastDateDto
            {
                Id = e.Exercise.Id,
                Name = e.Exercise.Name,
                LastDateTime = e.TrainingSessionDates.OrderByDescending(t => t).FirstOrDefault(),
                IsActive = e.Exercise.IsActive
            });
        }

        public ExerciseCard GetExercise(int id)
        {
            var exercise = repository.Get(id);

            return new ExerciseCard
            {
                Id = exercise.Id,
                Name = exercise.Name,
                Description = exercise.Description,
                IsActive = exercise.IsActive
            };
        }

        public void UpdateExercise(int id, CreateExerciseDto createExerciseDto)
        {
            repository.Update(id, new Exercise
            {
                Id = id,
                Name = createExerciseDto.Name,
                Description = createExerciseDto.Description,
                IsActive = createExerciseDto.IsActive
            });
        }
    }
}