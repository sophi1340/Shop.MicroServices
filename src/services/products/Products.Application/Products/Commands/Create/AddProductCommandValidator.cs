using FluentValidation;

namespace Products.Application.Products.Commands.Create
{
    /// <summary>
    /// اعتبار سنجی توکار به صورت IPipelineBehavior
    /// با این روش دیگه درخواست به سمت دیتابیس نمیرسه در صوت وجود اشکال اعتبار سنجی
    /// ولی روش جالبی نیست
    /// </summary>
    public class AddProductCommandValidator : AbstractValidator<AddProductCommand>
    {
        public AddProductCommandValidator()
        {
            RuleFor(p => p.Title)
                .NotEmpty().WithMessage("{Title} is Required")
                .NotNull()
                .MaximumLength(200).WithMessage("{Title} must not exceed 200 characters");
            RuleFor(p => p.Description)
                .NotEmpty().WithMessage("{Description} is Required")
                .NotNull()
                .MaximumLength(5000).WithMessage("{Description} must not exceed 5000 characters");

            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("{CategoryId} is Required")
                .NotEqual(0).WithMessage("{Category} must not be zero");

            RuleFor(p => p.Price)
                .NotNull().WithMessage("{Price} is Required")
                .GreaterThanOrEqualTo(0).WithMessage("{Price} must not be less than zero");


        }
    }
}
