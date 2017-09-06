using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstApproach
{
    public class DepartmentContext : DbContext
    {
        public DbSet<CodeFirst> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CodeFirst>().Property(u => u.Name).HasColumnName("DeptId");
        }
    }
}
