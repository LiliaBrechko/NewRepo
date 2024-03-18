using GYM.Interface.Repositories;
using GYM.Interface.Services.Sets;
using GYM.Interface.Services.Sets.Dto;
using GYM.Models;

namespace GYM.Services
{
    public class SetService : ISetService
    {
        private readonly IRepository<Set> repository;

        public SetService(IRepository<Set> repository)
        {
            this.repository = repository;
        }

        public int AddSet(CreateSetDto createSetDto)
        {
            return repository.Create(new Set
            {
                Reps = createSetDto.Reps,
                Weight = createSetDto.Weight,
                ExerciseId = createSetDto.ExerciseId,
                TrainingSessionId = createSetDto.TrainingSessionId
            });
        }

        public void DeleteSet(int id)
        {
            repository.Delete(id);
        }

        public IEnumerable<SetCard> GetAllSets()
        {
            var sets = repository.GetAll(s => s.Exercise!);

            return sets.Select(e => new SetCard
            {
                Id = e.Id,
                ExerciseId = e.ExerciseId,
                TrainingSessionId = e.TrainingSessionId,
                Weight = e.Weight,
                Reps = e.Reps,
                ExerciseName = e.Exercise!.Name,
                ExerciseIsActive = e.Exercise!.IsActive
            }).ToArray();
        }

        public SetCard GetSet(int id)
        {
            var set = repository.Get(id, s => s.Exercise!);

            return new SetCard
            {
                Id = set.Id,
                ExerciseId = set.ExerciseId,
                TrainingSessionId = set.TrainingSessionId,
                Weight = set.Weight,
                Reps = set.Reps,
                ExerciseName = set.Exercise!.Name,
                ExerciseIsActive = set.Exercise!.IsActive
            };
        }

        public IEnumerable<SetDateInfo> GetSetDateInfos()
        {
            var sets = repository.GetAll(s => s.TrainingSession!, s => s.Exercise!);

            return sets.Select(s => new SetDateInfo
            {
                Id = s.Id,
                ExerciseId = s.ExerciseId,
                ExerciseName = s.Exercise!.Name,
                Reps = s.Reps,
                Weight = s.Weight,
                TrainingSessionId = s.TrainingSessionId,
                TrainingSessionDate = s.TrainingSession!.DateTime,
                ExerciseIsActive= s.Exercise!.IsActive
            });
        }

        public void UpdateSet(int id, CreateSetDto createSetDto)
        {
            repository.Update(id, new Set
            {
                Id = id,
                Reps = createSetDto.Reps,
                Weight = createSetDto.Weight,
                ExerciseId = createSetDto.ExerciseId,
                TrainingSessionId = createSetDto.TrainingSessionId
            });
        }
    }
}
