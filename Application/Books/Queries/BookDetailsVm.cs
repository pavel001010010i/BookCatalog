using Application.Common.Mapping;
using AutoMapper;
using Domain.Models;

namespace Application.Books.Queries
{
    public class BookDetailsVm : IMapWith<Book>
    {
        public Guid Id { get; set; }
        public string BookCover { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int Pages { get; set; }
        public DateTime YearPrint { get; set; } = DateTime.Now;
        public Guid CategoryId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Book, BookDetailsVm>();
        }
    }
}
