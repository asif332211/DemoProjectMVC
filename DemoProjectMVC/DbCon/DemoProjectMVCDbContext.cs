using DemoProjectMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoProjectMVC.DbCon
{
    public class DemoProjectMVCDbContext:DbContext
    {
        public DemoProjectMVCDbContext(DbContextOptions<DemoProjectMVCDbContext> options) : base(options) { 
        }
        public DbSet<Student> Students { get; set; }    
    }
}
