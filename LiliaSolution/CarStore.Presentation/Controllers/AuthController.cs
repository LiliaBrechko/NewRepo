using CarStore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarStore.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        var token = TokenService.GenerateToken(request.Username);

        return Ok(new { Token = token });

        //if (request.Username == "test" && request.Password == "password")
        //{
        //    var token = TokenService.GenerateToken(request.Username);
        //    return Ok(new { Token = token });
        //}

        //return Unauthorized("Invalid credentials");
    }

    [HttpGet("protected")]
    [Authorize]
    public IActionResult Protected()
    {
        var username = User.Identity?.Name; // Доступ к данным из токена
        return Ok($"Hello, {username}! This is a protected endpoint.");
    }
}

public class LoginRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
}
