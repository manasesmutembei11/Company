using Company.Core.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Core.Contracts
{
    public interface IArticleRepository
    {
        IEnumerable<Article> GetAllArticles(bool trackChanges);
    }
}
