using Company.Core.Contracts;
using Company.Core.Models.Blog;
using Company.Core.Models.RequestFeatures;
using Company.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Infrastructure.Repositories
{
    public class AuthorRepository : RepositoryBase<Author>, IAuthorRepository
    {
        private readonly CompanyContext _context;
        public AuthorRepository(CompanyContext companyContext): base(companyContext)
        {
            _context = companyContext;
        }

        public async Task<PagedList<Author>> GetPagedAuthors(PagingParameters pagingParameters)
        {
            var data = await _context.Authors.OrderBy(x=> x.FirstName).ThenBy(x => x.LastName).ToListAsync();
            return PagedList<Author>.ToPagedList(data, pagingParameters.PageNumber, pagingParameters.PageNumber);
        }

        public IEnumerable<Author> GetAuthors(bool trackChanges) => FindAll(trackChanges).OrderBy(c => c.FirstName).ToList();

        public IEnumerable<Article> AuthorArticles(Guid AuthorId, bool trackChanges) =>
         (IEnumerable<Article>)FindByCondition(e => e.AuthorId.Equals(AuthorId), trackChanges)
         .OrderBy(e => e.Email).ToList();

        //   public Article GetArticle(Guid AuthorId, Guid ArticleId, bool trackChanges) =>
        //    FindByCondition(e => e.AuthorId.Equals(AuthorId) && e.ArticleId.Equals(ArticleId), trackChanges).SingleOrDefault();

        public void CreateAuthor(Author author) => Create(author);

        public Author GetAuthor(Guid AuthorId, bool trackChanges) =>
         FindByCondition(c => c.AuthorId.Equals(AuthorId), trackChanges).SingleOrDefault();
        public void DeleteAuthor(Author author) => Delete(author);


    }
}
