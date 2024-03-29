using Company.Core.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Core.DTOs;

namespace Company.Core.Contracts.IService
{
    public interface IAuthorService
    {
        IEnumerable<ArticleDto> AuthorArticles(Guid AuthorId, bool trackChanges);

        ArticleDto GetArticle(Guid AuthorId, Guid ArticleId, bool trackChanges);

    }
}
