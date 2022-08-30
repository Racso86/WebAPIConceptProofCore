using Microsoft.AspNetCore.Mvc;

namespace WebAPIConpectProofCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SolidPrinciplesController : Controller
    {
        public static List<SolidPrinciple> solidPrinciples = new List<SolidPrinciple>
        {
            {
                new SolidPrinciple {
                    Id = 1,
                    Letter = "S",
                    Title = "Single Responsibility Principle",
                    Summary = ""
                }
            },
            {
                new SolidPrinciple {
                    Id = 2,
                    Letter = "O",
                    Title = "Open/Closed Principle",
                    Summary = ""
                }
            },
            {
                new SolidPrinciple {
                    Id = 3,
                    Letter = "L",
                    Title = "Liskov Substitution Principle",
                    Summary = ""
                }
            },
            {
                new SolidPrinciple {
                    Id = 4,
                    Letter = "I",
                    Title = "Interface Segregation Principle",
                    Summary = ""
                }
            },
            {
                new SolidPrinciple {
                    Id = 5,
                    Letter = "D",
                    Title = "Dependency Injection Principle",
                    Summary = ""
                }
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<SolidPrinciple>>> Get()
        {
            return Ok(solidPrinciples);
        }
    }
}
