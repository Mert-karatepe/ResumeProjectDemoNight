using Microsoft.EntityFrameworkCore;
using ResumeProjectDemoNight.Entitites;

namespace ResumeProjectDemoNight.Context
{
    public class ResumeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQL2025;initial catalog=Project1NightResumeDb;User Id=sa;Password=487693*qQ;trust server certificate=true;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
