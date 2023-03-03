using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace JPConsultoria.Models
{

[Table("Produto")]
    public class Produto
    {        
        [Key]
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Descrição")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Column("Valor")]
        [Display(Name = "Valor")]
        public float Valor { get; set; }
        
        
    }
}
