using Application.Common.Mapping;
using AutoMapper;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users.Command.UpdateBook
{
    public class UpdateBookCommand : IRequest, IMapWith<Book>
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
            profile.CreateMap<UpdateBookCommand, Book>();
        }
    }
}
