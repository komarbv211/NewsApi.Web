using NewsApi.Core.Interfaces;

namespace NewsApi.Core.Entities
{
    public class News : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string FullText { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public int AuthorsId { get; set; }

    }
}
