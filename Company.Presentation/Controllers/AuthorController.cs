using Company.Core.Contracts.IService;
using Company.Core.DTOs;
using Company.Core.Models.RequestFeatures;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Presentation.Controllers
{
    [Route("api/author/[action]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public AuthorController(IServiceManager service)
        {
            _serviceManager = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetPagedAuthors( [FromQuery] PagingParameters pagingParameters) {

            var item = Request.Query;
            var pagedList = await _serviceManager.AuthorService.GetPagedAuthors(pagingParameters);
            return Ok(pagedList);
        }


        [HttpGet]
        public IActionResult GetAuthors(bool trackChanges)
        {
            var authors = _serviceManager.AuthorService.GetAuthors(trackChanges);
            return Ok(authors);
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

        [HttpGet("{AuthorId:guid}")]
        public IActionResult GetAuthor(Guid AuthorId)
        {
            var author = _serviceManager.AuthorService.GetAuthor(AuthorId, trackChanges: false);
            return Ok(author);
        }

        [HttpDelete("{AuthorId:guid}")]
        public IActionResult DeleteAuthor(Guid AuthorId, bool trackChanges) {
            _serviceManager.AuthorService.DeleteAuthor(AuthorId, trackChanges: false);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAuthor(Guid AuthorId, [FromBody] AuthorForUpdateDto authorForUpdate)
        {
            if (authorForUpdate is null)
                return BadRequest("Author for update is null");

            _serviceManager.AuthorService.UpdateAuthor(AuthorId, authorForUpdate, trackChanges: true);

            return Ok();
        }
    }

}
