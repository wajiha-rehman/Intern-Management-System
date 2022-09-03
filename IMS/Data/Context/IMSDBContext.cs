using IMS.Models.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMS.Models.Context
{
    public class IMSDBContext : DbContext
    {
        public IMSDBContext(DbContextOptions<IMSDBContext> options) : base ( options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<AttendanceCorrectionRequest> AttendanceCorrectionRequest { get; set; }
        public DbSet<Leave> Leave { get; set; }
        public DbSet<InternTask> InternTask { get; set; }
        public DbSet<InternDetails> InternDetails { get; set; }
        public DbSet<PerformanceReview> PerformanceReview { get; set; }
        public DbSet<InternshipProgram> InternshipProgram { get; set; }

        //protected override void OnModelCreating( ModelBuilder modelBuilder )
        //{
        //    base.OnModelCreating(modelBuilder);

        //    //modelBuilder.Entity<InternDetails>().HasOne(x => x.U).WithOne();
        //}
    }
    //public class IMSDBContext : DbContext
    //{
    //    public IMSDBContext(DbContextOptions options) : base()
    //    {

    //    }
    //}
}
