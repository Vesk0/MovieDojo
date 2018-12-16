using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDojo.Models
{
    public class Movie : BaseModel
    {
        public string Name { get; set; } 

        public int Length { get; set; } 

        public ICollection<Genre> Genres { get; set; } 

        public DateTime ReleaseDate { get; set; } 

        public string Description { get; set; }

        public ICollection<Image> Image { get; set; }

        public Image CoverImage { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public Rating Rating { get; set; }

        public ICollection<Actor> Actors { get; set; }
    }
}
