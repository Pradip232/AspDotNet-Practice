using AspDotNet_Practice.Models;
using Microsoft.EntityFrameworkCore;
//Added two nuget packages:
//Microsoft.EntityFrameworkCore.SqlServer(ver 3.x)
//Microsoft.EntityFrameworkCore.Tool(ver 3.x)
//Keep both of then with same versions


namespace AspDotNet_Practice.Data
{
    public class ApplicationDbContext: DbContext                //DbContext tells us how to connect to database
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }


        public DbSet<Category> Categories { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }
    }
}
