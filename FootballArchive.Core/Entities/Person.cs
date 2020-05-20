using System;
using System.Collections.Generic;

namespace FootballArchive.Core.Entities
{
    public class Person
    {
        public int PersonId { get; set; }
        public string PersonFirstName { get; set; }
        public string PersonLastName { get; set; }
        public string PlaceOfBirth { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfDeath { get; set; }
        public string PersonFullFirstName { get; set; }
        public string PersonFullMiddleName { get; set; }
        public string PersonFullLastName { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        public string Foot { get; set; }
        public string PersonHomepage { get; set; }
        public ICollection<Nationality> Nationalities { get; set; }
        public ICollection<PersonSquad> Squads { get; set; }
        public ICollection<Statistic> Statistics { get; set; }
    }
}