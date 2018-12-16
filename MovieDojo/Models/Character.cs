using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDojo.Models
{
    public class Character : BaseModel
    {
        public Actor Actor { get; set; }

        public string Name { get; set; }

        public ICollection<Image> Images { get; set; }
    }
}
