using Application.Books.Queries.GetBooksByTitle;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Books.Queries.GetBooksByCategory
{
    public class GetBooksByCategoryValidation : AbstractValidator<GetBooksByCategoryQuery>
    {
        public GetBooksByCategoryValidation()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
