using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoApi.Models;
using GestaoApi.Utils;
using Microsoft.EntityFrameworkCore;


namespace GestaoApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Cliente> TB_CLIENTES { get; set;}
        public DbSet<OrdemServico> TB_ORDEMSERVICOS { get; set;}
        public DbSet<Equipamento> TB_EQUIPAMENTOS { get; set; }
        public DbSet<Tecnico> TB_TECNICOS { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("TB_CLIENTE");
            modelBuilder.Entity<OrdemServico>().ToTable("TB_ORDEMSERVICOS");
            modelBuilder.Entity<Equipamento>().ToTable("TB_EQUIPAMENTOS");
            modelBuilder.Entity<Tecnico>().ToTable("TB_TECNICO");
            //modelBuilder.Entity<OrdemEquipamento>().ToTable("TB_ORDEM_EQUIPAMENTO");
            
            //RELACIONAMENTOS              
            // Configura a relação one-to-one
            modelBuilder.Entity<Cliente>()
                .HasOne(c => c.OrdemServico) // Propriedade de navegação de Cliente para OrdemServico
                .WithOne(o => o.Cliente) // Propriedade de navegação de OrdemServico para Cliente
                .HasForeignKey<OrdemServico>(o => o.ClienteId); // Define qual é a chave estrangeira (lado dependente)

            modelBuilder.Entity<Tecnico>()
                .HasOne(e => e.OrdemServico) // Propriedade de navegação de OrdemServico para tecnico
                .WithOne(o => o.Tecnico) // Propriedade de navegação de tecnico para OrdemServico
                .HasForeignKey<OrdemServico>(o => o.EquipamentoId); // Define o lado dependente e a chave estrangeira

            // Configurando o relacionamento One-to-One entre Cliente e Equipamento
            modelBuilder.Entity<Cliente>()
                .HasOne(c => c.Equipamento)      // Cliente tem um Equipamento
                .WithOne(e => e.Cliente)         // Equipamento tem um Cliente
                .HasForeignKey<Equipamento>(e => e.ClienteId) // Define a chave estrangeira em Equipamento
                .IsRequired(false); // Caso a relação seja opcional, como no seu caso

            // Configura a relação one-to-one entre Equipamento e OrdemServico
            modelBuilder.Entity<Equipamento>()
                .HasOne(e => e.OrdemServico) // Propriedade de navegação de Equipamento para OrdemServico
                .WithOne(o => o.Equipamento) // Propriedade de navegação de OrdemServico para Equipamento
                .HasForeignKey<OrdemServico>(o => o.EquipamentoId); // Define o lado dependente e a chave estrangeira

            // Configuração da relação one-to-one
            modelBuilder.Entity<OrdemEquipamento>()
                .HasOne(oe => oe.Equipamento) // OrdemEquipamento tem um Equipamento
                .WithOne(e => e.OrdemEquipamento) // Equipamento tem um OrdemEquipamento
                .HasForeignKey<OrdemEquipamento>(oe => oe.NumSerie); // NumSerie é a chave estrangeira

            // Configuração da chave composta para OrdemEquipamento
            modelBuilder.Entity<OrdemEquipamento>()
                .HasKey(oe => new { oe.OrdemId, oe.NumSerie }); // Chave composta

            // Configuração do relacionamento entre OrdemEquipamento e OrdemServico
            modelBuilder.Entity<OrdemEquipamento>()
                .HasOne(oe => oe.OrdemServico) // OrdemEquipamento tem uma OrdemServico
                .WithMany(os => os.OrdemEquipamentos) // OrdemServico tem muitos OrdemEquipamentos
                .HasForeignKey(oe => oe.OrdemId); // OrdemId é a chave estrangeira

            // Configuração do relacionamento entre OrdemEquipamento e Equipamento
            modelBuilder.Entity<OrdemEquipamento>()
                .HasOne(oe => oe.Equipamento) // OrdemEquipamento tem um Equipamento
                .WithMany(e => e.OrdemEquipamentos) // Equipamento tem muitos OrdemEquipamentos
                .HasForeignKey(oe => oe.NumSerie); // NumSerie é a chave estrangeira


            modelBuilder.Entity<OrdemServico>().HasData
            (
                new OrdemServico() { Id = 1, status = (Models.Enuns.StatusEnum)3, Atividade = "Substituido HD", DataCriacao = 10112024, DataAvaliacao = 10112024, DataFinalizacao = 12112024, DataEntrega = 13112024, ValorServico = 350},                new OrdemServico() { Id = 2, status = (Models.Enuns.StatusEnum)5, Atividade = "Revisado e testado", DataCriacao = 10112024, DataAvaliacao = 10112024, DataFinalizacao = 13112024, DataEntrega = 13112024, ValorServico = 950 }
            );

            modelBuilder.Entity<Cliente>().HasData
            (
                // inserir as linhas " new cliente() { id= 1 .....}
                new Cliente() { Id = 1, Nome = "Jonnathan", Sobrenome = "Santos", Cpf = "46881735070", Celular = 11999988877, Endereco = "Rua Napoleao", EndNum = 1543, Bairro = "Vila Guilherme", Cidade = "São Paulo", UF = "SP"},                
                new Cliente() { Id = 2, Nome = "Amadeu", Sobrenome = "Romusvaldo", Cpf = "5717425885", Celular = 11991492477, Endereco = "Rua Seilandia", EndNum = 23, Bairro = "Seilandia", Cidade = "São Paulo", UF = "SP"},
                new Cliente() { Id = 3, Nome = "Abel", Sobrenome = "Santo", Cpf = "12345678901", Celular = 1199988776655, Endereco = "Rua da irmandadde", EndNum = 50, Bairro = "Vila Armadada", Cidade = "São Paulo", UF = "SP"},
                new Cliente() { Id = 2, Nome = "Magno", Sobrenome = "Magnanimo", Cpf = "52875298410", Celular = 11923492477, Endereco = "Rua quarteto", EndNum = 153, Bairro = "X-men", Cidade = "São Paulo", UF = "SP"}
            );

            modelBuilder.Entity<Equipamento>().HasData
            (
                new Equipamento() {NumSerie = 5432414, Nome= "Computador", Marca = "Dell", Modelo = "D100I9", Acessorios = "Cabo AC", Defeito= "Não reconhece HD"},
                new Equipamento() {NumSerie = 5432156, Nome= "Notebook", Marca = "Apple", Modelo = "Macbook01", Acessorios = "Fonte externa", Defeito= "Realizar revisão"},
                new Equipamento() {NumSerie = 8975234, Nome= "Impressora", Marca = "Samsung", Modelo = "S1000", Acessorios = "Cabo AC, Cabo usb", Defeito= "Não imprime colorido"},
                new Equipamento() {NumSerie = 8456466, Nome= "Impressora", Marca = "Epson", Modelo = "EP1000", Acessorios = "Sem Acessorios", Defeito= "Não imprime colorido"}
            );

            modelBuilder.Entity<Tecnico>().HasData
            (
                new Tecnico() { Id = 100, Nome = "Chico",Sobrenome = "Tavares" ,Cpf = "98765432115", Especialidade = "Eletricista"},
                new Tecnico() { Id = 101, Nome = "Castiel",Sobrenome = "Silva" ,Cpf = "44265432115", Especialidade = "Informática"},
                new Tecnico() { Id = 102, Nome = "Baltazar",Sobrenome = "Santo" ,Cpf = "85265432115", Especialidade = "Pedreiro"}
            );

            
             // Configuração da chave composta para OrdemEquipamento
            modelBuilder.Entity<OrdemEquipamento>()
                .HasKey(oe => new { oe.OrdemId, oe.NumSerie }); // Define OrdemId e NumSerie como chave composta

            // Adicionando dados iniciais para a tabela OrdemEquipamento
            modelBuilder.Entity<OrdemEquipamento>().HasData
            (
                new OrdemEquipamento() { OrdemId = 1, NumSerie = 5432414 },
                new OrdemEquipamento() { OrdemId = 2, NumSerie = 5432156 },
                new OrdemEquipamento() { OrdemId = 3, NumSerie = 8975234 },
                new OrdemEquipamento() { OrdemId = 4, NumSerie = 8456466 }
            );
            




              //Início da criação do usuário padrão.
            Usuario user = new Usuario();
            Criptografia.CriarPasswordHash("123456", out byte[] hash, out byte[] salt);
            user.Id = 1;
            user.Username = "UsuarioAdmin";
            user.PasswordString = string.Empty;
            user.PasswordHash = hash;
            user.PasswordSalt = salt;
            user.Perfil = "Admin";
            user.Email = "seuEmail@gmail.com";
            user.Latitude = -23.5200241;
            user.Longitude = -46.596498;

            modelBuilder.Entity<Usuario>().HasData(user);
            //Fim da criação do usuário padrão.   

            //Define que se o Perfil não for informado, o valor padrão será jogador
            modelBuilder.Entity<Usuario>().Property(u => u.Perfil).HasDefaultValue("Jogador");


            base.OnModelCreating(modelBuilder);
        }



        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>()
                .HaveColumnType("varchar").HaveMaxLength(200);

            base.ConfigureConventions(configurationBuilder);
        }
    }

}