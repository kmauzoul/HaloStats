using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloStats.Library
{
    public class Players
    {
        public Player Player { get; set; }

        public int TeamId { get; set; }

        public int Rank { get; set; }

        public int Result { get; set; }

        public int TotalKills { get; set; }

        public int TotalDeaths { get; set; }

        public int TotalAssists { get; set; }
    }
}
