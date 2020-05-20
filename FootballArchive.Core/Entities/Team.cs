using System;
using System.Collections.Generic;

namespace FootballArchive.Core.Entities
{
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string Federation { get; set; }
        public int FullTeamName { get; set; }
        public DateTime Founded { get; set; }
        public string Colors { get; set; }
        public double Members { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string TeamHomepage { get; set; }
        public string Email { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int StadiumId { get; set; }
        public Stadium Stadium { get; set; }
        public ICollection<TeamNickname> Nicknames { get; set; }
        public ICollection<Squad> Squads { get; set; }
        public ICollection<Statistic> Statistics { get; set; }
    }
}