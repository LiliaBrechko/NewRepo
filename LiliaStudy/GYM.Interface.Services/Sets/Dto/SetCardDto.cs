using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
namespace GYM.Interface.Services.Sets.Dto
{
    public class SetCard
    {
        public int Id { get; set; }

        public int Reps { get; set; }

        public double Weight { get; set; }

        public int ExerciseId { get; set; }

        public bool ExerciseIsActive { get; set; }

        public string ExerciseName { get; set; } = default!;

        public int TrainingSessionId { get; set; }
    }
}
