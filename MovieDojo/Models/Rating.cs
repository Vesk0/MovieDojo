using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDojo.Models
{
    public class Rating : BaseModel
    {
        public int Stars { get; set; }

        public string Review { get; set; }

    }
}
