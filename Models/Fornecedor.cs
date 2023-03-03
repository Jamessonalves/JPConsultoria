using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace JPConsultoria.Models
{

[Table("Fornecedor")]
    public class Fornecedor
    {
        [Key]
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Column("Cnpj")]
        [Display(Name = "Cnpj")]
        public string Cnpj { get; set; }
        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        
    }
}