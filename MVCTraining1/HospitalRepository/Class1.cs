using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PatientLibrary;
using System;

namespace HospitalRepository
{
    public class HospitalDbContext : DbContext
    {
        //private IConfiguration Configuration;
        //mapping inherits from DbContext
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options)
                :base(options)
        {
        
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=DESKTOP-7AEQ0NP;Initial Catalog=HospitalManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>()
                        .ToTable("tblPatient");
            modelBuilder.Entity<PatientProblems>()
                        .ToTable("tblProblem");
            modelBuilder.Entity<Treatment>()
                        .ToTable("tblTreatment");
        }
        public DbSet<Patient> patients { get; set; }
    }
}
