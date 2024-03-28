using Company.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Core.Contracts.IService
{
    public interface IArticleService
    {
        IEnumerable<ArticleDto> GetAllArticles(bool trackChanges);

    }
}
