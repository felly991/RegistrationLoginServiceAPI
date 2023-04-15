using Microsoft.EntityFrameworkCore;
using RegistrationServiceAPI.Models;

namespace RegistrationServiceAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<User> users { get; set; }
    }
}
