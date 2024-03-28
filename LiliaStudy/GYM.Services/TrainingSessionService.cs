using GYM.Interface.Repositories;
using GYM.Interface.Services.Exercises.Dto;
using GYM.Interface.Services.Sets;
using GYM.Interface.Services.Sets.Dto;
using GYM.Interface.Services.TrainingSessions;
using GYM.Interface.Services.TrainingSessions.Dto;
using GYM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Services
{
    public class TrainingSessionService : ITrainingSessionService
    {
        private readonly IRepository<TrainingSession> repository;
        private readonly ISetService setService;

        public TrainingSessionService(IRepository<TrainingSession> repository, ISetService setService)
        {
            this.repository = repository;
            this.setService = setService;
        }

        public int AddTrainingSession(int profileId, IEnumerable<CreateSetDto>? sets = null, DateTimeOffset? dateTimeOffset = null)
        {
            var sessionId = repository.Create(new TrainingSession
            {
                DateTime = dateTimeOffset ?? DateTimeOffset.Now,
                ProfileId = profileId
            });

            if (sets != null)
            {
                foreach (var set in sets)
                {
                    set.TrainingSessionId = sessionId;
                    setService.AddSet(set);
                }
            }

            return sessionId;
        }

        public void DeleteTrainingSession(int id)
        {
            repository.Delete(id);
        }

        public IEnumerable<TrainingSessionCard> GetAllTrainingSessions()
        {
            var sessions = repository.GetAll();

            return sessions.Select(e => new TrainingSessionCard
            {
                Id = e.Id,
                ProfileId = e.ProfileId,
                DateTime = e.DateTime,
                Sets = e.Sets!.Select(s => new SetCard
                {
                    ExerciseId = s.ExerciseId,
                    ExerciseName = s.Exercise!.Name,
                    ExerciseIsActive = s.Exercise!.IsActive,
                    Id = s.Id,
                    Reps = s.Reps,
                    Weight = s.Weight,
                    TrainingSessionId = s.TrainingSessionId
                }).ToArray()
            }).ToArray();
        }

        public TrainingSessionCard GetTrainingSession(int id)
        {
            var session = repository.Get(id, t => t.Sets!, t => t.Sets!.Select(s => s.Exercise));

            return new TrainingSessionCard
            {
                Id = session.Id,
                ProfileId = session.ProfileId,
                DateTime = session.DateTime,
                Sets = session.Sets!.Select(s => new SetCard
                {
                    ExerciseId = s.ExerciseId,
                    ExerciseName = s.Exercise!.Name,
                    ExerciseIsActive = s.Exercise!.IsActive,
                    Id = s.Exercise.Id,
                    Reps = s.Reps,
                    Weight = s.Weight,
                    TrainingSessionId = s.TrainingSessionId
                }).ToArray()
            };
        }

        public void UpdateTrainingSession(int id, int profileId, IEnumerable<CreateSetDto>? sets = null, DateTimeOffset? dateTimeOffset = null)
        {
            if (dateTimeOffset != null)
            {
                repository.Update(id, new TrainingSession
                {
                    Id = id,
                    DateTime = dateTimeOffset.Value,
                    ProfileId = profileId
                });
            }

            if (sets != null)
            {
                var setsToRemove = setService.GetAllSets().Where(s => s.TrainingSessionId == id);

                foreach (var set in setsToRemove)
                {
                    setService.DeleteSet(set.Id);
                }

                foreach (var set in sets)
                {
                    set.TrainingSessionId = id;
                    setService.AddSet(set);
                }
            }
        }
    }
}
