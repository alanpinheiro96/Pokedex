using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models;

[Table("Pokemon")]

public class Pokemon
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public uint Numero { get; set; }

    [Required]
    public uint RegiaoId { get; set; }
    [ForeignKey("RegiaoId")]
    public Regiao Regiao { get; set; }
}