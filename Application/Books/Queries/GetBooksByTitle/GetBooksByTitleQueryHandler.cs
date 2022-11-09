using Application.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace Application.Books.Queries.GetBooksByTitle
{
    public class GetBooksByTitleQueryHandler : IRequestHandler<GetBooksByTitleQuery, BookListDetailsVm>
    {
        private readonly IDBContext _dbContext;
        private readonly IMapper _mapper;
        public GetBooksByTitleQueryHandler(IDBContext dbContext, IMapper mapper)
            => (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<BookListDetailsVm> Handle(GetBooksByTitleQuery request, CancellationToken cancellationToken)
        {
            var bookQuery = await _dbContext.Books
                .Where(x => x.Title.ToLower().Contains(request.Title.ToLower()))
                .OrderBy(x => x.Author)
                .AsNoTracking()
                .ProjectTo<BookDetailsVm>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new BookListDetailsVm { Books = bookQuery };
        }
    }
}
