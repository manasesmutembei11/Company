using Company.Core.Contracts.IService;
using Company.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Company.Infrastructure.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IArticleService> _articleService;
        private readonly Lazy<IProductService> _productService;
        private readonly Lazy<IAuthorService> _authorService;

        public ServiceManager (IRepositoryManager repositoryManager, IMapper mapper) {
            _articleService = new Lazy<IArticleService>(() => new ArticleService(repositoryManager, mapper));
            _productService = new Lazy<IProductService>(() => new ProductService(repositoryManager, mapper));
            _authorService = new Lazy<IAuthorService>(() => new AuthorService(repositoryManager, mapper));
        }

        public IArticleService ArticleService => _articleService.Value;
        public IProductService ProductService => _productService.Value;

        public IAuthorService AuthorService => _authorService.Value;

    }
}
