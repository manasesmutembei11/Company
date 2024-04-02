using AutoMapper;
using Company.Core.Contracts;
using Company.Core.Contracts.IService;
using Company.Core.DTOs;
using Company.Core.Exceptions;
using Company.Core.Models.Blog;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Infrastructure.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public AuthorService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }


        public IEnumerable<ArticleDto> AuthorArticles(Guid AuthorId, bool trackChanges)
        {
            var company = _repositoryManager.Author.AuthorArticles(AuthorId, trackChanges);
            if (company is null)
                throw new AuthorNotFoundException(AuthorId);
            var articlesFromDb = _repositoryManager.Author.AuthorArticles(AuthorId, trackChanges);
            var articlesDto = _mapper.Map<IEnumerable<ArticleDto>>(articlesFromDb);
            return articlesDto;
        }

        /*   public ArticleDto GetArticle(Guid AuthorId, Guid ArticleId, bool trackChanges)
           {
               var author = _repositoryManager.Author.GetArticle(AuthorId, ArticleId, trackChanges);
               if (author is null)
                   throw new AuthorNotFoundException(AuthorId);
               var article = _repositoryManager.Author.GetArticle(AuthorId, ArticleId, trackChanges);
               if (article is null)
                   throw new ArticleNotFoundException(ArticleId);
               var mappedArticle = _mapper.Map<ArticleDto>(article);
               return mappedArticle;
           } */

        public AuthorDto CreateAuthor(AuthorForCreationDto author)
        {
            var authorEntity = _mapper.Map<Author>(author);

            _repositoryManager.Author.CreateAuthor(authorEntity);
            _repositoryManager.Save();

            var authorToReturn = _mapper.Map<AuthorDto>(authorEntity);

            return authorToReturn;


        }

        public AuthorDto GetAuthor(Guid AuthorId, bool trackChanges)
        {
            var author = _repositoryManager.Author.GetAuthor(AuthorId, trackChanges);
            if (author is null)
                throw new AuthorNotFoundException(AuthorId);
            var authorDto = _mapper.Map<AuthorDto>(author);

            return authorDto;
        }

        public void DeleteAuthor(Guid AuthorId, bool trackChanges) {
           var author = _repositoryManager.Author.GetAuthor(AuthorId, trackChanges);
            if(author is null)
                throw new AuthorNotFoundException(AuthorId);
            _repositoryManager.Author.DeleteAuthor(author);
            _repositoryManager.Save();
        }

        public void UpdateAuthor(Guid AuthorId, AuthorForUpdateDto authorForUpdate, bool trackChanges)
        {
            var author = _repositoryManager.Author.GetAuthor(AuthorId, trackChanges);
            if( author is null)
                throw new AuthorNotFoundException(AuthorId);
            _mapper.Map(authorForUpdate, author);
            _repositoryManager.Save();

        }


    }

}
