using AutoMapper;
using MiniStore.Application.DTOs;
using MiniStore.Application.Interfaces;
using MiniStore.Application.Interfaces.Notificador;
using MiniStore.Application.Validators;
using MiniStore.Domain.Entities;
using MiniStore.Domain.Interfaces;
using MiniStore.Domain.Pagination;

namespace MiniStore.Application.Services
{
    public class ProdutoService:BaseService, IProdutoService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public ProdutoService( 
            IUnitOfWork uow, 
            IMapper mapper, INotificationService _notificador): base(_notificador)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public PagedList<ProdutoDTO> GetProdutos(ProdutosParameters produtosParameters)
        {
            var produtos = _uow.ProdutoRepository.GetProdutos(produtosParameters);

            var produtosDTO = _mapper.Map<List<ProdutoDTO>>(produtos);

            var pagedList = new PagedList<ProdutoDTO>(produtosDTO, produtos.Count, produtosParameters.PageNumber, produtosParameters.PageSize);

            return pagedList;
        }


        public async Task<ProdutoDTO?> Novo(ProdutoDTO produtoDTO)
        {
            try
            {
                var produto = _mapper.Map<Produto>(produtoDTO);

                if (!ExecutarValidacao(new ProdutoValidator(), produto)) return null;
              
                await _uow.ProdutoRepository.AddProdutoAsync(produto);

                await _uow.Commit();

                var novoProdutoDTO = _mapper.Map<ProdutoDTO>(produto);

                return  novoProdutoDTO;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
