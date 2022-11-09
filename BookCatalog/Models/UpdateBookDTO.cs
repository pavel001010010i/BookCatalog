using Application.Common.Mapping;
using Application.Users.Command.UpdateBook;
using AutoMapper;

namespace BookCatalogApi.Models
{
    public class UpdateBookDTO : IMapWith<UpdateBookCommand>
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
            profile.CreateMap<UpdateBookDTO, UpdateBookCommand>();
        }
    }

}
