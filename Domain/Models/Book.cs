using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Domain.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string BookCover { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int Pages{ get; set; }
        public DateTime YearPrint{ get; set; }

        [ForeignKey(nameof(Category))]
        public Guid CategoryId { get; set; }
        public IList<AppUser> Users { get; set; } = new List<AppUser>();
    }
}
