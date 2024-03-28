using Company.Core.Contracts.IService;
using Company.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Infrastructure.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IArticleService> _articleService;
        private readonly Lazy<IProductService> _productService;

        public ServiceManager (IRepositoryManager repositoryManager) {
            _articleService = new Lazy<IArticleService>(() => new ArticleService(repositoryManager));
            _productService = new Lazy<IProductService>(() => new ProductService(repositoryManager));
        }

        public IArticleService ArticleService => _articleService.Value;
        public IProductService ProductService => _productService.Value;

    }
}
