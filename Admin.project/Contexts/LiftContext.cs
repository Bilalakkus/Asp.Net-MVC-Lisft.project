using Admin.project.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Admin.project.Contexts
{
    public class LiftContext : DbContext
    {
        public LiftContext(DbContextOptions<LiftContext> opt) : base(opt)
        {

        }
        public DbSet<Menu> Menus { get; set; }

    }
}
