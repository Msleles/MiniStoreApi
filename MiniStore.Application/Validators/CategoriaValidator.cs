using FluentValidation;
using MiniStore.Domain.Entities;

namespace MiniStore.Application.Validators
{
    public class CategoriaValidator : AbstractValidator<Categoria>
    {
        public CategoriaValidator()
        {
            RuleFor(p => p.Nome)
           .NotEmpty().WithMessage("O nome da categoria é obrigatório.")
           .MaximumLength(50).WithMessage("O nome da categoria deve ter no máximo 50 caracteres.");
        }
    }
}
