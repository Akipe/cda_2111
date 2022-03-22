using ApiCereals.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCereals
{
    public class CerealDbContext : DbContext
    {
        public DbSet<Cereal> Cereals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=dbcereals");
        }
    }
}
