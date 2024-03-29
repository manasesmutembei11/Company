using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Core.Exceptions
{
    public sealed class ArticleNotFoundException : NotFoundException
    {
        public ArticleNotFoundException(Guid ArticleId) : 
            base($"The company with id: {ArticleId} doesn't exist in thedatabase.")
        {
        }
    }
}
