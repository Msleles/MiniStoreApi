using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MiniStore.Application.DTOs;
using MiniStore.Application.Interfaces;

namespace MiniStoreApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ILogger<ProdutoController> _logger;
        private readonly IProdutoService _produtoService;
        private readonly IMapper _mapper;

        public ProdutoController(ILogger<ProdutoController> logger, IProdutoService produtoService, IMapper mapper)
        {
            _logger = logger;
            _produtoService = produtoService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CriarProduto(ProdutoDTO produtoDTO)
        {     
            var novoProdutoDTO = await _produtoService.Novo(produtoDTO);

            if (novoProdutoDTO != null)
            {
                return Ok(novoProdutoDTO);
            }
            else
            {
                return BadRequest("O produto não pôde ser adicionado.");
            }
        }
    }
}