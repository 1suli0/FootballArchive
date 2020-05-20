using System.Collections.Generic;

namespace FootballArchive.Core.Entities
{
    public class League
    {
        public int LeagueId { get; set; }
        public string LeagueName { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<LeagueSeason> Seasons { get; set; }
        public ICollection<Statistic> Statistics { get; set; }
    }
}