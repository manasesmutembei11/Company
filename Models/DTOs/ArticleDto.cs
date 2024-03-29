using Company.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Core.Models.Blog;

namespace Company.Core.DTOs
{
    public record ArticleDto
    {
        public Guid ArticleId { get; init; }

        public string? ArticleImageUrl { get; init; }
        public string? Title { get; init; }
        public string? Content { get; init; }

        public DateTime PublicationDate { get; init; }

        public Category? Category { get; init; }

        public ICollection<Comment>? Comments { get; init; }
    }
}
