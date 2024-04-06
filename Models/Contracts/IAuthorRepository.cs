using Company.Core.Models.Blog;
using Company.Core.Models.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Core.Contracts
{
    public interface IAuthorRepository
    {
        Task<PagedList<Author>> GetPagedAuthors(PagingParameters pagingParameters);
       IEnumerable<Article> AuthorArticles(Guid AuthorId, bool trackChanges);

        // Article GetArticle(Guid AuthorId, Guid ArticleId, bool trackChanges);
        IEnumerable<Author> GetAuthors(bool trackChanges);
        void CreateAuthor(Author author);

        Author GetAuthor(Guid AuthorId, bool trackChanges);
        void DeleteAuthor(Author author);


    }
}
