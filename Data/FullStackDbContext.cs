using Iksha_Api_Practice.Modal;
using Microsoft.EntityFrameworkCore;

namespace Iksha_Api_Practice.Data
{
    public class FullStackDbContext: DbContext
    {
        public FullStackDbContext(DbContextOptions options) : base(options) 
        {
        
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
