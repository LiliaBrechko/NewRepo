using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Interface.Services.Body.Dto
{
    public class BodyWeightCard 
    {
        public int Id { get; set; }

        public int ProfileId { get; set; }

        public DateTimeOffset DateTime { get; set; }

        public double Weight { get; set; }
    }
}
