namespace FootballArchive.Core.Entities
{
    public class PersonSquad
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int SquadId { get; set; }
        public Squad Squad { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}