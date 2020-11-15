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
    public class Result
    {
        public Id Id { get; set; }

        public Guid HopperId { get; set; }

        public Guid MapId { get; set; }

        public MapVariant MapVariant { get; set; }

        public Guid GameVariantId { get; set; }

        public string MatchDuration { get; set; }

        public GameVariant GameVariant { get; set; }

        public List<Team> Teams { get; set;}

        public List<Players> Players { get; set; }

        public bool IsTeamGame { get; set; }


    }
}
