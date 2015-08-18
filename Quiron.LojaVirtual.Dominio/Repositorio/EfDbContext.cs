using Quiron.LojaVirtual.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
   public class EfDbContext : DbContext
    {

       public DbSet<Produto> Produtos { get; set; }

       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           //O entity cria o nome das tabelas no plural e isso pode causar problemas quando sua tabela ja está no plural.
           //Este codigo define especificamente como a tabela deve ser criado pelo entity.
           modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
           modelBuilder.Entity<Produto>().ToTable("Produtos");
       }
    }
}
