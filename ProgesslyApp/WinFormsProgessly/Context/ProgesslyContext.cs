using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsProgessly.Entities;

namespace WinFormsProgessly.Data
{
    public class ProgesslyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=EMAA;Database=ProgesslyDb;User ID=ProgesslyApp;Password=progessly123;TrustServerCertificate=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TareaModel>()
                .Property(t => t.Status)
                .HasConversion<string>(); // Esto convierte el enum a texto en la base de datos

            modelBuilder.Entity<ProjectModel>()
               .Property(t => t.Status)
               .HasConversion<string>();
        }

        
     
        public DbSet<ProjectModel> Projects { get; set; }

        public DbSet<TareaModel> Tareas { get; set; }

        public DbSet <ResponsableModel> Responsables { get; set; }
    }
}
