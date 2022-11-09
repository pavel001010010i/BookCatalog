using Domain.Models;
using MediatR;

namespace Application.Books.Commands.AddBookToFavorites
{
    public class AddBookToFavoriteCommand : IRequest<Book>
    {
        public Guid BookId{ get; set; }
        public string NameUser{ get; set; }
    }
}
