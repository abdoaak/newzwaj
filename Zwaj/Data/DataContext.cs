using Microsoft.EntityFrameworkCore;
using Zwaj.Models;

namespace Zwaj.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options){}
 

        public DbSet<Value> Values { get; set; }
    }
}