namespace FootballArchive.Core.Entities
{
    public class Statistic
    {
        public int StatisticId { get; set; }
        public short? MatchesPlayed { get; set; }
        public short Goals { get; set; }
        public short? StartingLineUp { get; set; }
        public short? SubstitueIn { get; set; }
        public short? SubstitueOut { get; set; }
        public short YellowCards { get; set; }
        public short SecondYellowCards { get; set; }
        public short RedCards { get; set; }
        public int StatisticTypeId { get; set; }
        public StatisticType StatisticType { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int LeagueId { get; set; }
        public League League { get; set; }
        public int SeasonId { get; set; }
        public Season Season { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}