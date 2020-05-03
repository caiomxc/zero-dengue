﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZeroDengue.Models;

namespace ZeroDengue.Data
{
    public class ZeroDengueContext : DbContext
    {
        public ZeroDengueContext (DbContextOptions<ZeroDengueContext> options)
            : base(options)
        {
        }

        public DbSet<ZeroDengue.Models.User> User { get; set; }
    }
}
