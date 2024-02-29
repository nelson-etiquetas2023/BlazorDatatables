using Microsoft.EntityFrameworkCore;
using Shared.Datatables.net.Models;

namespace Backend.Datatables.net.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }
        public DbSet<Ponches> Ponches { get; set; }
        public DbSet<UsersPonches> UserPonches { get; set; }
    }
}
