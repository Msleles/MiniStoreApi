using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MiniStore.Application.ApiClient.Interfaces;
using MiniStore.Application.DTOs;
using MiniStore.Application.Interfaces;
using MiniStore.Application.Interfaces.Notificador;
using MiniStore.Application.Services;
using MiniStore.Domain.Pagination;
using System.Text.Json;

namespace MiniStoreApi.Controllers
{
    [Route("[controller]")]
    public class EmpresaController : MainController
    {
        private readonly IIBGEApiClientService _iBGEApiClientService;

        public EmpresaController(IIBGEApiClientService iBGEApiClientService, 
            INotificationService notificationService) : base(notificationService)
        {
            _iBGEApiClientService= iBGEApiClientService;
        }


        /// <summary>
        /// Obtém uma lista dos estados brasileiros
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Estados")]
        public async Task<ActionResult> ObterEstados()
        {
            var estadosBrasileiros = await _iBGEApiClientService.GetEstados();
            return ServiceResponse(estadosBrasileiros);
        }
    }
}