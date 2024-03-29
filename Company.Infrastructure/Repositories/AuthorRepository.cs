using Company.Core.Contracts;
using Company.Core.Models.Blog;
using Company.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Infrastructure.Repositories
{
    public class AuthorRepository : RepositoryBase<Author>, IAuthorRepository
    {
        public AuthorRepository(CompanyContext companyContext): base(companyContext)
        {
        }

        public IEnumerable<Article> AuthorArticles(Guid AuthorId, bool trackChanges) =>
         (IEnumerable<Article>)FindByCondition(e => e.AuthorId.Equals(AuthorId), trackChanges)
         .OrderBy(e => e.Email).ToList();

        public Article GetArticle(Guid AuthorId, Guid ArticleId, bool trackChanges) =>
            FindByCondition(e => e.AuthorId.Equals(AuthorId) && e.ArticleId.Equals(ArticleId), trackChanges).SingleOrDefault();



    }
}
