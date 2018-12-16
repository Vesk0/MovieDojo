using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDojo.Models.ViewModels
{
    public class MoviePageViewModel
    {
        public string Name { get; set; } 

        public int Length { get; set; } 

        public List<Genre> Geners { get; set; } 

        public string ImageUrl { get; set; } 
    }
}
