using Company.Core.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Core.DTOs
{
    public record ArticleForCreationDto
    {
        public Guid AuthorId { get; init; }
        public string? ArticleImageUrl { get; init; }

        public string? Title { get; init; }
        public string? Content { get; init; }

        public DateTime PublicationDate { get; init; }
    }
}
