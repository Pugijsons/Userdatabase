using Microsoft.EntityFrameworkCore;
using UserDatabase.Core.Models;

namespace UserDatabase.Data
{
    public class UserDatabaseDbContext : DbContext, IUserDatabaseDbContext
    {
        public UserDatabaseDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}