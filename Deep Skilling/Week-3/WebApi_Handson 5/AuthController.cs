using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
[ApiController]
[Route("api/[controller]")]
[AllowAnonymous]
public class AuthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var key = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes("mysuperdupersecret"));
        var token = new JwtSecurityToken(
            issuer: "mySystem",
            audience: "myUsers",
            expires: DateTime.Now.AddMinutes(2),
            signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256),
            claims: new[]
            {
                new Claim(ClaimTypes.Role,"Admin")
            });
        return Ok(new JwtSecurityTokenHandler().WriteToken(token));
    }
}
