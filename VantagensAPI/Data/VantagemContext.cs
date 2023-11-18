using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using VantagensAPI.Models;

namespace VantagensAPI.Data
{
    public class VantagemContext : DbContext
    {
        public DbSet<Vantagem> vantagens { get; set; }
        public VantagemContext(DbContextOptions<VantagemContext> opts)
            : base(opts)
        {

        }
    }
}
