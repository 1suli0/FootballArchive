namespace FootballArchive.Core.Entities
{
    public class Nationality
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}