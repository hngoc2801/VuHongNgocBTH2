using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VuHongNgocBTH2.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<VuHongNgocBTH2.Models.Student> Student { get; set; } = default!;

        public DbSet<VuHongNgocBTH2.Models.Faculty> Faculty { get; set; } = default!;
    }
