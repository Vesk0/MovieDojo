using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDojo.Models
{
    public class Actor : BaseModel
    {
        public string Name { get; set; }

        public string Biography { get; set; }

        public DateTime Born { get; set; }

        public ICollection<Movie> MoviesTakenPartIn { get; set; }

        public ICollection<Image> Images { get; set; }
    }
}
