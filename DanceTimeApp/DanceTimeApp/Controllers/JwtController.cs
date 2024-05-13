using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DanceTimeApp.Controllers;

[ApiController]
[Microsoft.AspNetCore.Components.Route("api/[controller]")]
public class JwtController : Controller
{
    [Authorize]
    [Route("getnickname")]
    public IActionResult GetNickname()
    {
        return Ok($"Ваш логин: {User.Identity.Name}");
    }
         
    [Authorize(Roles = "admin")]
    [Route("getrole")]
    public IActionResult GetRole()
    {
        return Ok("Ваша роль: администратор");
    }
}