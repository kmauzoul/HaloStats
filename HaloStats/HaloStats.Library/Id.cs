using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://developer.haloapi.com/docs/services/58acdf27e2f7f71ad0dad84b/operations/Halo-5-Player-Match-History?
/// </summary>

namespace HaloStats.Library
{
    public class Id
    {
        public Guid MatchId { get; set; }

        public int GameMode { get; set; }
    }
}
