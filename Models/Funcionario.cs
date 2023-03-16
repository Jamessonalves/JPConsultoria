using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace JPConsultoria.Models
{

[Table("Funcionario")]
    public class Funcionario
    {
        [Key]
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Cpf")]
        [Display(Name = "Cpf")]
        public string Cpf { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        [Column("Departamento")]
        [Display(Name = "Departamento")]
        public string Departamento { get; set; }

        [Column("Cargo")]
        [Display(Name = "Cargo")]
        public string Cargo { get; set; }

        [Column("Salário")]
        [Display(Name = "Salário")]
        public decimal salario { get; set; }
        
        
    }
}
