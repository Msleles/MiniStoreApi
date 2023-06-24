using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiniStore.Application.DTOs;
using MiniStore.Application.Interfaces.Notificador;
using MiniStore.Domain.Account;
using MiniStore.Domain.Models;

namespace MiniStoreApi.Controllers
{
    [Route("[controller]")]
    public class AutenticacaoController : MainController
    {
        private readonly IAuthenticate _auth;
        public AutenticacaoController(INotificationService notificationService, IAuthenticate auth) : base(notificationService)
        {
            _auth = auth;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "AutenticacaoController :: Acessado em : "
                + DateTime.Now.ToLongTimeString();
        }

        [HttpPost("register")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<ActionResult<bool>> RegisterUser([FromBody] UsuarioDTO model)
        {
            return await _auth.RegisterUser(model.Email, model.Password);
        }

        [HttpPost("login")]
        public async Task<ActionResult<UsuarioToken>> Login([FromBody] UsuarioDTO model)
        {
            return await _auth.Authenticate(model.Email, model.Password);
        }

    }
}