using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Interface.Services.Exercises.Dto
{
    public class ExerciseLastDateDto
    {
        public int Id { get; set; }

        public int ProfileId { get; set; }

        public string Name { get; set; } = default!;

        public bool IsActive { get; set; }

        public DateTimeOffset? LastDateTime { get; set; }
    }
}
