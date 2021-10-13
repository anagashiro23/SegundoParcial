using Microsoft.EntityFrameworkCore;
using SegundoParcialAndresNagashiro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoParcialAndresNagashiro.Data
{
    public class AppDbContext : DbContext

    {
        public DbSet<Naipe> Naipes { get; set; } 

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

    }
}
