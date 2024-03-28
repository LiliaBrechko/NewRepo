using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Interface.Services.Profile.Dto
{
    public class ProfileCard
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public bool IsActive { get; set; }
        public string? Description { get; set; }
    }
}
