using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF01
{
    internal class CompanyG030DBContext :DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasKey(E =>E.EmpId);
            modelBuilder.Entity<Employee>()
                .Property(E => E.EmpId)
                .UseIdentityColumn(1,1);

            modelBuilder.Entity<Employee>()
               .Property(E => E.EmpId)
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .HasDefaultValue("mo");

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = CompanyG03DB;Trusted_Connection = True");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
    //Class configurations
}
