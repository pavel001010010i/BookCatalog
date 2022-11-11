using Application.Common.Exeption;
using Application.Interfaces;
using Domain.Models;
using MediatR;

namespace Application.Books.Commands.DeleteBook
{
    public class DeleteBookCommandHandler
        : IRequestHandler<DeleteBookCommand>
    {
        private readonly IDBContext _dbContext;
        public DeleteBookCommandHandler(IDBContext dbContext) => _dbContext = dbContext;

        public async Task<Unit> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var book = await _dbContext.Books
                .FindAsync(new object[] { request.Id }, cancellationToken);

            if (book == null)
                throw new NotFoundException(nameof(Book), request.Id);

            _dbContext.Books.Remove(book);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
