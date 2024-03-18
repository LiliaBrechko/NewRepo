using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Interface.Services.Sets.Dto
{
    public class SetDateInfo
    {
        public int Id { get; set; }

        public int Reps { get; set; }

        public double Weight { get; set; }

        public int ExerciseId { get; set; }

        public string ExerciseName { get; set; } = default!;

        public bool ExerciseIsActive { get; set; }

        public int TrainingSessionId { get; set; }

        public DateTimeOffset TrainingSessionDate { get; set; }
    }
}
