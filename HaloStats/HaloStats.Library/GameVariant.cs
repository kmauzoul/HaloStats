using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloStats.Library
{
    public class GameVariant
    {
        public int ResourceType { get; set; }

        public Guid ResourceId { get; set; }

        public int OwnerType { get; set; }

        public string Owner { get; set; }
    }
}
