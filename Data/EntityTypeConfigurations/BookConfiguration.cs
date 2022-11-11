using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Domain.Models;

namespace Data.EntityTypeConfigurations
{
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData
            (
            new Book
            {
                Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                BookCoverURL = "c:\\Data\\Image\\one.png",
                Description = "Book description one11",
                Author = "Author1111",
                Pages = 111,
                Title = "Boook one 1",
                YearPrint = DateTime.UtcNow,
                CategoryId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
            },
             new Book
             {
                 Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                 BookCoverURL = "c:\\Data\\Image\\two.png",
                 Description = "Book description twoo222",
                 Author = "Author22222",
                 Pages = 222,
                 Title = "Boook two 22",
                 YearPrint = DateTime.UtcNow,
                 CategoryId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
             },
             new Book
             {
                 Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                 BookCoverURL = "c:\\Data\\Image\\three.png",
                 Description = "Book description three",
                 Author = "Author333",
                 Pages = 333,
                 Title = "Boook three 33",
                 YearPrint = DateTime.UtcNow,
                 CategoryId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
             }); 
        }

    }
}
