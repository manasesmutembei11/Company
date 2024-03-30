using Company.Core.Contracts.IService;
using Company.Core.DTOs;
using Company.Core.Models.Blog;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Presentation.Controllers
{
    [Route("api/articles")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public ArticleController (IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public IActionResult GetAllArticles()
        {
            //throw new Exception("Exception");

            var articles =  _serviceManager.ArticleService.GetAllArticles(trackChanges: false);
                return Ok(articles);
            
        }

        [HttpGet("{ArticleId:guid}")]
        public IActionResult GetArticle(Guid ArticleId) {
            var article = _serviceManager.ArticleService.GetArticle(ArticleId, trackChanges: false);
            return Ok(article);
        }

        [HttpPost]
        public IActionResult CreateArticle([FromBody] ArticleForCreationDto article)
        {
            if (article is null)
                return BadRequest("ArticleForCreationDto object is null");
            var createdArticle = _serviceManager.ArticleService.CreateArticle(article);
            return CreatedAtRoute("ArticleById", createdArticle);
        }



    }
}
