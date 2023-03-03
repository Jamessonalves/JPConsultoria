using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace JPConsultoria.Models
{

[Table("Funcionario")]
    public class Funcionario : Cliente
    {
        
        
        [Column("Departamento")]
        [Display(Name = "Departamento")]
        public string Departamento { get; set; }

        [Column("Cargo")]
        [Display(Name = "Cargo")]
        public string Cargo { get; set; }

        [Column("Salário")]
        [Display(Name = "Salário")]
        public float salario { get; set; }
        
        
    }
}
