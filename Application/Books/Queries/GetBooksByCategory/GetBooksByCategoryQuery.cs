using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Books.Queries.GetBooksByCategory
{

    public class GetBooksByCategoryQuery : IRequest<BookListDetailsVm>
    {
        public Guid Id { get; set; }
    }
}
