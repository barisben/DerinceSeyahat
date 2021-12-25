using DerinceSeyahat.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DerinceSeyahat.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Arac> Araclar { get; set; }
        public object Arac { get; internal set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
