﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMS.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
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
            : base("IMSDbContextConnection")
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
