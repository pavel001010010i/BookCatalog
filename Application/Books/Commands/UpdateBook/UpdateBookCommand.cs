using Application.Common.Mapping;
using AutoMapper;
using Domain.Models;
using MediatR;

namespace Application.Books.Commands.UpdateBook
{
    public class UpdateBookCommand : IRequest, IMapWith<Book>
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string BookCoverURL { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int Pages { get; set; }
        public DateTime YearPrint { get; set; } = DateTime.Now;
        

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateBookCommand, Book>();
        }
    }
}
