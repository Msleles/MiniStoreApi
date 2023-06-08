using AutoMapper;
using MiniStore.Application.DTOs;
using MiniStore.Domain.Entities;

namespace MiniStore.Infra.Data.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Produto, ProdutoDTO>().ReverseMap();
           
        }
    }
}
