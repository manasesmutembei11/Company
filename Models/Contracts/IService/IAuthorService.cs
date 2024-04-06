using Company.Core.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Core.DTOs;
using Company.Core.Models.RequestFeatures;

namespace Company.Core.Contracts.IService
{
    public interface IAuthorService
    {
        Task<PagedList<AuthorDto>> GetPagedAuthors(PagingParameters pagingParameters);
        IEnumerable<ArticleDto> AuthorArticles(Guid AuthorId, bool trackChanges);

        //  ArticleDto GetArticle(Guid AuthorId, Guid ArticleId, bool trackChanges);

        IEnumerable<AuthorDto> GetAuthors(bool trackChanges);
        AuthorDto CreateAuthor(AuthorForCreationDto author);

        AuthorDto GetAuthor(Guid AuthorId, bool trackChanges);

        void DeleteAuthor(Guid AuthorId, bool trackChanges);

        void UpdateAuthor(Guid AuthorId, AuthorForUpdateDto authorForUpdate, bool trackChanges);
        
    }
}
