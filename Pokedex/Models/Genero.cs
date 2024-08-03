using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models;

[Table("Genero")]
public class Genero
{
    [Key]

    public uint Id { get; set; }
    [Required(ErrorMessage = "Informe o nome")]
    [StringLength(30, ErrorMessage = "O nome deve possuir no Máximo 30 caracteres")]

    public String Nome { get; set; }


}
