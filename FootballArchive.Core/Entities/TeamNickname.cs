namespace FootballArchive.Core.Entities
{
    public class TeamNickname
    {
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int NicknameId { get; set; }
        public Nickname Nickname { get; set; }
    }
}