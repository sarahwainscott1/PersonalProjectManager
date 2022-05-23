using Microsoft.EntityFrameworkCore;

namespace PersonalProjectManager.Models {
    public class PPMDbContext : DbContext{

        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<Supplies> Supplies { get; set; } = null!;
        public virtual DbSet<Work> Works { get; set; } = null!;

        public PPMDbContext(DbContextOptions<PPMDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}
