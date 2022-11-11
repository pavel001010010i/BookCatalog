using Application.Books.Commands.CreateBook;
using Application.Books.Commands.UpdateBook;
using FluentValidation;

namespace Application.Books.Commands.UpdateBook
{
    public class UpdateBookCommandValidation : AbstractValidator<UpdateBookCommand>
    {
        public UpdateBookCommandValidation()
        {
            RuleFor(x => x.Id).NotEqual(Guid.Empty);
            RuleFor(x => x.CategoryId).NotEqual(Guid.Empty);
            RuleFor(x => x.BookCoverURL).NotEmpty().MaximumLength(200).MinimumLength(3);
            RuleFor(x => x.Title).NotEmpty().MaximumLength(70).MinimumLength(3);
            RuleFor(x => x.Author).NotEmpty().MaximumLength(70).MinimumLength(3);
            RuleFor(x => x.Pages).NotEmpty().GreaterThan(1);
            RuleFor(x => x.YearPrint).NotEmpty();
        }
    }
}
