using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Expert : BaseEntity
    {
        public string? Name { get; set; }
        public string? Position { get; set; }
        public byte[]? Image { get; set; }
    }
}
