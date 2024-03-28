using Company.Core.Contracts.IService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Presentation.Controllers
{
    [Route("api/companies")]
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
            try
            {
                var articles =  _serviceManager.ArticleService.GetAllArticles(trackChanges: false);
                return Ok(articles);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }

    }
}
