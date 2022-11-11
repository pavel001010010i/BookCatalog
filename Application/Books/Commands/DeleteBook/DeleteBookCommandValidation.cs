using FluentValidation;


namespace Application.Books.Commands.DeleteBook
{
    public class DeleteBookCommandValidation : AbstractValidator<DeleteBookCommand>
    {
        public DeleteBookCommandValidation()
        {
            RuleFor(x => x.Id).NotEqual(Guid.Empty);
        }
    }
}
