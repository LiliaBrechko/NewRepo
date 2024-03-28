using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GYM.Models
{
    [Table("GYM_TRAINING_SESSION")]
    public class TrainingSession : IEntity
    {
        [Key]
        public int Id { get; set; }

        public int ProfileId { get; set; }

        [ForeignKey(nameof(ProfileId))]
        public Profile? Profile { get; set; }

        public DateTimeOffset DateTime { get; set; }

        public virtual ICollection<Set>? Sets { get; set; }
    }
}