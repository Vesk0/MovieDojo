using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDojo.Models
{
    public class Image : BaseModel
    {
        public byte[] Content { get; set; }
    }
}
