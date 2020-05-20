using System.Collections.Generic;

namespace FootballArchive.Core.Entities
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public ICollection<PersonSquad> People { get; set; }
    }
}