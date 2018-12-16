using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDojo.Models.Contracts
{
    public interface IAudidInfo
    {
        DateTime CreatedOn { get; set; }

        DateTime? ModifitedOn { get; set; }
    }
}
