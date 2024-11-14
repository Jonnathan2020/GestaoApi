using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Cliente> TB_CLIENTE { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("TB_CLIENTE");
            
            modelBuilder.Entity<Cliente>().HasData
            (
                // inserir as linhas " new cliente() { id= 1 .....}
                new Cliente() { Id = 1, Nome = "Jonnathan", Sobrenome = "Santos", Cpf = "46881735070", Celular = 11999988877, Endereco = "Rua Napoleao", EndNum = 1543, Bairro = "Vila Guilherme", Cidade = "São Paulo", UF = "SP"},
                new Cliente() { Id = 2, Nome = "Amadeu", Sobrenome = "Romusvaldo", Cpf = "5717425885", Celular = 11991492477, Endereco = "Rua Seilandia", EndNum = 23, Bairro = "Seilandia", Cidade = "São Paulo", UF = "SP"},
                new Cliente() { Id = 3, Nome = "Abel", Sobrenome = "Santo", Cpf = "12345678901", Celular = 1199988776655, Endereco = "Rua da irmandadde", EndNum = 50, Bairro = "Vila Armadada", Cidade = "São Paulo", UF = "SP"},
                new Cliente() { Id = 2, Nome = "Magno", Sobrenome = "Magnanimo", Cpf = "52875298410", Celular = 11923492477, Endereco = "Rua quarteto", EndNum = 153, Bairro = "X-men", Cidade = "São Paulo", UF = "SP"}
            );
        }
    }
    
}