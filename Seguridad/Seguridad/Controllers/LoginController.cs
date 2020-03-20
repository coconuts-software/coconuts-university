using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Seguridad.API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Seguridad.API.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        // POST: api/Login
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login([FromBody]UserLogin usuarioLogin)
        {
            var _userInfo = AutenticarUser(usuarioLogin.Usuario, usuarioLogin.Password);
            if (_userInfo != null)
            {
                return Ok(new { token = GenerarTokenJWT(_userInfo) });
            }
            else
            {
                return Unauthorized();
            }
        }


        private UserInfo AutenticarUser(string usuario, string password)
        {
            if (usuario == "lalala" && password == "lalala")
            {
                return new UserInfo()
                {
                    Id = 1,
                    Nombre = "Nombre Usuario",
                    Apellidos = "Apellidos Usuario",
                    Email = "email.usuario@dominio.com",
                    Rol = "Administrador"
                };
            }
            else {
                return null;
            }

        }

        private string GenerarTokenJWT(UserInfo usuarioInfo)
        {
            var _symmetricSecurityKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes("ClaveMuyMuySegura")
                );
            var _signingCredentials = new SigningCredentials(
                    _symmetricSecurityKey, SecurityAlgorithms.HmacSha256
                );
            var _Header = new JwtHeader(_signingCredentials);

            var _Claims = new[] {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.NameId, usuarioInfo.Id.ToString()),
                new Claim("nombre", usuarioInfo.Nombre),
                new Claim("apellidos", usuarioInfo.Apellidos),
                new Claim(JwtRegisteredClaimNames.Email, usuarioInfo.Email),
                new Claim(ClaimTypes.Role, usuarioInfo.Rol)
            };

            var _Payload = new JwtPayload(
                    issuer: "Pocho",
                    audience: "MiApi",
                    claims: _Claims,
                    notBefore: DateTime.UtcNow,
                    // Exipra a la 24 horas.
                    expires: DateTime.UtcNow.AddHours(24)
                );

            var _Token = new JwtSecurityToken(
                    _Header,
                    _Payload
                );

            return new JwtSecurityTokenHandler().WriteToken(_Token);
        }
    }
}
