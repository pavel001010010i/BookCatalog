using Application.Interfaces;
using AutoMapper;
using Domain.Models;
using MediatR;

namespace Application.Books.Commands.CreateBook
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, Guid>
    {
        private readonly IDBContext _dbContext;
        private readonly IMapper _mapper;
        public CreateBookCommandHandler(IDBContext dbContext, IMapper mapper) => (_dbContext, _mapper) = (dbContext, mapper);
        public async Task<Guid> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = _mapper.Map<Book>(request);
            book.Id = Guid.NewGuid();

            await _dbContext.Books.AddAsync(book, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return book.Id;
        }
    }
}
