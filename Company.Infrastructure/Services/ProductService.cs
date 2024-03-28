using Company.Core.Contracts;
using Company.Core.Contracts.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Infrastructure.Services
{
    internal sealed class ProductService : IProductService
    {
        private readonly IRepositoryManager _repositoryManager;
        public ProductService(IRepositoryManager repositoryManager) {
            _repositoryManager = repositoryManager;
        }
    }
}
