using FluentValidation;


namespace Application.Books.Commands.CreateBook
{
    public class CreateBookCommandValidation : AbstractValidator<CreateBookCommand>
    {
        public CreateBookCommandValidation()
        {
            RuleFor(x => x.BookCoverURL).NotEmpty().MaximumLength(200).MinimumLength(3);
            RuleFor(x => x.Title).NotEmpty().MaximumLength(70).MinimumLength(3);
            RuleFor(x => x.Author).NotEmpty().MaximumLength(70).MinimumLength(3);
            RuleFor(x => x.Pages).NotEmpty().GreaterThan(1);
            RuleFor(x => x.YearPrint).NotEmpty();
            RuleFor(x => x.CategoryId).NotEqual(Guid.Empty);
        }
    }
}
