namespace FootballArchive.Core.Entities
{
    public class LeagueSeason
    {
        public int SeasonId { get; set; }
        public Season Season { get; set; }
        public int LeagueId { get; set; }
        public League League { get; set; }
    }
}