using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models;


[Table("Regiao")]
public class Regiao


{
    [Key]

    public int Id { get; set; }

    [Required(ErrorMessageResourceName = "Informe o Nome")]
    [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]
    public int Nome { get; set; }
}
