using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Core.Contracts.IService
{
    public interface IServiceManager
    {
        public IArticleService ArticleService { get; }
        public IProductService ProductService { get; }

        public IAuthorService AuthorService { get; }
    }
}
