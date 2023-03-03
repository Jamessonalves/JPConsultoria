using Microsoft.EntityFrameworkCore;

namespace JPConsultoria.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            
        }
    public DbSet<Cliente> Cliente { get; set; }
    public DbSet<Fornecedor> Fornecedor { get; set; }
    public DbSet<Funcionario> Funcionario { get; set; }
    public DbSet<Produto> Produto { get; set; }


    }
}
