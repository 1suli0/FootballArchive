using System;
using System.Collections.Generic;

namespace FootballArchive.Core.Entities
{
    public class Season
    {
        public int SeasonId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public ICollection<Squad> Squads { get; set; }
        public ICollection<LeagueSeason> Leagues { get; set; }
        public ICollection<Statistic> Statistics { get; set; }
    }
}