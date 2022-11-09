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
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData
            (
            new Category
            {
                Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                Name= "Fantastic"
            },
             new Category
             {
                 Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                 Name = "Thriller"
             });

        }

    }
}
