using Microsoft.AspNetCore.Mvc;

namespace WebAPIConpectProofCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConcurrencyPatternsController : Controller
    {
        public static List<ConcurrencyPattern> concurrencyPatterns = new List<ConcurrencyPattern>
        {
            {
                new ConcurrencyPattern {
                    Id = 1,
                    Summary = "Pattern 1"
                }
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<ConcurrencyPattern>>> Get()
        {
            return Ok(concurrencyPatterns);
        }
    }
}
