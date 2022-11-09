using MediatR;

namespace Application.Books.Commands.DeleteBook
{
    public class DeleteBookCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
