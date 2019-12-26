using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Dados {
    public class AluraFilmesContexto : Microsoft.EntityFrameworkCore.DbContext {

        public Microsoft.EntityFrameworkCore.DbSet<Ator> Atores {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MSSQLLocalDB;Database=AluraFilmes;Trusted_connection=true;");
        }
    }
}
