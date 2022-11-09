using Application.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace Application.Books.Queries.GetBooksByCategory
{
    public class GetBooksByCategoryQueryHandler : IRequestHandler<GetBooksByCategoryQuery, BookListDetailsVm>
    {
        private readonly IDBContext _dbContext;
        private readonly IMapper _mapper;
        public GetBooksByCategoryQueryHandler(IDBContext dbContext, IMapper mapper)
            => (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<BookListDetailsVm> Handle(GetBooksByCategoryQuery request, CancellationToken cancellationToken)
        {
            var bookQuery = await _dbContext.Books
                .Where(x=>x.CategoryId == request.Id)
                .OrderBy(x => x.Author)
                .AsNoTracking()
                .ProjectTo<BookDetailsVm>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new BookListDetailsVm { Books = bookQuery };
        }
    }
}
