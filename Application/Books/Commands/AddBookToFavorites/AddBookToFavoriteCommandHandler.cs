using Application.Common.Exeption;
using Application.Interfaces;
using AutoMapper;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace Application.Books.Commands.AddBookToFavorites
{
    public class AddBookToFavoriteCommandHandler : IRequestHandler<AddBookToFavoriteCommand, Book>
    {
        private readonly IDBContext _dbContext;
        private readonly UserManager<AppUser> _manager;
        public AddBookToFavoriteCommandHandler(IDBContext dbContext, UserManager<AppUser> manager) => 
            (_dbContext, _manager) = (dbContext, manager);
        public async Task<Book> Handle(AddBookToFavoriteCommand request, CancellationToken cancellationToken)
        {
            var book = 
                await _dbContext.Books.
                Include(x=>x.Users)
                .FirstOrDefaultAsync(x => x.Id == request.BookId, cancellationToken);

            if(book == null)
                throw new NotFoundException(nameof(Book), request.BookId);

            var user = await _manager.FindByIdAsync(request.UserId.ToString());
            if (user == null)
                throw new NotFoundException(nameof(AppUser), request.UserId);

            book.Users.Add(user);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return book;
        }
    }
}
