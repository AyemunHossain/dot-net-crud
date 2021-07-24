using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Rocky.Data
{
    public class ProjectDbContext:DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options): base(options)
        {

        }

        public DbSet<Models.Category> Category { get; set; }
        public DbSet<Models.ApplicationType> ApplicationType { get; set; }
    }
}
