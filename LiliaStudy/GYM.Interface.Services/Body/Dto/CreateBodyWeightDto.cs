using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Interface.Services.Body.Dto
{
    public class CreateBodyWeightDto
    {
        public DateTimeOffset DateTime { get; set; }

        public double Weight { get; set; }
    }
}
