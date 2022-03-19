#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SqlServerEF.Models;

namespace SqlServerEF.Data
{
    public class SqlServerEFContext : DbContext
    {
        public SqlServerEFContext (DbContextOptions<SqlServerEFContext> options)
            : base(options)
        {
        }

        public DbSet<SqlServerEF.Models.Blog> Blog { get; set; }

        public DbSet<SqlServerEF.Models.Employee> Employee { get; set; }
    }
}
