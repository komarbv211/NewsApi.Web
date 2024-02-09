using NewsApi.Core.Interfaces;

namespace NewsApi.Core.Entities
{
    public class Authors : IEntity
    {
        public int Id { get; set; }

        public string FullName { get; set; } = string.Empty;

        public string? Pseudonym { get; set; }
    }
}
