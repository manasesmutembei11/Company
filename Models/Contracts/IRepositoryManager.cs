using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Core.Contracts
{
    public interface IRepositoryManager
    {
        IArticleRepository Article { get; }
        IProductRepository Product { get; }

        IAuthorRepository Author { get; }
        void Save();
    }

}
