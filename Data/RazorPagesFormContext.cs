using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesForm.Models;

    public class RazorPagesFormContext : DbContext
    {
        public RazorPagesFormContext (DbContextOptions<RazorPagesFormContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesForm.Models.Patient> Patient { get; set; }
    }
