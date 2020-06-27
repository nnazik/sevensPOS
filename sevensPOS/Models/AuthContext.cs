using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sevensPOS.Models
{
    public class AuthContext : IdentityDbContext
    {
        public AuthContext(DbContextOptions options):base(options)
        {
             
        }

        public DbSet<ApplicationUser>  ApplicationUsers { get; set; }
    }
}
