using Microsoft.EntityFrameworkCore;
using UserDatabase.Core.Models;

namespace UserDatabase.Data;

public interface IUserDatabaseDbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<PhoneNumber> PhoneNumbers { get; set; }
    public DbSet<Address> Addresses { get; set; }
    DbSet<T> Set<T>() where T : class;
    public int SaveChanges();
}