using Microsoft.EntityFrameworkCore;
using RealEstate.EntityLayer.Entities;

namespace RealEstate.DataAccessLayer.Concrete
{
    public class EstateContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=EstateDb;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactSend> ContactSends { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Estate> Estates { get; set; }
        public DbSet<FooterContact> FooterContacts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
