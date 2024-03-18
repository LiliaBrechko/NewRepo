using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GYM.Models
{
    [Table("GYM_SET")]
    public class Set : IEntity
    {
        [Key]
        public int Id { get; set; }

        public int Reps { get; set; }

        public double Weight { get; set; }

        public int ExerciseId { get; set; }

        public int TrainingSessionId { get; set; }

        [ForeignKey(nameof(ExerciseId))]
        public Exercise? Exercise { get; set; }

        [ForeignKey(nameof(TrainingSessionId))]
        public TrainingSession? TrainingSession { get; set; }
    }
}