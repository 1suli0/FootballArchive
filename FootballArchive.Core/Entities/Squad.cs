using System.Collections.Generic;

namespace FootballArchive.Core.Entities
{
    public class Squad
    {
        public int SquadId { get; set; }
        public int SeasonId { get; set; }
        public Season Season { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public ICollection<PersonSquad> People { get; set; }
    }
}