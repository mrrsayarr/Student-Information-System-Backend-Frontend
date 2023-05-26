using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SIS.Models;

namespace SIS.Data
{
    public class SISContext : DbContext
    {
        public SISContext (DbContextOptions<SISContext> options)
            : base(options)
        {
        }

        public DbSet<SIS.Models.Students> Students { get; set; } = default!;

        public DbSet<SIS.Models.Login>? Login { get; set; }
        public DbSet<SIS.Models.Generals>? ExamResults { get; set; }
    }
}
