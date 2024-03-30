using Company.Core.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Core.Contracts;
using Company.Infrastructure.Data;

namespace Company.Infrastructure.Repositories
{
    public class ArticleRepository : RepositoryBase<Article>, IArticleRepository
    {
        public ArticleRepository(CompanyContext companyContext)
        : base(companyContext)
        {
        }

        public IEnumerable<Article> GetAllArticles(bool trackChanges) => FindAll(trackChanges).OrderBy(c => c.Title).ToList();


        public Article GetArticle(Guid ArticleId, bool trackChanges) => 
            FindByCondition(c => c.ArticleId.Equals(ArticleId), trackChanges).SingleOrDefault();

        public void CreateArticle(Article article) => Create(article);
    }

}
