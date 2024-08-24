using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models;

[Table("Tipo")]
public class Tipo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o nome")]
    [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30 caracteres")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Informe a cor")]
    [StringLength(25, ErrorMessage = "A Cor deve possuir no máximo 25 caracteres")]
    public string Cor { get; set; }

    public ICollection<PokemonTipo> Pokemons { get; set; }
}
