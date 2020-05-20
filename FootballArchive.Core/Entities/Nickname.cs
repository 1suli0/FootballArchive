using System.Collections.Generic;

namespace FootballArchive.Core.Entities
{
    public class Nickname
    {
        public int NicknameId { get; set; }
        public string Nick { get; set; }
        public ICollection<TeamNickname> Teams { get; set; }
    }
}