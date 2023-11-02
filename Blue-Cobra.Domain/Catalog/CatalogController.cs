using Microsoft.AspNetCore.Mvc;
using Blue.Cobra.Domain.Catalog;
using System.Runtime.Versioning;

namespace Blue.Cobra.Api.CatalogControllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok("hello world");
        }
    }
}
