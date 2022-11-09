using Domain.Models;
using Microsoft.EntityFrameworkCore;


namespace Application.Interfaces
{
    public interface IDBContext
    {
        DbSet<Book> Books { get; set; }
        DbSet<Category> Categories { get; set; }
        Task<int> SaveChangesAsync(CancellationToken concellationToken);
    }
}
    
