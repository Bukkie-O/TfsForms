using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TfsForms.Models;

namespace TfsForms.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Designee> Designees { get; set; }
        public DbSet<FalsePositive> FalsePositives { get; set; }
        public DbSet<Associate> Associates { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<ArchivetblResponse> ArchivetblResponses { get; set; }
        public DbSet<tblTempRE> tblTempREs { get; set; }
        public DbSet<lkRapidAMLRE> lkRapidAMLREs { get; set; }
        public DbSet<lkCRIMSLEA> lkCRIMSLEAs { get; set; }
        public DbSet<lkGoAMLRE> lkGoAMLREs { get; set; }
        //public DbSet<tblRE> tblREs { get; set; }
        //public DbSet<tblREPerson> tblREPersons { get; set; }

        


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<tblTempRE>().HasData([

            new tblTempRE
            {
                 Id = 1,
                 REName = "Access Bank"
            },
            new tblTempRE
            {
                 Id = 2,
                 REName = "GT Bank"
            },
            new tblTempRE
            {
                 Id = 3,
                 REName = "Standard Chartered Bank"
            },
            new tblTempRE
            {
                 Id = 4,
                 REName = "Zenith Bank"
            },
            new tblTempRE
            {
                 Id = 5,
                 REName = "Opay Digital Services"
            },
            new tblTempRE
            {
                 Id = 6,
                 REName = "Palmpay Limited"
            }
            ]);


            base.OnModelCreating(builder);

            // Upsert guard: one row per Question + Designee + ReportingEntity
            builder.Entity<Response>()
                .HasIndex(r => new { r.QuestionId, r.DesigneeId, r.ReportingEntityId })
                .IsUnique();
        

        }
    }
}
