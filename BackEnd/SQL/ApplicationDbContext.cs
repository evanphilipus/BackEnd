using BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.SQL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ms_storage_location> ms_storage_location { get; set; }
        public DbSet<tr_bpkb> tr_bpkb { get; set; }
    }
}
