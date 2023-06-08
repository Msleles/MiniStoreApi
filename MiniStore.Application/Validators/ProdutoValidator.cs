using FluentValidation;
using MiniStore.Domain.Entities;

namespace MiniStore.Application.Validators
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(p => p.Nome)
            .NotEmpty().WithMessage("O nome do produto é obrigatório.")
            .MaximumLength(50).WithMessage("O nome do produto deve ter no máximo 100 caracteres.");

            RuleFor(p => p.Preco)
           .GreaterThan(0).WithMessage("O preço do produto deve ser maior que zero.");
        }
    }
}
