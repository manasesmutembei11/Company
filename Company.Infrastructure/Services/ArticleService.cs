using Company.Core.Contracts.IService;
using Company.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Infrastructure.Services
{
    internal sealed class ArticleService : IArticleService
    {
        private readonly IRepositoryManager _repositoryManager;
        public ArticleService(IRepositoryManager repositoryManager) {
            _repositoryManager = repositoryManager;
        }
    }
}
