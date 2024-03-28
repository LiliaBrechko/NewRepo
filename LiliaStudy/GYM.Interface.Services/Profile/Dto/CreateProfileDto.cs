using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Interface.Services.Profile.Dto
{
    public class CreateProfileDto
    {
        public string Name { get; set; } = default!;

        public string? Description { get; set; }

        public bool IsActive { get; set; }
    }
}
