using ApexCare.Models;
using Microsoft.EntityFrameworkCore;

namespace ApexCare.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<RequestMessage> RequestMessages { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobStatus> JobStatuses { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Technician> Technicians { get; set; }
        public DbSet<TechnicianSkill> TechnicianSkills { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Term> Terms { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<PackagePromotion> PackagePromotions { get; set; }
        public DbSet<PackageService> PackageServices { get; set; }
        public DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RequestMessage>()
                .HasOne(rm => rm.Request)
                .WithMany(r => r.RequestMessages)
                .HasForeignKey(rm => rm.RequestID);

            modelBuilder.Entity<Request>()
                .HasOne(r => r.Client)
                .WithMany(c => c.Requests)
                .HasForeignKey(r => r.ClientID);

            modelBuilder.Entity<Job>()
                .HasOne(j => j.Request)
                .WithMany(r => r.Jobs)
                .HasForeignKey(j => j.RequestID);

            modelBuilder.Entity<Job>()
                .HasOne(j => j.Technician)
                .WithMany(t => t.Jobs)
                .HasForeignKey(j => j.TechnicianID);

            modelBuilder.Entity<JobStatus>()
                .HasOne(js => js.Job)
                .WithMany(j => j.JobStatuses)
                .HasForeignKey(js => js.JobID);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Job)
                .WithOne(j => j.Review)
                .HasForeignKey<Review>(r => r.JobID);

            modelBuilder.Entity<TechnicianSkill>()
                .HasOne(ts => ts.Technician)
                .WithMany(t => t.TechnicianSkills)
                .HasForeignKey(ts => ts.TechnicianID);

            modelBuilder.Entity<TechnicianSkill>()
                .HasOne(ts => ts.Skill)
                .WithMany(s => s.TechnicianSkills)
                .HasForeignKey(ts => ts.SkillID);

            modelBuilder.Entity<Subscription>()
                .HasOne(s => s.Client)
                .WithMany(c => c.Subscriptions)
                .HasForeignKey(s => s.ClientID);

            modelBuilder.Entity<Subscription>()
                .HasOne(s => s.Term)
                .WithMany(t => t.Subscriptions)
                .HasForeignKey(s => s.TermID);

            modelBuilder.Entity<Subscription>()
                .HasOne(s => s.Package)
                .WithMany(p => p.Subscriptions)
                .HasForeignKey(s => s.PackageID);

            modelBuilder.Entity<PackagePromotion>()
                .HasOne(pp => pp.Package)
                .WithMany(p => p.PackagePromotions)
                .HasForeignKey(pp => pp.PackageID);

            modelBuilder.Entity<PackageService>()
                .HasOne(ps => ps.Package)
                .WithMany(p => p.PackageServices)
                .HasForeignKey(ps => ps.PackageID);

            modelBuilder.Entity<PackageService>()
                .HasOne(ps => ps.Service)
                .WithMany(s => s.PackageServices)
                .HasForeignKey(ps => ps.ServiceID);
        }
    }
}
