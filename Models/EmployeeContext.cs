using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreMVC_CRUD.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
            // Constractor Methot..
        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasKey(s => s.Id);
            modelBuilder.Entity<Employee>().Property(f => f.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Employee>().Property(s => s.FullName).HasColumnType("varchar (50)").IsRequired();
            modelBuilder.Entity<Employee>().Property(s => s.EmpCode).HasColumnType("varchar(100)");
            modelBuilder.Entity<Employee>().Property(s => s.Position).HasColumnType("varchar(100)");

            // Index
            modelBuilder.Entity<Employee>().HasIndex(i => i.FullName).HasName("FullNameIndex").IsUnique();
            modelBuilder.Entity<Employee>().HasIndex(i => i.EmpCode).HasName("EmpCodeIndex");
        }
    }
}
