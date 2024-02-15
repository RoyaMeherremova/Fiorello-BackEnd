using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Say : BaseEntity
    {
        public string? Image { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Position { get; set; }
    }
}
