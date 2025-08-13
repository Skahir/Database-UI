using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorLearningApp.Models;

namespace BlazorLearningApp.Data
{
    public class BlazorLearningAppContext : DbContext
    {
        public BlazorLearningAppContext (DbContextOptions<BlazorLearningAppContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorLearningApp.Models.Item> Item { get; set; } = default!;
    }
}
