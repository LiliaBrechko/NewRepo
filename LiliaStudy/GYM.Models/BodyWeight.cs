using System.ComponentModel.DataAnnotations.Schema;

namespace GYM.Models
{
    [Table("GYM_BODY_WEIGHT")]
    public class BodyWeight : IEntity
    {
        public int Id { get; set; }

        public int ProfileId { get; set; }

        [ForeignKey(nameof(ProfileId))]
        public Profile? Profile { get; set; }

        public DateTimeOffset DateTime { get; set; }

        public double Weight { get; set; }
    }
}
