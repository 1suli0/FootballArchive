using System.Collections.Generic;

namespace FootballArchive.Core.Entities
{
    public class Stadium
    {
        public int StadiumId { get; set; }
        public string StadiumName { get; set; }
        public string City { get; set; }
        public float Capacity { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}