using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleEFProject.Models
{
    public class SampleEFProjectContext : DbContext
    {
        public SampleEFProjectContext(DbContextOptions<SampleEFProjectContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Table> Tables { get; set; }
    }
}
