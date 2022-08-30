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
                    Summary = "The Active Object design pattern decouples method execution from method invocation. Its purpose is to enhance concurrency and simplify synchronized access to objects that reside in theri own threads of control."
                }
            },
            {
                new ConcurrencyPattern {
                    Id = 2,
                    Summary = "The Monitor Object design pattern " +
                    "synchronizes concurrent methd execution to ensure that only one method at a time runs within" +
                    "an object. It also allows an object's methods to schedule their execution sequences cooperatively"
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
