using Application.Common.Exeption;
using Application.Interfaces;
using AutoMapper;
using Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace Application.Books.Commands.UpdateBook
{
    public class UpdateCommandHandler : IRequestHandler<UpdateBookCommand>
    {
        private readonly IDBContext _dbContext;
        private readonly IMapper _mapper;
        public UpdateCommandHandler(IDBContext dbContext, IMapper mapper) => (_dbContext, _mapper) = (dbContext, mapper);
        public async Task<Unit> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var book = await _dbContext.Books.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (book == null)
                throw new NotFoundException(nameof(Book), request.Id);

            _mapper.Map(request, book);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
