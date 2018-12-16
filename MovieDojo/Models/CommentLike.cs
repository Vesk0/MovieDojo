using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDojo.Models
{
    public class CommentLike : BaseModel
    {
        public Comment Comment { get; set; }

        public int CommentId { get; set; }

        public IdentityUser<string> User { get; set; }

        public string UserId { get; set; }
    }
}
