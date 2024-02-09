using NewsApi.Core.Interfaces;

namespace NewsApi.Core.Entities
{
    public class Roles : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
