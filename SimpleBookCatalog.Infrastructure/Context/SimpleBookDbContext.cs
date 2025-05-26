using Microsoft.EntityFrameworkCore;
using SimpleBookCatalog.Domain.Entities;


namespace SimpleBookCatalog.Infrastructure.Context
{
    public class SimpleBookDbContext: DbContext
    {
        public SimpleBookDbContext(DbContextOptions<SimpleBookDbContext> options): base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }
    }
}
