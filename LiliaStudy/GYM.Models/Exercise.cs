using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GYM.Models
{
    [Table("GYM_EXERCISE")]
    public class Exercise : IEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = default!;

        public string? Description { get; set; }

        public bool IsActive { get; set; }

        public int ProfileId { get; set; }

        [ForeignKey(nameof(ProfileId))]
        public Profile? Profile { get; set; }

        public virtual ICollection<Set>? Sets { get; set; }
    }
}