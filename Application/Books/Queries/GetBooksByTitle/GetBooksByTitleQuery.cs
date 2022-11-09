using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Books.Queries.GetBooksByTitle
{

    public class GetBooksByTitleQuery : IRequest<BookListDetailsVm>
    {
        public string Title{ get; set; }
    }
}
