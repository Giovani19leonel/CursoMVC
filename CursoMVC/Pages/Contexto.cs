using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CursoMVC.Pages
{
    public class Context : DbContext
    {

        public DbSet<CursoMVC.Pages.Shared.Categoria> Categorias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=localhost\SQLEXPRESS;Database=CursoMVC;Trusted_Connection=True;");
        }
    }
}
