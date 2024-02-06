using PC_STORE.Models;
using FluentValidation;
using PC_STORE.Models.Data;

namespace PC_STORE.Validators
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(order => order.Id).NotEmpty().WithMessage("Order ID is required.");
            RuleFor(order => order.ProductId).NotEmpty().WithMessage("Product ID is required.");
            RuleFor(order => order.Quantity).NotEmpty().WithMessage("Quantity is required.")
                                             .GreaterThan(0).WithMessage("Quantity must be greater than zero.");
        }
    }
}