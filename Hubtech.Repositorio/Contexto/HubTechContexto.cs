using Hubtech.Dominio.Entidades;
using Hubtech.Dominio.ObjetoDeValor;
using Hubtech.Repositorio.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hubtech.Repositorio.Contexto
{
    public class HubTechContexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public HubTechContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlServer("server=hubtech.database.windows.net;database=ProjectHubTech;User ID=zdog;password=Gabriel123;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /// Classes de mapeamento aqui...
            modelBuilder.ApplyConfiguration(new UsuarioConfig());
            modelBuilder.ApplyConfiguration(new ProdutoConfig());
            modelBuilder.ApplyConfiguration(new PedidoConfig());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfig());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfig());

            /*modelBuilder.Entity<FormaPagamento>().HasData(new FormaPagamento()
            { 
                Id = 1, Nome = "Boleto", 
                Descricao = "Forma de Pagamento Boleto"
            },
            new FormaPagamento()
            {
                Id = 2, Nome = "Cartao de Credito",
                Descricao = " Forma de Pagamento Cartao de Crédito"
            },
            new FormaPagamento() 
            { 
                Id = 3, Nome = "Deposito",
                Descricao = "Forma de Pagamento por Depósito"
            });*/

            base.OnModelCreating(modelBuilder);
        }
    }
}
