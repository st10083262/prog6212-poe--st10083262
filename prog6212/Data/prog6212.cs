using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using progfinal11111.Models;

namespace progfinal11111.Data
{
    public class prog6212 : DbContext
    {
        public prog6212 (DbContextOptions<prog6212> options)
            : base(options)
        {
        }

        public DbSet<progfinal11111.Models.Class> Class { get; set; } = default!;

        public DbSet<progfinal11111.Models.Student> Student { get; set; }

        public DbSet<progfinal11111.Models.Class1> Class1 { get; set; }

        public DbSet<progfinal11111.Models.CALENDER> CALENDER { get; set; }
    }
}
