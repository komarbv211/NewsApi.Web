using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.DTOs
{
    public class NewsInsertDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string FullText { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public int? AuthorsId { get; set; }
        public string? Images { get; set; }

    }
}
