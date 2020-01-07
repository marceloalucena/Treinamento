using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAL.Api.ViewModel;
using MAL.Bussiness.Notificacoes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace MAL.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiVersion("1.0")]
    public class AuthController : ControladorBase
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SettingsJWT _settingsJWT;
        public AuthController
        (
            INotificador notificador,
            SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager,
            IOptions<SettingsJWT> settingsJWT
        ) : base(notificador)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _settingsJWT = settingsJWT.Value;
        }
        [HttpPost("registrar")]
        [AllowAnonymous]
        public async Task<ActionResult> Registrar(AuthRegistrarViewModel registrar)
        {
            if (!ModelState.IsValid) return Result(ModelState);

            var user = new IdentityUser
            {
                UserName = registrar.Login
            };

            var result = await _userManager.CreateAsync(user, registrar.Senha);
            if (result.Succeeded)
            {
                return Result("Usuário Criado com Sucesso!!!");
            }
            foreach (var erro in result.Errors)
            {
                NotificarErro(erro.Description);
            }
            return Result();
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult> Login(AuthLoginViewModel registrar)
        {
            if (!ModelState.IsValid) return Result(ModelState);

            var user = new IdentityUser
            {
                UserName = registrar.Login
            };

            var result = await _signInManager.PasswordSignInAsync(registrar.Login, registrar.Senha, false, true);
            if (result.Succeeded)
            {
                return Result(GerarToken());
            }
            if (result.IsLockedOut)
            {
                NotificarErro("Usuário Temporariamente Bloqueado!");
            }
            if (result.IsNotAllowed)
            {
                NotificarErro("Usuário com Acesso Não Permitido!");
            }
            else
            {
                NotificarErro("Usuário e/ou Senha Invalidos!");
            }
            return Result();
        }

        private string GerarToken()
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_settingsJWT.Secret);
            var token = tokenHandler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = _settingsJWT.Emissor,
                Audience = _settingsJWT.ValidoEm,
                Expires = DateTime.UtcNow.AddHours(_settingsJWT.ExpiracaoHoras),
                SigningCredentials =
                new SigningCredentials(new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature)
            });


            var encoderToken = tokenHandler.WriteToken(token);

            return encoderToken;
        }
    }
}