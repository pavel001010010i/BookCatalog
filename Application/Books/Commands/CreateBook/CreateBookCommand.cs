using Application.Common.Mapping;
using AutoMapper;
using Domain.Models;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


namespace Application.Books.Commands.CreateBook
{
    public class CreateBookCommand : IRequest<Guid>, IMapWith<Book>
    {
        public string BookCover { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int Pages { get; set; }
        public DateTime YearPrint { get; set; } = DateTime.Now;
        public Guid CategoryId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateBookCommand, Book>();
            
        }
    }
}
