using Application.Users.Queries.Login;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Books.Queries.GetBooksByTitle
{
    public class GetBookByTitleValidation : AbstractValidator<GetBooksByTitleQuery>
    {
        public GetBookByTitleValidation()
        {
            RuleFor(x => x.Title).NotEmpty();
        }
    }
}
