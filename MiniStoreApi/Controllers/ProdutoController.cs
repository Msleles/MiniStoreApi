using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MiniStore.Application.DTOs;
using MiniStore.Application.Interfaces;
using MiniStore.Application.Interfaces.Notificador;
using MiniStore.Domain.Pagination;
using System.Text.Json;

namespace MiniStoreApi.Controllers
{
    [Route("[controller]")]
    public class ProdutoController : MainController
    {
        private readonly ILogger<ProdutoController> _logger;
        private readonly IProdutoService _produtoService;
        private readonly IMapper _mapper;

        public ProdutoController(ILogger<ProdutoController> logger, 
            IProdutoService produtoService, 
            IMapper mapper, INotificationService notificationService): base (notificationService)
        {
            _logger = logger;
            _produtoService = produtoService;
            _mapper = mapper;
        }


        /// <summary>
        /// Obt�m uma lista de produtos paginada.
        /// </summary>
        /// <param name="produtosParameters">Parametros fornecidos para pagina��o.</param>
        /// <returns>Uma resposta HTTP que indica o resultado da opera��o.</returns>
        [HttpGet]
        public ActionResult ObterProdutos([FromQuery] ProdutosParameters produtosParameters)
        {
            var produtos = _produtoService.GetProdutos(produtosParameters);

            var metadataJson = PaginationHelper.GetPaginationMetadataJson(produtos);
            Response.Headers.Add("X-Pagination", metadataJson);

            return ServiceResponse(produtos);
        }

        /// <summary>
        /// Cria um novo produto com base nos dados fornecidos.
        /// </summary>
        /// <param name="produtoDTO">Os dados do produto a serem criados.</param>
        /// <returns>Uma resposta HTTP que indica o resultado da opera��o.</returns>
        [HttpPost]
        public async Task<ActionResult> CriarProduto(ProdutoDTO produtoDTO)
        {
            var produto = await _produtoService.Novo(produtoDTO);
            return ServiceResponse(produto);
        }
    }
}