using Application.Books.Commands.AddBookToFavorites;
using Application.Books.Commands.CreateBook;
using Application.Books.Commands.UpdateBook;
using Application.Books.Commands.DeleteBook;
using Application.Books.Queries;
using Application.Books.Queries.GetBooks;
using Application.Books.Queries.GetBooksByCategory;
using Application.Books.Queries.GetBooksByTitle;
using Application.Common.Constants;
using BookCatalogApi.Models;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookCatalogApi.Controllers
{
    [Authorize]
    public class BookController : BaseController
    {
        [HttpGet("books")]
        public async Task<ActionResult<BookListDetailsVm>> GetBooks()
        {
            return await Mediator.Send(new GetBookListQuery());
        }
        
        [HttpGet("get-book-by-category/{categoryId}")]
        public async Task<ActionResult<BookListDetailsVm>> GetBooksByCategory(Guid categoryId)
        {
            var result = await Mediator.Send(new GetBooksByCategoryQuery { Id = categoryId });
            return Ok(result);
        }

        [HttpGet("get-book-by-title/{title}")]
        public async Task<ActionResult<BookListDetailsVm>> GetBooksByTitle(string title)
        {
            var result = await Mediator.Send(new GetBooksByTitleQuery { Title = title });
            return Ok(result);
        }

        [Authorize(Roles = UserRoles.ADMIN_ROLE)]
        [HttpPost("create-book")]
        public async Task<ActionResult<Guid>> CreateBook(CreateBookCommand command)
        {
            return await Mediator.Send(command);
        }

        [Authorize(Roles = UserRoles.USER_ROLE)]
        [HttpPost("add-book-to-favorite")]
        public async Task<ActionResult<Book>> AddBookToFavorite([FromBody] AddBookToFavoriteDTO dto) 
        {

            var command = Mapper.Map<AddBookToFavoriteCommand>(dto);
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        [Authorize(Roles = UserRoles.ADMIN_ROLE)]
        [HttpPost("update-book")]
        public async Task<ActionResult> UpdateBook([FromBody] UpdateBookDTO dto)
        {
            var command = Mapper.Map<UpdateBookCommand>(dto);
    
            await Mediator.Send(command);
            return NoContent();
        }

        [Authorize(Roles = UserRoles.ADMIN_ROLE)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany(Guid id)
        {
            await Mediator.Send(new DeleteBookCommand { Id = id });
            return NoContent();
        }
    }
}
