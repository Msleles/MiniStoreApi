using AutoMapper;
using MiniStore.Application.DTOs;
using MiniStore.Application.Interfaces;
using MiniStore.Application.Validators;
using MiniStore.Domain.Entities;
using MiniStore.Domain.Interfaces;

namespace MiniStore.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public ProdutoService( 
            IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<ProdutoDTO?> Novo(ProdutoDTO produtoDTO)
        {
            try
            {
                var produto = _mapper.Map<Produto>(produtoDTO);

                var validation = new ProdutoValidator();
                var validationResult = await validation.ValidateAsync(produto);
                if (!validationResult.IsValid) return null;

                await _uow.ProdutoRepository.AddProdutoAsync(produto);
                await _uow.Commit();

                var novoProdutoDTO = _mapper.Map<ProdutoDTO>(produto);

                return novoProdutoDTO;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
