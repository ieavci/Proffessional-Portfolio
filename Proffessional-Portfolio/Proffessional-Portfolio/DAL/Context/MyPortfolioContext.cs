using Microsoft.EntityFrameworkCore;
using Proffessional_Portfolio.DAL.Entities;

namespace Proffessional_Portfolio.DAL.Context
{
    public class MyPortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
             => optionsBuilder.UseSqlServer("Server=db6917.public.databaseasp.net; Database=db6917; User Id=db6917; Password=jD#9F+2pqK=4; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True;");


        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocailMedia> SocailMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

    }
}
