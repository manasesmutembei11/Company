﻿using Company.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Infrastructure.Data;

namespace Company.Infrastructure.Repositories
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly CompanyContext _companyContext;
        private readonly Lazy<IArticleRepository> _articleRepository;
        private readonly Lazy<IProductRepository> _productRepository;
        private readonly Lazy<IAuthorRepository> _authorRepository;
        public RepositoryManager(CompanyContext companyContext)
        {
            _companyContext = companyContext;
            _articleRepository = new Lazy<IArticleRepository>(() => new
            ArticleRepository(companyContext));

            _productRepository = new Lazy<IProductRepository>(() => new
            ProductRepository(companyContext));

            _authorRepository = new Lazy<IAuthorRepository>(() => new 
            AuthorRepository(companyContext));
        }
        public IArticleRepository Article => _articleRepository.Value;
        public IProductRepository Product => _productRepository.Value;

        public IAuthorRepository Author => _authorRepository.Value;
        public void Save() => _companyContext.SaveChanges();
    }

}
