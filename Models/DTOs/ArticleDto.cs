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
    (
        Guid ArticleId,
        string? ArticleImageUrl,
        string? Title,
        string? Content,
        DateTime PublicationDate
    );
}
