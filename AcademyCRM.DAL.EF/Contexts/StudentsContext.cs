using AcademyCRM.BLL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCRM.DAL.EF.Contexts
{
    public class StudentsContext : DbContext
    {
        public DbSet<Student> Students { get; set; } = default!;

        public StudentsContext()
        {
            
        }
        public StudentsContext(DbContextOptions<StudentsContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AcademyCrmDb;Trusted_Connection=True;");
        }
    }
}
