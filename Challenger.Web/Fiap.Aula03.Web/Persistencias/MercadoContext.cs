using Fiap.Aula03.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Aula03.Web.Persistencias
{
    public class MercadoContext : DbContext
    {
        //Conjunto de clientes que estão no banco de dados

        public DbSet<Produto> Produtos { get; set; }

        public MercadoContext(DbContextOptions op) : base(op) { }
        //Construtor que recebe as options e envia para o construtor do pai

    }
}
