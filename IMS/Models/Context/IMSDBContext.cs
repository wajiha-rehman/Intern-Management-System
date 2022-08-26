using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMS.Models.Context
{
    public class IMSDBContext : DbContext
    {
        public IMSDBContext() : base("name=IMSDbContextConnectionStaging")
        {

        }
    }
}
