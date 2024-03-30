using Company.Core.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Core.Contracts
{
    public interface IAuthorRepository
    {
       IEnumerable<Article> AuthorArticles(Guid AuthorId, bool trackChanges);

        // Article GetArticle(Guid AuthorId, Guid ArticleId, bool trackChanges);

        void CreateAuthor(Author author);


    }
}
