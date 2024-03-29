using Company.Core.Contracts.IService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Presentation.Controllers
{
    [Route("api/author/{AuthorId}/articles")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public AuthorController(IServiceManager service)
        {
            _serviceManager = service;
        }

        [HttpGet]
        public IActionResult AuthorArticles(Guid AuthorId, bool trackChanges)
        {
            var articles = _serviceManager.AuthorService.AuthorArticles(AuthorId, trackChanges: false);
            return Ok(articles);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetArticle(Guid AuthorId, Guid ArticleId, bool trackChanges)
        {
            var Article = _serviceManager.AuthorService.GetArticle(AuthorId, ArticleId, trackChanges: trackChanges);
            return Ok(Article);
        }
    }

}
