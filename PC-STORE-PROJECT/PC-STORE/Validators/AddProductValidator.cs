using FluentValidation;
using PC_STORE.MODELS.Data;

namespace PC_STORE.Validators
{
    public class AddProductValidator : AbstractValidator<Product>
    {
        public AddProductValidator()
        {
            RuleFor(product => product.Name).NotEmpty().WithMessage("Product name is required.");
            RuleFor(product => product.Price).NotEmpty().WithMessage("Price is required.")
                                              .GreaterThan(0).WithMessage("Price must be greater than zero.");
            RuleFor(product => product.Description).NotEmpty().WithMessage("Description is required.");
        }
    }
}
