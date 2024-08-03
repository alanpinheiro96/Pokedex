using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models;

[Table("Tipo")]

public class Tipo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public uint Id { get; set; }

    [Required(ErrorMessageResourceName = "Informe o nome")]
    [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30 caracteres")]
    public string Nome { get; set; }

    [Required(ErrorMessageResourceName = "Informe a Cor")]
    [StringLength(25, ErrorMessage = "A Cor deve possuir no máximo 25 caracteres")]
    public string Cor { get; set; }

}