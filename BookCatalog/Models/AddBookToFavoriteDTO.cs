using Application.Books.Commands.AddBookToFavorites;
using Application.Common.Mapping;
using AutoMapper;

namespace BookCatalogApi.Models
{
    public class AddBookToFavoriteDTO : IMapWith<AddBookToFavoriteCommand>
    {
        public Guid BookId { get; set; }
        public Guid UserId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AddBookToFavoriteDTO, AddBookToFavoriteCommand>();
        }
    }

}
