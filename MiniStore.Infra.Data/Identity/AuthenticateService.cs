using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MiniStore.Domain.Account;
using MiniStore.Domain.Account.Models;
using MiniStore.Domain.Models;
using MiniStore.Infra.Data.Identity.Jwt;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MiniStore.Infra.Data.Identity
{
    public class AuthenticateService : IAuthenticate
    {
        private readonly UserManager<ApplicationUser> _userMananger;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly IOptions<JwtConfigurationOptions> _options;

        public AuthenticateService(UserManager<ApplicationUser> userMananger,
            SignInManager<ApplicationUser> signInManager, IConfiguration configuration,
            IOptions<JwtConfigurationOptions> options)
        {
            _userMananger = userMananger;
            _signInManager = signInManager;
            _configuration = configuration;
            _options = options;
        }

        public async Task<UsuarioToken?> Authenticate(string email, string password)
        {
            var result = await _signInManager
                .PasswordSignInAsync(email, password, false, lockoutOnFailure: false);

            if (!result.Succeeded)
                return null;

            var user = new Usuario
            {
                Email = email,
                Password = password,
            };

            var usuarioToken = GerarToken(user);
            return usuarioToken;
        }

        public async Task<bool> RegisterUser(string email, string password)
        {
            var applicationUser = new ApplicationUser
            {
                UserName = email,
                Email = email,
                EmailConfirmed = true
            };

            var result = await _userMananger.CreateAsync(applicationUser, password);

            if (!result.Succeeded)
                return false;

            await _signInManager.SignInAsync(applicationUser, isPersistent: false);

            var user = new Usuario
            {
                Email = email,
                Password = password,
            };

            GerarToken(user);
            return true;
        }


        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }

        /// <summary>
        /// Método responsável por gerar o token secreto da api
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public UsuarioToken GerarToken(Usuario usuario)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, usuario.Email),
                new Claim("meuPapagaio", "Kito"),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_options.Value.Key ?? ""));

            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expirationToken = _options.Value.ExpireHours.ToString();
            var addExpiration = DateTime.UtcNow.AddHours(double.Parse(expirationToken));

            JwtSecurityToken token = new JwtSecurityToken(
                issuer: _options.Value.Issuer,
                audience: _options.Value.Audience,
                claims: claims,
                expires: addExpiration,
                signingCredentials: credentials);


            return new UsuarioToken()
            {
                Authenticated = true,
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = addExpiration,
                Message = "Token JWT OK"
            };
        }
    }
}
