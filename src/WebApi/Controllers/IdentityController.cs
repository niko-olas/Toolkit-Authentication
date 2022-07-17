using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Toolkit_Authentication.JWTBearer;
namespace WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class IdentityController : Controller
    {
        [HttpPost]
        public IActionResult Login([FromServices] IJWTBearerService jwtBearerGeneratorService)
        {
            var claims = new List<Claim>
        {
            new (ClaimTypes.GivenName,"Donald"),
            new(ClaimTypes.Surname,"Duck")
        };

            var token = jwtBearerGeneratorService.CreateToken("Nicholas", claims);
            return Ok(new { token });
        }
    }
}
