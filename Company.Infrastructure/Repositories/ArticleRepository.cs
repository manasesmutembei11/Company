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
    }

}
