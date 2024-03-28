using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GYM.Models
{
    [Table("GYM_PROFILE")]
    public class Profile : IEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = default!;

        public string? Description { get; set; } = default!;

        public bool IsActive { get; set; }

        public virtual ICollection<Exercise>? Exercises { get; set; }

        public virtual ICollection<TrainingSession>? TrainingSessions { get; set; }

        public virtual ICollection<BodyWeight>? BodyWeights { get; set; }

        public static int Current
        {
            get
            {
                if (current == null)
                {
                    throw new ApplicationException("Profile is not set. Please choose or create one.");
                }

                return current.Value;
            }
            set => current = value;
        }

        private static int? current;

    }
}
