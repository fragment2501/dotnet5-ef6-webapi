using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using bsr_dotnet_ef6_webapi.Dal;
using bsr_dotnet_ef6_webapi.Dal.Models;

namespace bsr_dotnet_ef6_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BloggingController : ControllerBase
    {
        private readonly ILogger<BloggingController> _logger;
        private readonly BloggingContext _db;

        public BloggingController(ILogger<BloggingController> logger, BloggingContext db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet]
        public IEnumerable<Blog> Get()
        {
            return _db.Blogs.ToList();
        }
    }
}
