using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDojo.Models
{
    public class Comment : BaseModel
    {
        public IdentityUser<string> Author { get; set; }

        public string Text { get; set; }

        public ICollection<CommentLike> Likes { get; set; }
    }
}
