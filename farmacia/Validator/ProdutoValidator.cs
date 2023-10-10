using farmacia.Model;
using FluentValidation;

namespace farmacia.Validator
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(p => p.Nome)
                    .NotEmpty()
                    .MinimumLength(4)
                    .MaximumLength(100);
            RuleFor(p => p.Tipo)
                    .NotEmpty()
                    .MinimumLength(5)
                    .MaximumLength(1000);
            RuleFor(p => p.Preco)
                   .NotNull()
                   .GreaterThan(0)
                   .PrecisionScale(20, 2, false);
        }
        
    }
}