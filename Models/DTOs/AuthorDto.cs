using Company.Core.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Core.DTOs
{
    public record AuthorDto
    {
        public Guid AuthorId { get; init; }
        public string? FirstName { get; init; }

        public string? LastName { get; init; }

        public string? Email { get; init; }

        public string? Bio { get; init; }

        public string? ProfilePictureUrl { get; init; }

        public IEnumerable<Article>? Articles { get; init; }
    }
}
