using Application.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace Application.Books.Queries.GetBooks
{
    public class GetBookListQueryHandler : IRequestHandler<GetBookListQuery, BookListDetailsVm>
    {
        private readonly IDBContext _dbContext;
        private readonly IMapper _mapper;
        public GetBookListQueryHandler(IDBContext dbContext, IMapper mapper)
            => (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<BookListDetailsVm> Handle(GetBookListQuery request, CancellationToken cancellationToken)
        {
            var bookQuery = await _dbContext.Books
                .OrderBy(x => x.Author)
                .AsNoTracking()
                .ProjectTo<BookDetailsVm>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new BookListDetailsVm { Books = bookQuery };
        }
    }
}
