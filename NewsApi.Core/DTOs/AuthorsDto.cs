using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.DTOs
{
    public class AuthorsDto
    {
        public string FullName { get; set; } = string.Empty;

        public string? Pseudonym { get; set; }

    }
}
