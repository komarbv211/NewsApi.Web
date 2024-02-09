using NewsApi.Core.Interfaces;

namespace NewsApi.Core.Entities
{
    public class Statistics : IEntity
    {
        public int Id { get; set; }
        public DateTime VisitTime { get; set; }
        public int NewsId { get; set; }
        public string IpAddress { get; set; }
    }
}
