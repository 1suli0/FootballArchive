using System.Collections.Generic;

namespace FootballArchive.Core.Entities
{
    public class StatisticType
    {
        public int StatisticTypeId { get; set; }
        public string StatisticTypeName { get; set; }
        public ICollection<Statistic> Statistics { get; set; }
    }
}