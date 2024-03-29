using Company.Core.Contracts.IService;
using Company.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Core.Models.Blog;
using Company.Core.DTOs;
using AutoMapper;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Company.Core.Exceptions;

namespace Company.Infrastructure.Services
{
    internal sealed class ArticleService : IArticleService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public ArticleService(IRepositoryManager repositoryManager, IMapper mapper ) {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public IEnumerable<ArticleDto> GetAllArticles(bool trackChanges)
        {

            var articles =_repositoryManager.Article.GetAllArticles(trackChanges);
            var articlesDto = _mapper.Map<IEnumerable<ArticleDto>>(articles);

            return articlesDto;
            
        }

        public ArticleDto GetArticle(Guid ArticleId, bool trackChanges) {
            var article = _repositoryManager.Article.GetArticle(ArticleId, trackChanges);
            if (article is null)
                throw new ArticleNotFoundException(ArticleId);
            var articleDto =_mapper.Map<ArticleDto>(article);

            return articleDto;
        }

    }
}
