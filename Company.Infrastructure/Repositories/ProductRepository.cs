using Company.Core.Contracts;
using Company.Core.Models.Blog;
using Company.Core.Models.Commerce;
using Company.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Infrastructure.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(CompanyContext companyContext)
        : base(companyContext)
        {
        }
    }
}
