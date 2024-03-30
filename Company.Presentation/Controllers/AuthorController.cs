using Company.Core.Contracts.IService;
using Company.Core.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Presentation.Controllers
{
    [Route("api/author")]
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

        [HttpPost]
        public IActionResult CreateAuthor([FromBody] AuthorForCreationDto author)
        {
            if (author is null)
                return BadRequest("ArticleForCreationDto object is null");
            var createdAuthor = _serviceManager.AuthorService.CreateAuthor(author);
            return Ok(createdAuthor);
        }

        /* 
        [HttpGet("{id:guid}", Name = "AuthorById")]

       public IActionResult GetArticle(Guid AuthorId, Guid ArticleId, bool trackChanges)
        {
            var Article = _serviceManager.AuthorService.GetArticle(AuthorId, ArticleId, trackChanges: trackChanges);
            return Ok(Article);
        } */
    }

}
