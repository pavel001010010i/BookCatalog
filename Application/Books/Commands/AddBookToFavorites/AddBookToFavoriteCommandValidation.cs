using FluentValidation;

namespace Application.Books.Commands.AddBookToFavorites
{
    public class AddBookToFavoriteCommandValidation : AbstractValidator<AddBookToFavoriteCommand>
    {
        public AddBookToFavoriteCommandValidation()
        {
            RuleFor(x => x.UserId).NotEmpty();
            RuleFor(x => x.BookId).NotEmpty();
        }
    }
}
