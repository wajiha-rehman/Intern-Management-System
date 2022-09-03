﻿ 
using IMS.Areas.Identity.Data;
using IMS.Models.Data; 
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IMS.Data
{
    public class IMSDbContext : IdentityDbContext<IMSApplicationUser>
    {
        //public IMSDbContext(DbContextOptions<IMSDbContext> options)
        //    : base(options)
        //{
        //}

        public IMSDbContext(DbContextOptions<IMSDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
