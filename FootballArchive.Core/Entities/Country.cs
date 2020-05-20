using System.Collections.Generic;

namespace FootballArchive.Core.Entities
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public ICollection<League> Leagues { get; set; }
        public ICollection<Team> Teams { get; set; }
        public ICollection<Stadium> Stadiums { get; set; }
        public ICollection<Nationality> Nationalities { get; set; }
    }
}